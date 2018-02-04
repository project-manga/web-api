namespace ProjectManga.Domain.Download
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents a download request model entity
    /// </summary>
    public class DownloadRequest
    {
        #region Constructors
        /// <summary>
        /// Creates download request.
        /// </summary>
        /// <param name="id">Download request id</param>
        /// <param name="source">Download request source</param>
        /// <param name="request">Download request content</param>
        /// <param name="chaptersRange">Request chapters range</param>
        /// <param name="partsRange">Request chapters parts range</param>
        /// <param name="pagesRange">Request pages range</param>
        public DownloadRequest(
            long id,
            DownloadSource source,
            string request,
            Range chaptersRange,
            Range partsRange,
            Range pagesRange)
        {
            Id = id;
            Source = source;
            Request = request;
            ChaptersRange = chaptersRange;
            PartsRange = partsRange;
            PagesRange = pagesRange;
        } 
        #endregion

        #region Public
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [Required]
        public long Id { get; }

        /// <summary>
        /// Gets download source.
        /// </summary>
        [Required]
        public DownloadSource Source { get; }

        /// <summary>
        /// Gets or sets Request.
        /// </summary>
        [Required]
        public string Request { get; }

        /// <summary>
        /// Gets or sets chapters range.
        /// </summary>
        [Required]
        public Range ChaptersRange { get; }

        /// <summary>
        /// Gets or sets parts range.
        /// </summary>
        [Required]
        public Range PartsRange { get; }

        /// <summary>
        /// Gets or sets pages range.
        /// </summary>
        [Required]
        public Range PagesRange { get; } 
        #endregion
    }
}
