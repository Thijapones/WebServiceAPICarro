using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreAPI.Domain.Abstract
{
    public abstract class Entity : IEntity
    {
        public Guid Key { get; }
        public string Text { get; }

        protected Entity()
        {
            Key = Guid.NewGuid();
        }
    }
}
