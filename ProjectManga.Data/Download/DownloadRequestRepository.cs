namespace ProjectManga.Data.Download
{
    using System;
    using System.Threading.Tasks;
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
        public DownloadRequestRepository()
        {
        }
        #endregion

        #region Public
        public void Add(DownloadRequest downloadRequest)
        {
        }

        public Task<DownloadRequest> FindAsync(long id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Private
        #endregion
    }
}
