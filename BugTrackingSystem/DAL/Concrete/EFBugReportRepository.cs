using System.Collections.Generic;
using DAL.Abstract;
using DAL.Entities;

namespace DAL.Concrete
{
    public class EFBugReportRepository : IBugReportRepository
    {
        EFDbContext db = new EFDbContext();

        public IEnumerable<BugReport> BugReports
        {
            get{ return db.BugReports; }
        }

        public void AddBugReport(BugReport bugReport)
        {
            db.BugReports.Add(bugReport);
        }

        public BugReport DeleteBugReport(int id)
        {
            var dbEntry = db.BugReports.Find(id);
            if (dbEntry != null)
            {
                db.BugReports.Remove(dbEntry);
                db.SaveChanges();
            }

            return dbEntry;
        }
    }
}
