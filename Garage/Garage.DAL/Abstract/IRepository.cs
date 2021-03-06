﻿using System.Collections.Generic;

namespace Garage.DAL.Abstract
{
    public interface IRepository<T> where T : class
    {
        T GetCurrent(int id);
        IEnumerable<T> GetAll();
        void Save(T item);
        T Delete(int id);
    }
}
