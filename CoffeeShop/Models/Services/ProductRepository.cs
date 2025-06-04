using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>
        {
            new Product{ Id = 1, Name = "Americano", Price= 25, Detail="Name product", ImageUrl="https://example.com", IsTrendingProduct=true },
            new Product{ Id = 2, Name = "Vietnamese", Price= 20, Detail="Vietnamese product", ImageUrl="https://example.com", IsTrendingProduct=false },
        };

        public IEnumerable<Product> GetAllProducts() => products;

        public Product GetProductDetail(int id) => products.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Product> GetTrendingProducts() => products.Where(p => p.IsTrendingProduct);
    }
}
