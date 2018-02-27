namespace ProjectManga.Domain
{
    using System;

    /// <summary>
    /// Domain entity interface.
    /// </summary>
    /// <typeparam name="TId">Entity id type</typeparam>
    public interface IEntity<TId>
    {
        /// <summary>
        /// Gets entity id.
        /// </summary>
        /// <returns></returns>
        TId Id { get; }

        DateTime CreationDateTime { get; set; }

        DateTime ModificationDateTime { get; set; }

        DateTime RowVersion { get; set; }
    }
}