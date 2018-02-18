namespace ProjectManga.Domain.Common
{
    /// <summary>
    /// Domain entity interface.
    /// </summary>
    /// <typeparam name="TId">Entity id type</typeparam>
    public interface IEntity<TId>
        where TId : class
    {
        /// <summary>
        /// Gets entity id.
        /// </summary>
        /// <returns></returns>
         TId Id { get; }

        /// <summary>
        /// Gets if the entity is transient.
        /// </summary>
        /// <returns>
        /// Returns true if the entity is transient, otherwise false.
        /// </returns>
         bool IsTransient { get; }
    }
}