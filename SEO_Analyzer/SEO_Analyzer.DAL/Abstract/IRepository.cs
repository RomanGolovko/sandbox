using System.Collections.Generic;

namespace SEO_Analyzer.DAL.Abstract
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get all data from database / Получает все данные из базы данных
        /// </summary>
        /// <returns>All data / Все данные</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get current data from database / Плучает актуальные данные из базы данных
        /// </summary>
        /// <param name="id">Data id / Id данных</param>
        /// <returns>Current data / Актуальные данные</returns>
        T Get(int id);

        /// <summary>
        /// Add data to database / Добавляет данные в базу данных
        /// </summary>
        /// <param name="item">Added data / Добавляемые данные</param>
        void Create(T item);

        /// <summary>
        /// Edit data / Редактирует результат
        /// </summary>
        /// <param name="item">Edited data / Редактируемые данные</param>
        void Update(T item);

        /// <summary>
        /// Remove data from database / Удаляет данные из базы данных
        /// </summary>
        /// <param name="id">Removed data id / Id удаляемых данных</param>
        void Delete(int id);
    }
}
