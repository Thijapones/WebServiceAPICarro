using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Business.Interfaces
{
    public interface ICarroBusiness
    {

        Carro FindByKey(Guid key);

        Carro FindByString(string Marca);

        bool Add(Carro produto);

        List<Carro> GetList();

        List<Carro> GetAll();

    }
}
