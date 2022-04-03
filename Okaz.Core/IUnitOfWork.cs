using Okaz.Core.Entities;
using Okaz.Core.IRepositories._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Item> ItemRepository { get; }
        int Complete();
    }
}
