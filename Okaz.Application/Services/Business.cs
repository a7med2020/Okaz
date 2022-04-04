using Okaz.Application.IServices;
using Okaz.Application.IServices.ItemServices;
using Okaz.Application.Services.ItemServices;
using Okaz.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Application.Services
{
    public class Business : IBusiness
    {
        private readonly IUnitOfWork _unitOfWork;
        public Business(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            ItemService = new ItemService(_unitOfWork);
        }
        public IItemService ItemService { get; private set; }
         
    }
}
