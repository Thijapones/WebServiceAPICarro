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

        public bool Add(Produto produto)
        {

            return _produtorepository.Add(produto);
        }

        public List<Produto> GetList()
        {
            return _produtorepository.GetList();
        }
    }
}
