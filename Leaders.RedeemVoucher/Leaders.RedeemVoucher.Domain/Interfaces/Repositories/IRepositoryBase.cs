using System;
using System.Collections.Generic;
using System.Text;

namespace Leaders.RedeemVoucher.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Base repository for CRUD operations
    /// </summary>
    /// <typeparam name="T">The entity Type</typeparam>
    public interface IRepositoryBase<T> where T : class
    {
        /// <summary>
        /// Create new data
        /// </summary>
        /// <param name="obj">Object to be created</param>
        void Create(T obj);
        /// <summary>
        /// Get data by index
        /// </summary>
        /// <param name="id">The index</param>
        /// <returns>The object</returns>
        T GetById(int id);
        /// <summary>
        /// Get the list of all objects
        /// </summary>
        /// <returns>A list of objects</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Update object
        /// </summary>
        /// <param name="obj">The object to be updated</param>
        void Update(T obj);
        /// <summary>
        /// Delete object by index
        /// </summary>
        /// <param name="id">The index to be deleted</param>
        void Delete(int id);
    }
}
