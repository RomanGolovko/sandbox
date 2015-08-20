using System.Collections.Generic;

namespace Garage.BLL.Abstract
{
    public interface IService<T> where T : class
    {
        T GetCurrent(int? id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(string str);
        void Save(T item);
        T Delete(int? id);
    }
}
