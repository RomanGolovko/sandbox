using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Abstract
{
    public interface IBugReportRepository
    {
        /// <summary>
        /// Get all bug reports from database / Получает все bug reports из базы данных
        /// </summary>
        IEnumerable<BugReport> BugReports { get; }

        /// <summary>
        /// Add bug report to database / Добавляет bug report в базу данных
        /// </summary>
        /// <param name="bugReport">Bug report</param>
        void AddBugReport(BugReport bugReport);

        /// <summary>
        /// Delete bug report from database / Удаляет bug report из базы данных
        /// </summary>
        /// <param name="id">Bug reports id</param>
        /// <returns>Deleted bug report / Удаленный bug report</returns>
        BugReport DeleteBugReport(int id);
    }
}
