using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;
using ProductsAPI.Services;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService) => _productService = productService; 

        [HttpPost]
        public Products AddProducts(Products newProduct) => _productService.AddProduct(newProduct);
        [HttpGet]
        public IEnumerable<Products> FetchAllProducts() => _productService.GetProductList();
        [HttpGet("{productId:int}")]
        public Products FetchProductsById(int productId) => _productService.GetProductById(productId);
        [HttpPut]
        public Products UpdateExistingProduct(Products existingProduct) => _productService.UpdateProduct(existingProduct);
        [HttpDelete("{productId:int}")]
        public bool DeleteProductById(int productId) => _productService.DeleteProduct(productId);
    }
}
