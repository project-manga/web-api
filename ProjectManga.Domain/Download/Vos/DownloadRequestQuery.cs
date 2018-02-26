namespace ProjectManga.Domain.Download.Vos
{
    using Common.Vos;

    public class DownloadRequestQuery : Filter
    {
        public string Source { get; set; }
        public string Text { get; set; }
    }
}