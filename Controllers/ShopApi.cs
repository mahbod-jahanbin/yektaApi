using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using yektaApi.Models;

namespace yektaApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopApi : ControllerBase
    {
        private readonly ApiContext _context;

        public ShopApi(ApiContext context)
        {
            _context = context;
        }

        public List<ProCategory> GetCats()
        {
            return _context.ProCategory.OrderBy(c => c.CPId).ToList();
        }
        public List<Product> GetProducts(int CPID)
        {
            return _context.Product.Where(c => c.CPId == CPID).ToList();
        }
    }
}
