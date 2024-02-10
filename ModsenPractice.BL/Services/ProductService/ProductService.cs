using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModsenPractice.DAL.Repository.ProductRepository;
using ModsenPractice.DAL.Models;

namespace ModsenPractice.BL.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public void AddProduct()
        {
            var product = new Product();
            _productRepository.Add(product);
        }

        public void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public void GetProductList()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
