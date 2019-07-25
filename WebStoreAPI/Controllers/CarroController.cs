using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebStoreAPI.Business;
using WebStoreAPI.Domain;
using WebStoreAPI.Services;
using WebStoreAPI.Services.Interfaces;

namespace WebStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private readonly ICarroServices _carroServices;
        private readonly ILogger<CarroController> _logger;
        public CarroController(ICarroServices carroServices, ILogger<CarroController> logger)
        {
            _carroServices = carroServices;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Carro>> Get()
        {
            try
            {
                _logger.LogInformation("Received get request");

                return Ok(_carroServices.GetAll());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{key:guid}")]
        public ActionResult<Carro> Get([FromRoute] Guid key)
        {
            try
            {
                _logger.LogInformation("Received get request");

                return Ok(_carroServices.FindByKey(key));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{marca}")]
        public ActionResult<Carro> GetMarca([FromRoute] string marca)
        {
            try
            {
                _logger.LogInformation("Received get request");

                return Ok(_carroServices.FindByString(marca));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Carro carro)
        {
            try
            {
                _logger.LogInformation("Received post request");

                if (ModelState.IsValid)
                {
                    _carroServices.Insert(carro);

                    return Ok("success");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}