
using Microsoft.AspNetCore.Http;
using RETP.data.ef;
using RETP.data.entities;
using RETP.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RETP.app.Product
{
    public class ProductService : IProductService
    {
        private readonly RETPDBContext _context;
        public ProductService(RETPDBContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Products()
            {

               // RE_ID=request. re_id,
                Title = request.title,
                Description = request.description,
                Address = request.address,
                
               

            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }
       

        
    }
}
