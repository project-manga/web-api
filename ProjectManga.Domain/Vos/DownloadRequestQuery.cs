namespace ProjectManga.Domain.Vos
{
    public class DownloadRequestQuery : Filter
    {
        public string Source { get; set; }
        public string Text { get; set; }
    }
}