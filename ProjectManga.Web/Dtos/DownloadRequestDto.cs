namespace ProjectManga.Web.Dtos
{
    using ProjectManga.Domain.Download.Vos;
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
        public DownloadSource DownloadSource { get; set; }

        /// <summary>
        /// Gets or sets the download configuration.
        /// </summary>
        /// <returns></returns>
        public string Request { get; set;}
    }
}