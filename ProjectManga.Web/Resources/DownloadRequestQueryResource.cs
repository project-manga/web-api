namespace ProjectManga.Web.Resources
{
    public class DownloadRequestQueryResource : QueryResource
    {
        public int? SourceId { get; set; }
        public string Text { get; set; }
    }
}