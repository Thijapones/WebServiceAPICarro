using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStoreAPI.Business;
using WebStoreAPI.Domain;
using WebStoreAPI.Services;

namespace WebStoreAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoServices _produtoServices;
        public ProdutoController()
        {
            var produtobusiness = new ProdutoBusinnes();

            _produtoServices = new ProdutoServices(produtobusiness);
        }

        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            return _produtoServices.List();
        }

        [HttpPost]
        public void Post([FromBody] Produto produto)
        {
            _produtoServices.Insert(produto);
        }
    }
}