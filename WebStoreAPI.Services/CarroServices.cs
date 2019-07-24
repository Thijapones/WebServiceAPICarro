using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Business.Interfaces;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Services
{
    public class CarroServices
    {
        private readonly ICarroBusiness _carroBusiness;
        public CarroServices(ICarroBusiness carrobusiness)
        {
            _carroBusiness = carrobusiness;
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
    }
}
