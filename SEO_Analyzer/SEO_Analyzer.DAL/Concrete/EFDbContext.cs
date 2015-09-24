using System.Data.Entity;
using SEO_Analyzer.DAL.Entities;

namespace SEO_Analyzer.DAL.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Result> Results { get; set; }
        public DbSet<Word> Words { get; set; }

        public EFDbContext(string connectionString) : base(connectionString)
        { }
    }
}
