using Okaz.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okaz.Core.Entities;
using Okaz.Application.IServices.ItemServices;
using Okaz.Core;

namespace Okaz.Application.Services.ItemServices
{
    public class ItemService : IItemService
    {
        protected readonly IUnitOfWork _unitOfWork;

        public ItemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Item>> GetAll(){
            return await _unitOfWork.ItemRepository.GetAllAsync();
        }
    }
}
