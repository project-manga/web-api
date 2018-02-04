namespace ProjectManga.Data.Download
{
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
        /// <param name="uow">Unit of work</param>
        public DownloadRequestRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
        #endregion

        #region Public
#pragma warning disable CS1591
        public void Add(DownloadRequest downloadRequest)
        {
            Uow.Add(downloadRequest);
        }
#pragma warning disable CS1591
        #endregion
    }
}
