namespace ProjectManga.Web.Services
{
    using ProjectManga.Domain.Download;
    using ProjectManga.Domain.Download.Models;
    using ProjectManga.Domain.Download.Vos;
    using ProjectManga.Web.Dtos;

    /// <summary>
    /// Represents download requests application service implementation
    /// </summary>
    public class DownloadRequestService : IDownloadRequestService
    {
        #region Constructors
        /// <summary>
        /// Creates download request service
        /// </summary>
        /// <param name="downloadRequestRepository">Download request repository</param>
        public DownloadRequestService(
            IDownloadRequestRepository downloadRequestRepository)
        {
            this.downloadRequestRepository = downloadRequestRepository;
        }
        #endregion

        #region Public
#pragma warning disable CS1591
        public void CreateDownloadRequest(DownloadRequestDto downloadRequest)
        {
            //TODO: manage "dynamic" mapping

            var request = new DownloadRequest(
                new DownloadRequestId(0),
                new GoodMangaDownloadRequestConfiguration(
                    "SID",
                    new Range(0, 0),
                    new Range(null, null),
                    new Range(0, 0)
                )
            );

            downloadRequestRepository.Add(request);
        }
#pragma warning disable CS1591
        #endregion

        #region Private
        private readonly IDownloadRequestRepository downloadRequestRepository;
        #endregion
    }
}
