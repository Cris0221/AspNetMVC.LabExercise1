using AspNetMVC.LabExercise1.Service;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMVC.LabExercise1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        public IActionResult List()
        {
            ViewData["List"] = _productService.GetCatalog();
            ViewData["GrandTotal"] = _productService.GetGrandtotal().ToString("C2");
            return View();
        }
    }
}
