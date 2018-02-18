namespace ProjectManga.Domain.Download.Vos
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using ProjectManga.Domain.Common.Vos;
    
    public abstract class DownloadRequestConfiguration<T> : ValueObject<T>, IDownloadRequestConfiguration
        where T : DownloadRequestConfiguration<T>
    {
        /// <summary>
        /// Creates download request configuration.
        /// </summary>
        /// <param name="chaptersRange">Request chapters range</param>
        /// <param name="partsRange">Request chapters parts range</param>
        /// <param name="pagesRange">Request pages range</param>
        public DownloadRequestConfiguration(
            Range chaptersRange,
            Range partsRange,
            Range pagesRange)
        {
            ChaptersRange = chaptersRange;
            PartsRange = partsRange;
            PagesRange = pagesRange;
        }

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

        protected override bool DeepEquals(T other)
        {
            return EqualityComparer<Range>.Default.Equals(ChaptersRange, other.ChaptersRange)
                && EqualityComparer<Range>.Default.Equals(PartsRange, other.PartsRange)
                && EqualityComparer<Range>.Default.Equals(PagesRange, other.PagesRange);
        }
    }
}