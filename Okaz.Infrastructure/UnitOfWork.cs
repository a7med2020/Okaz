using Okaz.Core;
using Okaz.Infrastructure.Contexts;
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
            //Courses = new CourseRepository(_okazContext);
        }

        //public ICourseRepository Courses { get; private set; }
     
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
