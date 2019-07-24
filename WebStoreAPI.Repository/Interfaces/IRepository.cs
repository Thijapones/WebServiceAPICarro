using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreAPI.Repository.Interfaces
{
    public interface IRepository<T>
    {
        bool Add(T obj);
        List<T> GetList();
    }
}
