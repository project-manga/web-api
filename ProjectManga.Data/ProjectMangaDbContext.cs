namespace ProjectManga.Data
{
    using Microsoft.EntityFrameworkCore;
    using ProjectManga.Domain.Download.Models;

    public class ProjectMangaDbContext : DbContext
    {
        public ProjectMangaDbContext(DbContextOptions<ProjectMangaDbContext> options)
            : base(options)
        {
        }


        public DbSet<DownloadRequest> DownloadRequests { get; set; }
    }
}