namespace ProjectManga.Domain.Common.Vos
{
    using System.Collections.Generic;
    using System.Linq;

    public class QueryResult<T>
    {
        public long Total { get; set; }
        public IEnumerable<T> Items { get; set; }
        public long Count => Items.LongCount();
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}