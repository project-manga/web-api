namespace ProjectManga.Data
{
    using ProjectManga.Domain;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation of unit of work
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        #region Constructors
        /// <summary>
        /// Constructs the unit of work.
        /// </summary>
        /// <param name="dataMapperRegistry">Data mappers registry</param>
        public UnitOfWork(IDataMapperRegistry dataMapperRegistry)
        {
            this.dataMapperRegistry = dataMapperRegistry ?? throw new ArgumentNullException(paramName: nameof(dataMapperRegistry));

            adding = new List<object>();
            removing = new List<object>();
            updating = new List<object>();
        } 
        #endregion

        #region Public
#pragma warning disable CS1591
        public void Add(object item)
        {
            if (adding.Contains(item))
            {
                return;
            }

            adding.Add(item);
        }

        public void Remove(object item)
        {
            if (removing.Contains(item))
            {
                return;
            }

            removing.Add(item);
        }

        public void Update(object item)
        {
            if (updating.Contains(item))
            {
                return;
            }

            updating.Add(item);
        }

        public void Commit()
        {
            try
            {
                removing.ForEach(e => dataMapperRegistry.Get(e.GetType()).Delete(e));
                adding.ForEach(e => dataMapperRegistry.Get(e.GetType()).Insert(e));
                updating.ForEach(e => dataMapperRegistry.Get(e.GetType()).Update(e));
            }
            catch
            {
                throw;
            }
            finally
            {
                Clear();
            }
        }

        public void Rollback()
        {
            Clear();
        }
#pragma warning disable CS1591
        #endregion

        #region Private
        private readonly IDataMapperRegistry dataMapperRegistry;
        private readonly List<object> adding;
        private readonly List<object> removing;
        private readonly List<object> updating;

        private void Clear()
        {
            removing.Clear();
            adding.Clear();
            updating.Clear();
        }
        #endregion
    }
}
