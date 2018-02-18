namespace ProjectManga.Web.Dtos
{
    using System;

    /// <summary>
    /// Represents scheduled download dto.
    /// </summary>
    public class DownloadRequestDto
    {        
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        /// <returns></returns>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets download source.
        /// </summary>
        /// <returns></returns>
        public DownloadSourceEnum DownloadSource { get; set; }

        /// <summary>
        /// Gets or sets the download configuration.
        /// </summary>
        /// <returns></returns>
        public string Request { get; set;}
    }
}