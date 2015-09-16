using System.Collections.Generic;
using BLL.DTO;

namespace BLL.Abstract
{
    public interface IBugReportService
    {
        /// <summary>
        /// Get all bug reports / Получает все bug reports
        /// </summary>
        /// <returns>Bug reports</returns>
        IEnumerable<BugReportDTO> GetBugReports();

        /// <summary>
        /// Get all current authors or reports assigned to current developer /
        /// Получает все bug reports конкретного автора или назначенны для конкретного разработчика
        /// </summary>
        /// <param name="searchedName">Developer(author) name / Имя разработчика(автора)</param>
        /// <returns>Bug reports</returns>
        IEnumerable<BugReportDTO> GetCurrentBugReports(string searchedName);

        /// <summary>
        /// Add bug report to database / Добавляет bug report в базу данных
        /// </summary>
        /// <param name="bugReport">Bug report</param>
        void AddBugReport(BugReportDTO bugReport);

        /// <summary>
        /// Delete bug report from database / Удаляет bug report из базы данных
        /// </summary>
        /// <param name="id">Bug reports id</param>
        /// <returns>Deleted bug report / Удаленный bug report</returns>
        BugReportDTO DeleteBugReport(int? id);
    }
}
