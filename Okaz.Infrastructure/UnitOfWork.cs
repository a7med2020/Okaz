using Okaz.Core;
using Okaz.Core.Entities;
using Okaz.Core.IRepositories._Base;
using Okaz.Infrastructure.Contexts;
using Okaz.Infrastructure.Repositories._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OkazContext _okazContext;

        public UnitOfWork(OkazContext context)
        {
            _okazContext = context;
            ItemRepository = new BaseRepository<Item>(_okazContext);
        }

        public IBaseRepository<Item> ItemRepository { get; }

        public int Complete()
        {
            return _okazContext.SaveChanges();
        }

        public void Dispose()
        {
            _okazContext.Dispose();
        }
    }
}
