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
        public DownloadRequestRepository(ProjectMangaDbContext context)
        {
            this.context = context;
        }
        #endregion

        #region Public
        public void Add(DownloadRequest downloadRequest)
        {
            context.DownloadRequests.Add(downloadRequest);
        }   

        public async Task<DownloadRequest> FindAsync(long id)
        {
            return await context.DownloadRequests.FindAsync(id);
        }
        #endregion

        #region Private
        private readonly ProjectMangaDbContext context;
        #endregion
    }
}
