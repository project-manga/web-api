namespace ProjectManga.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ValueGeneration;
    using ProjectManga.Domain.Common;
    using ProjectManga.Domain.Download.Models;

    public class ProjectMangaDbContext : DbContext
    {
        public ProjectMangaDbContext(DbContextOptions<ProjectMangaDbContext> options)
            : base(options)
        {
        }


        public DbSet<DownloadRequest> DownloadRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.DefaultBehavior<DownloadRequest, long>();
        }
    }
}