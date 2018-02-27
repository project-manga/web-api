namespace ProjectManga.Web.Resources
{
    public class IdNameExtendedResource<TKey>
    {
        public TKey Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}