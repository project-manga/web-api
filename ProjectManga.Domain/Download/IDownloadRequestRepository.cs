namespace ProjectManga.Domain.Download
{
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
    }
}
