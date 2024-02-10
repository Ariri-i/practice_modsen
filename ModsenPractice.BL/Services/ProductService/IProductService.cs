using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice.BL.Services.ProductService
{
    public interface IProductService
    {
        public void GetProductList();

        public void AddProduct();

        public void UpdateProduct();

        public void DeleteProduct();
    }
}
