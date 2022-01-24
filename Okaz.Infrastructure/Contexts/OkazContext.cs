using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Infrastructure.Contexts
{
    class OkazContext : IdentityDbContext
    {
        public OkazContext(DbContextOptions<OkazContext> options) : base(options)
        {

        }

        //public DbSet<Employee.Core.Entities.Employee> Employees { get; set; }
    }
}
