
using RETP.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RETP.app.Product
{
    public interface IProductService
    {
         Task<int> Create(ProductCreateRequest request);
        
    }
}
