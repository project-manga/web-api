namespace ProjectManga.Domain
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;
    using Vos;

    /// <summary>
    /// Download request model repository
    /// </summary>
    public interface IDownloadRequestRepository
    {
        /// <summary>
        /// Adds a new download request.
        /// </summary>
        /// <param name="downloadRequest"></param>
        void Add(DownloadRequest downloadRequest);

        /// <summary>
        /// Finds a download request by id.
        /// </summary>
        /// <param name="id">Download request id</param>
        /// <returns></returns>
        Task<DownloadRequest> FindAsync(long id);

        /// <summary>
        /// Finds all download requests.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<DownloadRequest>> FindAllAsync();

        /// <summary>
        /// Searches for download requests.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<QueryResult<DownloadRequest>> FindAllAsync(DownloadRequestQuery filter);
    }
}
