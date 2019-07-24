using System;
using System.Collections.Generic;
using System.Linq;
using WebStoreAPI.Domain;
using WebStoreAPI.Domain.Abstract;
using WebStoreAPI.Repository.Interfaces;

namespace WebStoreAPI.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        public static List<T> _list;
        public readonly List<T> _data;
        private static object _syncObj = new object();
        public Repository()
        {
            if (_list == null)
            {
                lock (_syncObj)
                {
                    if (_list == null)
                    {
                        _list = new List<T>();
                    }
                }
            }
        }

        public T FindByKey(Guid key)
        {
            return _data.FirstOrDefault(w => w.Key == key);
        }

        public T FindByString(string text)
        {
            return _data.FirstOrDefault(w => w.Text.Equals(text));
        }

        public void Add(T obj)
        {
            _list.Add(obj);
        }

        public List<T> GetList()
        {
            return _list;
        }

    }
}
