using ProductsAPI.Models;

namespace ProductsAPI.Services
{
    public interface IProductService
    {
        public IEnumerable<Products> GetProductList();
        public Products GetProductById(int productId);
        public Products AddProduct(Products newProduct);
        public Products UpdateProduct(Products existingProduct);
        public bool DeleteProduct(int productId);
    }
}
