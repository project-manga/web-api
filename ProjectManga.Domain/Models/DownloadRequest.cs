namespace ProjectManga.Domain.Models
{
    using System.ComponentModel.DataAnnotations;

    public class DownloadRequest : Entity<long>
    {
        /// <summary>
        /// Gets or sets from chapter value.
        /// </summary>
        public int? FromChapter { get; set; }

        /// <summary>
        /// Gets or sets to chapter value.
        /// </summary>
        public int? ToChapter { get; set; }

        /// <summary>
        /// Gets or sets from chapter part value.
        /// </summary>
        public int? FromChapterPart { get; set; }

        /// <summary>
        /// Gets or sets to chapter part value.
        /// </summary>
        public int? ToChapterPart { get; set; }

        /// <summary>
        /// Gets or sets from page value.
        /// </summary>
        public int? FromPage { get; set; }

        /// <summary>
        /// Gets or sets to page value.
        /// </summary>
        public int? ToPage { get; set; }

        /// <summary>
        /// Gets or sets sid value.
        /// </summary>
        /// <returns></returns>
        [StringLength(255)]
        public string Sid { get; set; }
    }
}