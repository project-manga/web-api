namespace ProjectManga.Domain
{
    /// <summary>
    /// Maintains a list of objects affected by a business transaction and 
    /// coordinates the writing out of changes and the resolution of 
    /// concurrency problems.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Marks an object as added to the current unit.
        /// </summary>
        /// <param name="item"></param>
        void Add(object item);

        /// <summary>
        /// Marks an object as removed to the current unit.
        /// </summary>
        /// <param name="item"></param>
        void Remove(object item);

        /// <summary>
        /// Marks an object as updated to the current unit.
        /// </summary>
        /// <param name="item"></param>
        void Update(object item);

        /// <summary>
        /// Commits changes.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rolls back changes.
        /// </summary>
        void Rollback();
    }
}
