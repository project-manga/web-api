namespace ProjectManga.Web.Resources
{
    public abstract class QueryResource
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string SortBy { get; set; }
        public bool? IsSortAscending { get; set; }        
    }
}