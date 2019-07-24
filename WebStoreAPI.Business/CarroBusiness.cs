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

        public Carro FindByKey(Guid key)
        {
            return _carrorepository.FindByKey(key);
        }

        public Carro FindByString(string marca)
        {
            return _carrorepository.FindByString(marca);
        }

        public bool Add(Carro carro)
        {
            _carrorepository.Add(carro);
            return true;
        }

        public List<Carro> GetList()
        {
            return _carrorepository.GetList();
        }
    }
}
