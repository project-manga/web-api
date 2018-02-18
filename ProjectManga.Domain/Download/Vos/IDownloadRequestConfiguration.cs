namespace ProjectManga.Domain.Download.Vos
{
    public interface IDownloadRequestConfiguration
    {
        /// <summary>
        /// Gets chapters range.
        /// </summary>
        Range ChaptersRange { get; }

        /// <summary>
        /// Gets parts range.
        /// </summary>
        Range PartsRange { get; }

        /// <summary>
        /// Gets pages range.
        /// </summary>
        Range PagesRange { get; }
    }
}