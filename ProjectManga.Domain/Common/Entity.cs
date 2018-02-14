namespace ProjectManga.Domain.Common
{
    using System;

    /// <summary>
    /// Represents base class for entities.
    /// A new entity shall inherith from this class
    /// in order to be processed correctly.
    /// </summary>
    public abstract class Entity<TKey> : IEntity<TKey>
        where TKey : class, new()
    {
        #region Constructors
        /// <summary>
        /// Constructs the entity with a key.
        /// </summary>
        /// <param name="key"></param>
        protected Entity(TKey key)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Constructs the entity as transient with
        /// default key.
        /// </summary>
        protected Entity()
            : this(new TKey())
        {
        }
        #endregion

        #region Public
        public TKey Key { get; }

        public bool IsTransient => Key.Equals(new TKey());
        #endregion
    }
}