using Microsoft.EntityFrameworkCore;
using ProductsAPI.Data;
using ProductsAPI.Models;

namespace ProductsAPI.Services
{
    public class ProductsService : IProductService
    {
        private readonly ProductDbContextClass _productDbContext;
        public ProductsService(ProductDbContextClass productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public Products AddProduct(Products newProduct)
        {
            var product = _productDbContext.Products.Add(newProduct);
            _productDbContext.SaveChanges();
            return product.Entity;
        }
        public IEnumerable<Products> GetProductList() => _productDbContext.Products.ToList();
        public Products GetProductById(int productId) => _productDbContext.Products.Where(p => p.ProductId == productId).FirstOrDefault();
        public bool DeleteProduct(int productId)
        {
            var del_prod = _productDbContext.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            _productDbContext.Products.Remove(del_prod);
            _productDbContext.SaveChanges();
            return del_prod != null ? true : false;
        }
        public Products UpdateProduct(Products existingProduct)
        {
           var x_prod = _productDbContext.Products.Update(existingProduct);
            _productDbContext.SaveChanges();
            return x_prod.Entity;
        }
    }
}
