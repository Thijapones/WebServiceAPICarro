using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Business.Interfaces
{
    public interface IProdutoBusiness
    {
        Produto FindByKey(Guid key);

        bool Add(Produto produto);

        List<Produto> GetList();
    }
}
