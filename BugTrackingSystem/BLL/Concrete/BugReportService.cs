using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Abstract;
using BLL.DTO;
using BLL.Infrastructure;
using DAL.Abstract;
using DAL.Entities;

namespace BLL.Concrete
{
    public class BugReportService : IBugReportService
    {
        IBugReportRepository db { get; set; }
        public BugReportService(IBugReportRepository repo)
        {
            db = repo;
        }

        public IEnumerable<BugReportDTO> GetBugReports()
        {
            // using automapper for the projection of one collection to another /
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<BugReport, BugReportDTO>();
            var reports = Mapper.Map<IEnumerable<BugReport>, List<BugReportDTO>>(db.BugReports);

            return reports;
        }

        public IEnumerable<BugReportDTO> GetCurrentBugReports(string searchedName)
        {
            IEnumerable<BugReportDTO> reports;

            if (string.IsNullOrEmpty(searchedName))
            {
                reports = GetBugReports();
            }
            else
            {
                // using automapper for the projection of one collection to another /
                // применяем автомаппер для проекции одной коллекции на другую
                Mapper.CreateMap<BugReport, BugReportDTO>();
                reports = Mapper.Map<IEnumerable<BugReport>, List<BugReportDTO>>(
                    db.BugReports.Where(r => r.assignedTo.ToLower() == searchedName.ToLower() ||
                                             r.author.ToLower() == searchedName.ToLower()));        // LINQ

                // validation / валидация
                if (reports.Count() == 0)
                {
                    throw new ValidationException(
                        string.Format("There is no bug reports assigned to, or added by {0}", searchedName), "");
                }
            }

            return reports;
        }

        public void AddBugReport(BugReportDTO bugReport)
        {
            BugReport report = new BugReport
            {
                summary = bugReport.summary,
                project = bugReport.project,
                component = bugReport.component,
                version = bugReport.version,
                severity = bugReport.severity,
                priority = bugReport.priority,
                status = bugReport.status,
                author = bugReport.author,
                assignedTo = bugReport.assignedTo,
                foundIn = bugReport.foundIn,
                environment = bugReport.environment,
                reproduceSteps = bugReport.reproduceSteps,
                actualResult = bugReport.actualResult,
                expectedResult = bugReport.expectedResult,
                attachment = bugReport.attachment
            };

            db.AddBugReport(report);
        }

        public BugReportDTO DeleteBugReport(int? id)
        {
            // validation / валидация
            if (id == null)
            {
                throw new ValidationException("Bug report id not set", "");
            }

            // using automapper for the projection of one collection to another /
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<BugReport, BugReportDTO>();
            return Mapper.Map<BugReport, BugReportDTO>(db.DeleteBugReport(id.Value));
        }
    }
}
