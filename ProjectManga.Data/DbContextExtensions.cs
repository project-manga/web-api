namespace ProjectManga.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using ProjectManga.Domain.Common;
    using ProjectManga.Domain.Download.Models;

    public static class DbContextExtensions
    {
        public static void DefaultBehavior<T, TKey>(this ModelBuilder modelBuilder)
            where T : class, IEntity<TKey>
        {
            modelBuilder.Entity<T>()
                .Property(dr => dr.CreationDateTime)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("DATETIME()");

            modelBuilder.Entity<T>()
                .Property(dr => dr.ModificationDateTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("DATETIME()");

            modelBuilder.Entity<T>()
                .Property(b => b.RowVersion)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("DATETIME()")
                .IsRowVersion();
        }

    }
}