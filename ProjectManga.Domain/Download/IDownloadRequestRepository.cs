namespace ProjectManga.Domain.Download
{
    using System.Threading.Tasks;
    using ProjectManga.Domain.Download.Models;

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
    }
}
