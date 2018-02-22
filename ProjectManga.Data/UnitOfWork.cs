namespace ProjectManga.Data
{
    using System;
    using System.Threading.Tasks;
    using ProjectManga.Domain;

    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ProjectMangaDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CommitAsync()
        {
            throw new System.NotImplementedException();
        }

        private readonly ProjectMangaDbContext context;
    }
}