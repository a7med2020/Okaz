using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Okaz.Application.IServices;
using Okaz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Okaz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IBusiness _business;

        public HomeController(IBusiness business)
        {
            _business = business;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _business.ItemService.GetAll();
        }
    }
}
