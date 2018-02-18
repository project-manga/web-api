namespace ProjectManga.Domain.Download.Vos
{
    public sealed class GoodMangaDownloadRequestConfiguration : DownloadRequestConfiguration<GoodMangaDownloadRequestConfiguration>
    {
        public GoodMangaDownloadRequestConfiguration(
            string sid,
            Range chaptersRange,
            Range partsRange,
            Range pagesRange)
            : base(chaptersRange, partsRange, pagesRange)
        {
            this.sid = sid;
        }

        protected override bool DeepEquals(GoodMangaDownloadRequestConfiguration other)
        {
            return sid == other.sid;
        }

        private string sid;
    }
}