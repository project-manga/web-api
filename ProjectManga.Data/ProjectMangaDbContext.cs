namespace ProjectManga.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ValueGeneration;
    using Extensions;
    using Domain;
    using Domain.Models;

    public class ProjectMangaDbContext : DbContext
    {
        public ProjectMangaDbContext(DbContextOptions<ProjectMangaDbContext> options)
            : base(options)
        {
        }


        public DbSet<DownloadRequest> DownloadRequests { get; set; }
        public DbSet<Source> Sources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.DefaultBehavior<Source, int>();

            modelBuilder.DefaultBehavior<DownloadRequest, long>();

        }
    }
}