namespace ProjectManga.Data
{
    /// <summary>
    /// A layer of Mappers (473) that moves data between objects and 
    /// a database while keeping them independent of each other and 
    /// the mapper itself.
    /// </summary>
    public interface IDataMapper
    {
        /// <summary>
        /// Inserts the entity.
        /// </summary>
        /// <param name="insertingEntity">Inserting entity</param>
        /// <returns>Returns the inserted entity key.</returns>
        object Insert(object insertingEntity);

        /// <summary>
        /// Updates the entity.
        /// </summary>
        /// <param name="updatingEntity">Updating entity</param>
        void Update(object updatingEntity);

        /// <summary>
        /// Deletes the entity.
        /// </summary>
        /// <param name="deletingEntity">Deleting entity</param>
        /// <returns>
        /// Returns true if the delete was successful, othwerwise false.
        /// </returns>
        bool Delete(object deletingEntity);
    }
}
