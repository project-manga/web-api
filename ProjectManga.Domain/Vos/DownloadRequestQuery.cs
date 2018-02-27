namespace ProjectManga.Domain.Vos
{
    public class DownloadRequestQuery : Filter
    {
        public int? SourceId { get; set; }
        public string Text { get; set; }
    }
}