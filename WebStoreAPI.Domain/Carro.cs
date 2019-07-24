using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain.Abstract;

namespace WebStoreAPI.Domain
{
    public sealed class Carro : Entity
    {
        public string Ano { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}
