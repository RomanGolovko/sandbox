using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.DTO;
using Cross_Cutting.Security;
using DataLayer.Abstract;
using DataLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class BugReportService : IBugReportService
    {
        IBugReportRepository repository { get; set; }
        public BugReportService(IBugReportRepository repo)
        {
            repository = repo;
        }

        public IEnumerable<BugReportDTO> GetAllReports()
        {
            // using automapper for the projection of one collection to another /
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<BugReport, BugReportDTO>();
            var reports = Mapper.Map<IEnumerable<BugReport>, List<BugReportDTO>>(repository.GetAllReports());

            return reports;
        }

        public IEnumerable<BugReportDTO> GetSearchedReports(string searchedName)
        {
            // using automapper for the projection of one collection to another /
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<BugReport, BugReportDTO>();
            var reports = Mapper.Map<IEnumerable<BugReport>, List<BugReportDTO>>(repository.GetAllReports());

            if (string.IsNullOrEmpty(searchedName))
            {
                return reports;
            }
            else
            {
                List<BugReportDTO> reportList = new List<BugReportDTO>();
                foreach (var item in reports.Where(r => r.AssignedTo.ToLower() == searchedName.Trim().ToLower() ||
                                                   r.Author.ToLower() == searchedName.Trim().ToLower()))
                {
                    reportList.Add(item);
                }

                // validation / валидация
                if (reportList.Count() == 0)
                {
                    throw new ValidationException(
                        string.Format("There is no bug reports assigned to, or added by {0}", searchedName), "");
                }

                return reportList;
            }
        }

        public BugReportDTO GetCurrentReport(int? id)
        {
            BugReport report;

            // validation / валидация
            if (id == null)
            {
                //throw new ValidationException("Bug report id not set", "");
                report = new BugReport();
            }
            else
            {
                report = repository.GetCurrentReport(id.Value);
            }


            //// validation / валидация
            //if (report == null)
            //{
            //    throw new ValidationException("Bug report not found", "");
            //}

            // using automapper for the projection of one collection to another /
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<BugReport, BugReportDTO>();
            return Mapper.Map<BugReport, BugReportDTO>(report);
        }

        public void Upsert(BugReportDTO bugReport)
        {
            if (bugReport.Id == 0)
            {
                // using automapper for the projection of one collection to another /
                // применяем автомаппер для проекции одной коллекции на другую
                Mapper.CreateMap<BugReportDTO, BugReport>();
                var report = Mapper.Map<BugReportDTO, BugReport>(bugReport);
                report.FoundIn = DateTime.Now;
                repository.CreateReport(report);
            }
            else
            {
                BugReport report = new BugReport
                {
                    Id = bugReport.Id.Value,
                    Summary = bugReport.Summary,
                    Project = bugReport.Project,
                    Component = bugReport.Component,
                    Version = bugReport.Version,
                    Severity = bugReport.Severity,
                    Priority = bugReport.Priority,
                    Status = bugReport.Status,
                    Author = bugReport.Author,
                    AssignedTo = bugReport.AssignedTo,
                    FoundIn = DateTime.Now,
                    Environment = bugReport.Environment,
                    ReproduceSteps = bugReport.ReproduceSteps,
                    ActualResult = bugReport.ActualResult,
                    ExpectedResult = bugReport.ExpectedResult,
                    Attachment = bugReport.Attachment
                };

                repository.UpdateReport(report);
            }
        }

        public BugReportDTO RemoveReport(int? id)
        {
            // validation / валидация
            if (id == null)
            {
                throw new ValidationException("Bug report id not set", "");
            }

            // using automapper for the projection of one collection to another /
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<BugReport, BugReportDTO>();
            return Mapper.Map<BugReport, BugReportDTO>(repository.DeleteReport(id.Value));
        }
    }
}
