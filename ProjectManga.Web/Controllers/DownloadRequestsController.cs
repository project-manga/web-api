namespace ProjectManga.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Domain;
    using Domain.Models;
    using Domain.Vos;
    using ProjectManga.Web.Filters;
    using ProjectManga.Web.Resources;
    using static HttpConstants;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    /// <summary>
    /// Exposes web api for scheduled downloads.
    /// </summary>
    [Route("/download-requests")]
    public class DownloadRequestsController : Controller
    {
        #region Constructors
        /// <summary>
        /// Creates the controller.
        /// </summary>
        /// <param name="mapper"></param>
        ///  <param name="unitOfWork"></param>
        /// <param name="downloadRequestRepository">Download request repository</param>
        public DownloadRequestsController(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IDownloadRequestRepository downloadRequestRepository)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            this.downloadRequestRepository = downloadRequestRepository ?? throw new ArgumentNullException(nameof(downloadRequestRepository));
        }
        #endregion

        #region Public
        /// <summary>
        /// Creates a new download request.
        /// </summary>
        /// <param name="downloadRequestResource">Download request</param>
        [HttpPost]
        [Consumes(ApplicationJson)]
        [Produces(ApplicationJson)]
        [ProducesResponseType(typeof(DownloadRequestResource), 201)]
        [ProducesResponseType(typeof(ModelStateDictionary), 400)]
        public async Task<IActionResult> CreateDownloadRequest([FromBody] SaveDownloadRequestResource downloadRequestResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var downloadRequest = mapper.Map<SaveDownloadRequestResource, DownloadRequest>(downloadRequestResource);

            downloadRequestRepository.Add(downloadRequest);
            await unitOfWork.CommitAsync();

            downloadRequest = await downloadRequestRepository.FindAsync(downloadRequest.Id);

            return CreatedAtAction(
                nameof(CreateDownloadRequest),
                mapper.Map<DownloadRequest, DownloadRequestResource>(downloadRequest));
        }

        /// <summary>
        /// Gets a download request.
        /// </summary>
        /// <param name="id">Download request id</param>
        [HttpGet("{id}")]
        [Produces(ApplicationJson)]
        [ProducesResponseType(typeof(DownloadRequestResource), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetDownloadRequest(long id)
        {
            var request = await downloadRequestRepository.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<DownloadRequest, DownloadRequestResource>(request));
        }

        /// <summary>
        /// Updates a download request.
        /// </summary>
        /// <param name="id">Download request id</param>
        /// <param name="downloadRequestResource">Download request</param>
        /// <response code="201">Returns the created response</response>
        [HttpPut("{id}")]
        [Consumes(ApplicationJson)]
        [Produces(ApplicationJson)]
        [ProducesResponseType(typeof(DownloadRequestResource), 201)]
        [ProducesResponseType(typeof(ModelStateDictionary), 400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateDownloadRequest(
            long id,
            [FromBody] SaveDownloadRequestResource downloadRequestResource)
        {
            var downloadRequest = await downloadRequestRepository.FindAsync(id);
            if (downloadRequest == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            mapper.Map(downloadRequestResource, downloadRequest);
            await unitOfWork.CommitAsync();

            return CreatedAtAction(
                nameof(UpdateDownloadRequest),
                new { id },
                mapper.Map<DownloadRequest, DownloadRequestResource>(downloadRequest));
        }

        /// <summary>
        /// Deletes a download request.
        /// </summary>
        /// <param name="id">Download request id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(long id)
        {
            var downloadRequest = await downloadRequestRepository.FindAsync(id);
            if (downloadRequest == null)
            {
                return NotFound();
            }

            downloadRequestRepository.Remove(downloadRequest);
            await unitOfWork.CommitAsync();

            return NoContent();
        }

        /// <summary>
        /// Gets all download requests.
        /// </summary>
        [HttpGet]
        [Produces(ApplicationJson)]
        [ProducesResponseType(typeof(QueryResultResource<DownloadRequestResource>), 200)]
        public async Task<IActionResult> GetDownloadRequests(DownloadRequestQueryResource query)
        {
            var downloadRequests = await downloadRequestRepository.FindAllAsync(
                mapper.Map<DownloadRequestQueryResource, DownloadRequestQuery>(query));

            return Ok(mapper.Map<QueryResult<DownloadRequest>, QueryResultResource<DownloadRequestResource>>(downloadRequests));
        }
        #endregion

        #region Private
        private readonly IDownloadRequestRepository downloadRequestRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        #endregion
    }
}