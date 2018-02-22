namespace ProjectManga.Web.Resources
{
    public class CreateDownloadRequestResource
    {        
        public long Id { get; set; }
        
        public int? FromChapter { get; }

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
    }
}