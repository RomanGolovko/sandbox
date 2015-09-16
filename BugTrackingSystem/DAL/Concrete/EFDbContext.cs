using System.Data.Entity;
using DAL.Entities;

namespace DAL.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<BugReport> BugReports { get; set; }
    }
}
