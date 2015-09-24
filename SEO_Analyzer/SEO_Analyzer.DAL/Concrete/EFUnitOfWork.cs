using SEO_Analyzer.DAL.Abstract;
using SEO_Analyzer.DAL.Entities;

namespace SEO_Analyzer.DAL.Concrete
{
    public class EFUnitOfWork : IUnitOfWork
    {
        EFDbContext db;
        ResultRepository resultRepository;
        WordRepository wordRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new EFDbContext(connectionString);
        }

        public IRepository<Result> Results
        {
            get
            {
                if (resultRepository == null)
                {
                    resultRepository = new ResultRepository(db);
                }

                return resultRepository;
            }
        }

        public IRepository<Word>Words
        {
            get
            {
                if (wordRepository == null)
                {
                    wordRepository = new WordRepository(db);
                }

                return wordRepository;
            }
        }
    }
}
