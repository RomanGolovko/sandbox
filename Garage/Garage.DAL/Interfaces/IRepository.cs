using System.Collections.Generic;

namespace Garage.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get items from data base
        /// </summary>
        /// <returns>Items collection</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get current item via id
        /// </summary>
        /// <param name="id">Item id</param>
        /// <returns>Item</returns>
        T Get(int id);

        /// <summary>
        /// Add item to data base
        /// </summary>
        /// <param name="item">item</param>
        void Create(T item);

        /// <summary>
        /// Edit item
        /// </summary>
        /// <param name="item">Item</param>
        void Update(T item);

        /// <summary>
        /// Remove item from data base
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
