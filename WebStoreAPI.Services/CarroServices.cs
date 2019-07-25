using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Business.Interfaces;
using WebStoreAPI.Domain;
using WebStoreAPI.Services.Interfaces;

namespace WebStoreAPI.Services
{
    public class CarroServices : ICarroServices
    {

        private readonly ICarroBusiness _carroBusiness;
        public CarroServices(ICarroBusiness carrobusiness)
        {
            _carroBusiness = carrobusiness;
        }

        public Carro FindByKey(Guid key)
        {
            return _carroBusiness.FindByKey(key);
        }

        public Carro FindByString(string marca)
        {
            return _carroBusiness.FindByString(marca);
        }

        public List<Carro> Insert(Carro carro)
        {
            _carroBusiness.Add(carro);

            return _carroBusiness.GetList();
        }

        public List<Carro> List()
        {
            return _carroBusiness.GetList();
        }

        public List<Carro> GetAll()
        {
            return _carroBusiness.GetAll();
        }
    }
}
