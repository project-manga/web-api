namespace ProjectManga.Data
{
    using ProjectManga.Domain;
    using System;

    /// <summary>
    /// Mediates between the domain and data mapping layers using 
    /// a collection-like interface for accessing domain objects
    /// </summary>
    public abstract class Repository
    {
        #region Constructors
        /// <summary>
        /// Constructs the repository.
        /// </summary>
        /// <param name="uow">Unit of work</param>
        protected Repository(IUnitOfWork uow)
        {
            Uow = uow ?? throw new ArgumentNullException(paramName: nameof(uow));
        } 
        #endregion

        #region Protected
        /// <summary>
        /// Gets the unit of work.
        /// </summary>
        protected IUnitOfWork Uow { get; } 
        #endregion
    }
}
