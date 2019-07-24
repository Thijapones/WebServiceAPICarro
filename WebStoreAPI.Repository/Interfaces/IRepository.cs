using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;
using WebStoreAPI.Domain.Abstract;

namespace WebStoreAPI.Repository.Interfaces
{
    public interface IRepository<T>
    {
        T FindByKey(Guid key);

        T FindByString(string text);

        List<T> GetList();

        void Add(T obj);
    }
}
