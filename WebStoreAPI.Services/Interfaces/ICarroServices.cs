using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Services.Interfaces
{
    public interface ICarroServices
    {
        Carro FindByKey(Guid key);

        Carro FindByString(string marca);

        List<Carro> List();

        List<Carro> Insert(Carro carro);

        List<Carro> GetAll();
    }
}
