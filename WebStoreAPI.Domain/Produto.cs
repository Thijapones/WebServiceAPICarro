using System;
using WebStoreAPI.Domain.Abstract;

namespace WebStoreAPI.Domain
{
    public sealed class Produto : Entity
    {
        public string Marca { get; set; }

        public string Nome { get; set; }
    }
}
