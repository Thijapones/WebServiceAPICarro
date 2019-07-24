using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoreAPI.Domain
{
    public interface IEntity
    {
        Guid Key { get; }
        string Text { get; }
    }
}
