using Okaz.Application.IServices.ItemServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Application.IServices
{
    public interface IBusiness
    {
        IItemService ItemService { get; }
    }
}
