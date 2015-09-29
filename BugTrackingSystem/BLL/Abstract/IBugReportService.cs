using System.Collections.Generic;
using BusinessLayer.DTO;

namespace BusinessLayer.Abstract
{
    public interface IBugReportService
    {
        /// <summary>
        /// Get all bug reports / Получает все bug reports
        /// </summary>
        /// <returns>Bug reports</returns>
        IEnumerable<BugReportDTO> GetAllReports();

        /// <summary>
        /// Get all current authors or reports assigned to current developer /
        /// Получает все bug reports конкретного автора или назначенны для конкретного разработчика
        /// </summary>
        /// <param name="searchedName">Developer(author) name / Имя разработчика(автора)</param>
        /// <returns>Bug reports</returns>
        IEnumerable<BugReportDTO> GetSearchedReports(string searchedName);

        /// <summary>
        /// Get current bug report by id / Получает текущий bug report по id
        /// </summary>
        /// <param name="id">Bug report id</param>
        /// <returns>Current bug report / Текущий bug report</returns>
        BugReportDTO GetCurrentReport(int? id);

        /// <summary>
        /// Add or edit report / Добавляет или редактирует bug report
        /// </summary>
        /// <param name="bugReport">Bug report</param>
        void Upsert(BugReportDTO bugReport);

        /// <summary>
        /// Delete bug report from database / Удаляет bug report из базы данных
        /// </summary>
        /// <param name="id">Bug reports id</param>
        /// <returns>Deleted bug report / Удаленный bug report</returns>
        BugReportDTO RemoveReport(int? id);
    }
}
