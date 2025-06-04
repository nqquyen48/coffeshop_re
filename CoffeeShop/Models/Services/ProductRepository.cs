using CoffeeShop.Data;
using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly CoffeeshopDbContext _context;

        public ProductRepository(CoffeeshopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts() => _context.Products;

        public Product GetProductDetail(int id) => _context.Products.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Product> GetTrendingProducts() => _context.Products.Where(p => p.IsTrendingProduct);
    }
}
