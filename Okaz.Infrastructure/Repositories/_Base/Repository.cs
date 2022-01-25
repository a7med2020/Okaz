using Microsoft.EntityFrameworkCore;
using Okaz.Core.IRepositories._Base;
using Okaz.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Infrastructure.Repositories._Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly OkazContext _okazContext;

        public Repository(OkazContext employeeContext)
        {
            _okazContext = employeeContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _okazContext.Set<T>().AddAsync(entity);
            await _okazContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _okazContext.Set<T>().Remove(entity);
            await _okazContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _okazContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _okazContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
