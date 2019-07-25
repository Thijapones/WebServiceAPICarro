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
        public CarroBusinnes(CarroRepository carroRepository)
        {
            _carrorepository = carroRepository;
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

        public List<Carro> GetAll()
        {
            return _carrorepository.GetAll("select * from Carro");
        }
    }
}
