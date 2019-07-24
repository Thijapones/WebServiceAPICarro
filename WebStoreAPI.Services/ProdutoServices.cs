using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using WebStoreAPI.Business.Interfaces;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository;

namespace WebStoreAPI.Services
{
    public class ProdutoServices
    {
        private readonly IProdutoBusiness _produtoBusiness;
        public ProdutoServices(IProdutoBusiness produtobusiness)
        {
            _produtoBusiness = produtobusiness;
        }

        public List<Produto> Insert(Produto produto)
        {
            _produtoBusiness.Add(produto);

            return _produtoBusiness.GetList();
        }

        public List<Produto> List()
        {
            return _produtoBusiness.GetList();
        }
    }
}
