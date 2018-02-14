namespace ProjectManga.Domain.Common
{
    /// <summary>
    /// Domain entity interface.
    /// </summary>
    /// <typeparam name="TKey">Entity key type</typeparam>
    public interface IEntity<TKey>
        where TKey : class
    {
        /// <summary>
        /// Gets entity key.
        /// </summary>
        /// <returns></returns>
         TKey Key { get; }

        /// <summary>
        /// Gets if the entity is transient.
        /// </summary>
        /// <returns>
        /// Returns true if the entity is transient, otherwise false.
        /// </returns>
         bool IsTransient { get; }
    }
}