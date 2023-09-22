using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using FinalTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetAll()
            };
            return View(productViewModel);
        }

        public IActionResult Privacy()
        {
            var top5 = _productService.GetTop5Products();
            return View(top5);
        }

    }
}