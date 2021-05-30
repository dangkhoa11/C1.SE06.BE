using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RETP.app.Product;
using RETP.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RETP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _publicproductService;
        public ProductController(IProductService publicproductService)
        {
            _publicproductService = publicproductService;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _publicproductService.Create(request);
            if (result == 0)
                return BadRequest("unsucessfull");
            return Ok("sucessfull");
        }
    }
}
 