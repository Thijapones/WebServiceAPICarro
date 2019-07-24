using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Business.Interfaces;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository;

namespace WebStoreAPI.Business
{
    public class CarroBusinnes : ICarroBusiness
    {
        CarroRepository _carrorepository;
        public CarroBusinnes()
        {
            _carrorepository = new CarroRepository();
        }

        public bool Add(Carro carro)
        {

            return _carrorepository.Add(carro);
        }

        public List<Carro> GetList()
        {
            return _carrorepository.GetList();
        }
    }
}
