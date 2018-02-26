namespace ProjectManga.Domain.Common.Vos
{
    public abstract class Filter : IQueryObject
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
    }
}