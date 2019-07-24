using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Services.Interfaces
{
    public interface IProdutoServices
    {
        Produto FindByKey(Guid key);
        List<Produto> List();

        List<Produto> Insert(Produto produto);
    }
}
