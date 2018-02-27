namespace ProjectManga.Web.Resources
{
    using System;

    public class DownloadRequestResource
    {
        /// <summary>
        /// Gets or sets download request resource id.
        /// </summary>
        /// <returns></returns>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets from chapter value.
        /// </summary>
        /// <returns></returns>
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
        /// Gets or sets to sid value.
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// Gets or sets creation date/time
        /// </summary>
        /// <returns></returns>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets modification date/time
        /// </summary>
        /// <returns></returns>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets or sets download request source.
        /// </summary>
        /// <returns></returns>
        public IdNameExtendedResource<int> Source { get; set; }
    }
}