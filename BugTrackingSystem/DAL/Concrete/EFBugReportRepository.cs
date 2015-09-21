using System;
using System.Collections.Generic;
using System.Data.Entity;
using DataLayer.Abstract;
using DataLayer.Entities;

namespace DataLayer.Concrete
{
    public class EFBugReportRepository : IBugReportRepository
    {
        EFDbContext db = new EFDbContext();

        public IEnumerable<BugReport> GetAllReports()
        {
            return db.BugReports;
        }

        public BugReport GetCurrentReport(int id)
        {
            return db.BugReports.Find(id);
        }

        public void CreateReport(BugReport bugReport)
        {
            db.BugReports.Add(bugReport);
            db.SaveChanges();
        }

        public void UpdateReport(BugReport bugReport)
        {
            db.Entry(bugReport).State = EntityState.Modified;
            db.SaveChanges();
        }

        public BugReport DeleteReport(int id)
        {
            var report = db.BugReports.Find(id);
            if (report != null)
            {
                db.BugReports.Remove(report);
                db.SaveChanges();
            }
            else
            {
                throw new ApplicationException("Can't delete report with id: " + id);
            }

            return report;
        }
    }
}
