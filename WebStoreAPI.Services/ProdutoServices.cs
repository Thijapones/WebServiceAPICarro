using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using WebStoreAPI.Business.Interfaces;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository;
using WebStoreAPI.Services.Interfaces;

namespace WebStoreAPI.Services
{
    public class ProdutoServices : IProdutoServices
    {
        private readonly IProdutoBusiness _produtoBusiness;
        public ProdutoServices(IProdutoBusiness produtobusiness)
        {
            _produtoBusiness = produtobusiness;
        }

        public Produto FindByKey(Guid key)
        {
            return _produtoBusiness.FindByKey(key);
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
