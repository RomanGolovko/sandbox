using System.Collections.Generic;
using System.Data.Entity;
using SEO_Analyzer.Cross_Cutting.Security;
using SEO_Analyzer.DAL.Abstract;
using SEO_Analyzer.DAL.Entities;

namespace SEO_Analyzer.DAL.Concrete
{
    public class WordRepository : IRepository<Word>
    {
        EFDbContext db;
        public WordRepository(EFDbContext context)
        {
            db = context;
        }

        public IEnumerable<Word> GetAll()
        {
            return db.Words;
        }

        public Word Get(int id)
        {
            return db.Words.Find(id);
        }

        public void Create(Word item)
        {
            db.Words.Add(item);
            db.SaveChanges();
        }

        public void Update(Word item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var deletedWord = db.Words.Find(id);
            if (deletedWord != null)
            {
                db.Words.Remove(deletedWord);
                db.SaveChanges();
            }
            else
            {
                throw new ValidationException(string.Format("Can't delete word with id: " + id), "");
            }
        }
    }
}
