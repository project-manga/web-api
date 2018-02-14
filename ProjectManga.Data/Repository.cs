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
        protected Repository()
        {
        } 
        #endregion
    }
}
