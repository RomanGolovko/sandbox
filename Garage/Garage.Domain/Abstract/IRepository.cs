using System.Linq;

namespace Garage.Domain.Abstract
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll { get; }
        void Save(T item);
        T Delete(int id);
    }
}
