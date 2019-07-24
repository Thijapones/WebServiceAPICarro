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
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private readonly CarroServices _carroServices;
        public CarroController()
        {
            var carrobusiness = new CarroBusinnes();

            _carroServices = new CarroServices(carrobusiness);
        }

        [HttpGet]
        public ActionResult<List<Carro>> Get()
        {
            return _carroServices.List();
        }

        [HttpPost]
        public void Post([FromBody] Carro carro)
        {
            _carroServices.Insert(carro);
        }
    }
}