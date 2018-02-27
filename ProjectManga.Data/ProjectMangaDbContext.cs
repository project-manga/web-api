namespace ProjectManga.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ValueGeneration;
    using Extensions;
    using Domain.Common;
    using Domain.Download.Models;

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