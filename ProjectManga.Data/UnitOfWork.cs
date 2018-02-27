namespace ProjectManga.Data
{
    using System;
    using System.Threading.Tasks;
    using Domain;

    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ProjectMangaDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        private readonly ProjectMangaDbContext context;
    }
}