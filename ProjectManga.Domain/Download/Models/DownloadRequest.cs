namespace ProjectManga.Domain.Download.Models
{
    using ProjectManga.Domain.Common;
    using ProjectManga.Domain.Download.Vos;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents a download request model entity (aggregate root)
    /// </summary>
    public class DownloadRequest : Entity<DownloadRequestId>
    {
        #region Constructors
        /// <summary>
        /// Creates download request.
        /// </summary>
        /// <param name="id">Download request id</param>
        /// <param name="configuration">Download request configuration</param>
        public DownloadRequest(
            DownloadRequestId id,
            IDownloadRequestConfiguration configuration)
            : base(id)
        {
            Configuration = configuration;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets download request configuration
        /// </summary>
        /// <returns></returns>
        public IDownloadRequestConfiguration Configuration { get; }
        #endregion
    }
}
