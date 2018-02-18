namespace ProjectManga.Web.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using ProjectManga.Web.Dtos;
    using ProjectManga.Web.Filters;
    using ProjectManga.Web.Services;
    using static HttpConstants;

    /// <summary>
    /// Exposes web api for scheduled downloads.
    /// </summary>
    [Route("/[controller]")]
    public class DownloadRequestsController
    {
        #region Constructors
        /// <summary>
        /// Creates the controller.
        /// </summary>
        /// <param name="downloadRequestService">Download request service</param>
        public DownloadRequestsController(
            IDownloadRequestService downloadRequestService)
        {
            this.downloadRequestService = downloadRequestService ?? throw new ArgumentNullException(nameof(downloadRequestService));
        }
        #endregion

        #region Public
        /// <summary>
        /// Creates a new download request.
        /// </summary>
        /// <param name="downloadRequest">Download request</param>
        [Route("/")]
        [HttpPost]
        [Consumes(ApplicationJson)]
        public void CreateDownloadRequest(
            [FromBody] DownloadRequestDto downloadRequest)
        {
            downloadRequestService.CreateDownloadRequest(downloadRequest);
        }
        #endregion

        #region Private
        private readonly IDownloadRequestService downloadRequestService;
        #endregion
    }
}