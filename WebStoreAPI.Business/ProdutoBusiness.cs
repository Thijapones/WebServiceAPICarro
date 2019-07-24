using System;
using System.Collections.Generic;
using WebStoreAPI.Business.Interfaces;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository;

namespace WebStoreAPI.Business
{
    public class ProdutoBusinnes : IProdutoBusiness
    {
        ProdutoRepository _produtorepository;
        public ProdutoBusinnes()
        {
            _produtorepository = new ProdutoRepository();
        }

        public Produto FindByKey(Guid key)
        {
            return _produtorepository.FindByKey(key);
        }

        public Produto FindByString(string marca)
        {
            return _produtorepository.FindByString(marca);
        }

        public bool Add(Produto produto)
        {
            _produtorepository.Add(produto);
            return true;
        }

        public List<Produto> GetList()
        {
            return _produtorepository.GetList();
        }
    }
}
