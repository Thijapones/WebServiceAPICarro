using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Business.Interfaces
{
    public interface IProdutoBusiness
    {
        bool Add(Produto produto);

        List<Produto> GetList();
    }
}
