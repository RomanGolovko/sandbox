using System.Data.Entity;
using DataLayer.Entities;

namespace DataLayer.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<BugReport> BugReports { get; set; }
    }
}
