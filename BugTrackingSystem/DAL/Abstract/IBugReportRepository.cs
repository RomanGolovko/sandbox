using System.Collections.Generic;
using DataLayer.Entities;

namespace DataLayer.Abstract
{
    public interface IBugReportRepository
    {
        /// <summary>
        /// Get all bug reports from database / Получает все bug reports из базы данных
        /// </summary>
        /// <returns>All bug reports / все bug reports</returns>
        IEnumerable<BugReport> GetAllReports();

        /// <summary>
        /// Get current bug report by id / Получает текущий bug report по id
        /// </summary>
        /// <param name="id">Bug report id</param>
        /// <returns>Current bug report / Текущий bug report</returns>
        BugReport GetCurrentReport(int id);

        /// <summary>
        /// Insert bug report to database / Добавляет bug report в базу данных
        /// </summary>
        /// <param name="bugReport">Bug report</param>
        void CreateReport(BugReport bugReport);

        /// <summary>
        /// Edit bug report / Редактирует bug report
        /// </summary>
        /// <param name="bugReport">Bug report</param>
        void UpdateReport(BugReport bugReport);

        /// <summary>
        /// Remove bug report from database / Удаляет bug report из базы данных
        /// </summary>
        /// <param name="id">Bug reports id</param>
        /// <returns>Deleted bug report / Удаленный bug report</returns>
        BugReport DeleteReport(int id);
    }
}
