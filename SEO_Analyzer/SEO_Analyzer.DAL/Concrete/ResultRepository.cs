using System.Collections.Generic;
using System.Data.Entity;
using SEO_Analyzer.Cross_Cutting.Security;
using SEO_Analyzer.DAL.Abstract;
using SEO_Analyzer.DAL.Entities;

namespace SEO_Analyzer.DAL.Concrete
{
    class ResultRepository : IRepository<Result>
    {
        EFDbContext db;
        public ResultRepository(EFDbContext context)
        {
            db = context;
        }

        public IEnumerable<Result> GetAll()
        {
            return db.Results;
        }

        public Result Get(int id)
        {
            return db.Results.Find(id);
        }

        public void Create(Result result)
        {
            db.Results.Add(result);
            db.SaveChanges();
        }

        public void Update(Result result)
        {
            db.Entry(result).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var deletedResult = db.Results.Find(id);
            if (deletedResult != null)
            {
                db.Results.Remove(deletedResult);
                db.SaveChanges();
            }
            else
            {
                throw new ValidationException(string.Format("Can't delete result with id: " + id), "");
            }
        }
    }
}
