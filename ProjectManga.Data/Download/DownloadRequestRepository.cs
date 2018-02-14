namespace ProjectManga.Data.Download
{
    using System;
    using ProjectManga.Domain;
    using ProjectManga.Domain.Download;
    using ProjectManga.Domain.Download.Models;

    /// <summary>
    /// Mediates between the download request domain and its data mapping using 
    /// a collection-like interface for accessing download requests.
    /// </summary>
    public class DownloadRequestRepository : Repository, IDownloadRequestRepository
    {
        #region Constructors
        /// <summary>
        /// Constructs the repository.
        /// </summary>
        public DownloadRequestRepository(
            IDownloadRequestGateway downloadRequestGateway)
        {
            this.downloadRequestGateway = downloadRequestGateway ?? throw new ArgumentNullException(nameof(downloadRequestGateway));
        }
        #endregion

        #region Public
#pragma warning disable CS1591
        public void Add(DownloadRequest downloadRequest)
        {
            downloadRequestGateway.Insert(null);
        }
#pragma warning disable CS1591
        #endregion

        #region Private
        private readonly IDownloadRequestGateway downloadRequestGateway;
        #endregion
    }
}
