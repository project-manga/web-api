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

            return Ok(mapper.Map<DownloadRequest, DownloadRequestResource>(downloadRequest));
        }

        /// <summary>
        /// Gets a download request.
        /// </summary>
        /// <param name="id">Download request id</param>
        [HttpGet("{id}")]
        [Consumes(ApplicationJson)]
        public async Task<IActionResult> GetDownloadRequest(int id)
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
        [HttpPut("{id}")]
        [Consumes(ApplicationJson)]
        public async Task<IActionResult> UpdateDownloadRequest(
            int id,
            [FromBody] SaveDownloadRequestResource downloadRequestResource)
        {
            var downloadRequest = await downloadRequestRepository.FindAsync(id);
            if (downloadRequest == null)
            {
                return NotFound();
            }

            mapper.Map(downloadRequestResource, downloadRequest);
            await unitOfWork.CommitAsync();

            return Ok(mapper.Map<DownloadRequest, DownloadRequestResource>(downloadRequest));
        }

        /// <summary>
        /// Gets all download requests.
        /// </summary>
        [HttpGet]
        [Consumes(ApplicationJson)]
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