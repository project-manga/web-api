namespace ProjectManga.Web.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using ProjectManga.Domain.Download;
    using ProjectManga.Web.Filters;
    using static HttpConstants;

    /// <summary>
    /// Exposes web api for scheduled downloads.
    /// </summary>
    [Route("/download-requests")]
    public class DownloadRequestsController
    {
        #region Constructors
        /// <summary>
        /// Creates the controller.
        /// </summary>
        /// <param name="downloadRequestRepository">Download request repository</param>
        public DownloadRequestsController(
            IDownloadRequestRepository downloadRequestRepository)
        {
            this.downloadRequestRepository = downloadRequestRepository ?? throw new ArgumentNullException(nameof(downloadRequestRepository));
        }
        #endregion

        #region Public
        /// <summary>
        /// Creates a new download request.
        /// </summary>
        /// <param name="downloadRequest">Download request</param>
        [HttpPost]
        [Consumes(ApplicationJson)]
        public void CreateDownloadRequest(
            [FromBody] object downloadRequest)
        {
        }

        /// <summary>
        /// Gets a download request.
        /// </summary>
        /// <param name="id">Download request id</param>
        [HttpGet("{id}")]
        [Consumes(ApplicationJson)]
        public void GetDownloadRequest(int id)
        {
        }
        #endregion

        #region Private
        private readonly IDownloadRequestRepository downloadRequestRepository;
        #endregion
    }
}