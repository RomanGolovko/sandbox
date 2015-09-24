using SEO_Analyzer.DAL.Entities;

namespace SEO_Analyzer.DAL.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<Result> Results { get; }
        IRepository<Word> Words { get; }
    }
}
