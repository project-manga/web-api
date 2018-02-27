namespace ProjectManga.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents base class for entities.
    /// A new entity shall inherith from this class
    /// in order to be processed correctly.
    /// </summary>
    public abstract class Entity<TId> : IEntity<TId>
    {
        #region Constructors
        /// <summary>
        /// Constructs the entity with a key.
        /// </summary>
        /// <param name="key"></param>
        protected Entity(TId id)
        {
            Id = id;
        }

        /// <summary>
        /// Constructs the entity as transient with
        /// default key.
        /// </summary>
        protected Entity()
            : this(default(TId))
        {
        }
        #endregion

        #region Public
        [Key]
        public TId Id { get; set; }

        public DateTime CreationDateTime { get; set; }

        public DateTime ModificationDateTime { get; set; }

        public DateTime RowVersion { get; set; }
        #endregion
    }
}