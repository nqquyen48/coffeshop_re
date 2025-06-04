using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Shop()
        {
            var products = _repository.GetAllProducts();
            return View(products);
        }
    }
}
