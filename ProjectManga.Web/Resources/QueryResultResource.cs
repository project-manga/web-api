namespace ProjectManga.Web.Resources
{
    using System.Collections.Generic;

    public class QueryResultResource<T>
    {
        public List<T> Items { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SortedBy { get; set; }
        public bool SortAsc { get; set; }        
    }
}