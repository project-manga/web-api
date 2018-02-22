namespace ProjectManga.Domain
{
    using System.Threading.Tasks;

    /// <summary>
    /// Manages work state.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commits state.
        /// </summary>
        /// <returns></returns>
         Task CommitAsync();
    }
}