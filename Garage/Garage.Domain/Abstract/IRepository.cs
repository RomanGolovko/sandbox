using System.Collections.Generic;

namespace Garage.Domain.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll { get; }
        void Save(T item);
        T Delete(int id);
    }
}
