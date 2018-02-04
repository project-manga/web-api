namespace ProjectManga.Data
{
    using System;

    /// <summary>
    /// A well-known object that other objects can use to find data mappers.
    /// </summary>
    public interface IDataMapperRegistry
    {
        /// <summary>
        /// Gets a data mapper used to map <paramref name="entityType"/> entity.
        /// </summary>
        /// <param name="entityType">Entity type whose data mapper you need.</param>
        /// <returns>Returns entity data mappaer</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when does not exist a matching mapper.
        /// </exception>
        IDataMapper Get(Type entityType);
    }
}
