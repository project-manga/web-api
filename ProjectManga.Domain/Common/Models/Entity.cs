namespace ProjectManga.Domain.Common
{
    using System;

    /// <summary>
    /// Represents base class for entities.
    /// A new entity shall inherith from this class
    /// in order to be processed correctly.
    /// </summary>
    public abstract class Entity<TId> : IEntity<TId>
        where TId : class
    {
        #region Constructors
        /// <summary>
        /// Constructs the entity with a key.
        /// </summary>
        /// <param name="key"></param>
        protected Entity(TId id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Constructs the entity as transient with
        /// default key.
        /// </summary>
        protected Entity()
            : this(null)
        {
        }
        #endregion

        #region Public
        public TId Id { get; }

        public bool IsTransient => Id == null;
        #endregion
    }
}