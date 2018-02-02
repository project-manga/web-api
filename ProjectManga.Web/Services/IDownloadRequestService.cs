namespace ProjectManga.Web.Services
{
    using ProjectManga.Web.Dtos;

    /// <summary>
    /// Application service for download requests.
    /// </summary>
    public interface IDownloadRequestService
    {
        /// <summary>
        /// Creates a new download request.
        /// </summary>
        /// <param name="downloadRequest">Creating download request</param>
        /// <returns>Returns the created download request id</returns>
        long CreateDownloadRequest(DownloadRequestDto downloadRequest);
    }
}
