namespace ProjectManga.Data.Download
{
    /// <summary>
    /// Represents download request gateway.
    /// </summary>
    public interface IDownloadRequestGateway
    {
        /// <summary>
        /// Inserts a new download request.
        /// </summary>
        /// <param name="row">Download request</param>
         void Insert(DownloadRequestRow row);
    }
}