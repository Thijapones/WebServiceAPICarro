using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Business.Interfaces
{
    public interface ICarroBusiness
    {
        bool Add(Carro produto);

        List<Carro> GetList();
    }
}
