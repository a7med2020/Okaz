using Okaz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Application.IServices.ItemServices
{
    public interface IItemService
    {
        Task<List<Item>> GetAll();
    }
}
