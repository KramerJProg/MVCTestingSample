using Microsoft.AspNetCore.Mvc;
using MVCTestingSample.Models;
using MVCTestingSample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestingSample.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _repo.GetAllProductsAsync();
            return View(products);
        }
    }
}
