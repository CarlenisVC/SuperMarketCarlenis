using Application.Enums;
using Application.Services;
using Application.Viewmodels;
using Microsoft.AspNetCore.Mvc;

namespace SuperMarket2024G34.Controllers
{
    public class MarketController : Controller
    {
        private ProductService productService;
        public MarketController()
        {
            productService = new();
        }
        public IActionResult Index(string? message = null, string? messageType = null)
        {
            ViewBag.Message = message;
            ViewBag.MessageType = messageType;
            return View(productService.GetAll());
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult CreateProduct(CreateProductViewModel cpvm)
        {
            try
            {
                productService.Add(cpvm);
                return RedirectToRoute(new { controller = "Market", action = "Index",message = "Product created successfully",messageType= "alert-success" });//dynamic
            }
            catch (Exception)
            {
                return RedirectToRoute(new { controller = "Market", action = "Index", message = "Product creation failed", messageType = "alert-danger" });//dynamic
            }
           
        }
        public IActionResult Edit(string name)
        {
            var allProducts = productService.GetAll();

            var product = allProducts.Fruits.FirstOrDefault(p => p.Name == name)
                       ?? allProducts.Vegetables.FirstOrDefault(p => p.Name == name)
                       ?? allProducts.DairyProducts.FirstOrDefault(p => p.Name == name);

            if (product == null)
            {
                return RedirectToAction("Index", new { message = "Product not found", messageType = "alert-danger" });
            }

            int productType = allProducts.Fruits.Any(p => p.Name == name) ? (int)ProductType.FRUIT :
                              allProducts.Vegetables.Any(p => p.Name == name) ? (int)ProductType.VEGETABLE :
                              (int)ProductType.DAIRY_PRODUCT;

            var vm = new EditProductViewModel
            {
                OriginalName = name,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ProductType = productType
            };

            return View(vm);
        }
        [HttpPost]
        public IActionResult EditProduct(EditProductViewModel vm)
        {
            try
            {
                productService.Edit(vm);
                return RedirectToAction("Index", new { message = "Product updated successfully", messageType = "alert-success" });
            }
            catch (Exception)
            {
                return RedirectToAction("Index", new { message = "Product update failed", messageType = "alert-danger" });
            }
        }


        [HttpPost]
        public IActionResult DeleteProduct(string name)
        {
            try
            {
                productService.Delete(name);
                return RedirectToRoute(new { controller = "Market", action = "Index", message = "Product Deleted", messageType = "alert-success" });//dynamic
            }
            catch (Exception)
            {
                return RedirectToRoute(new { controller = "Market", action = "Index", message = "Product Deleted failed", messageType = "alert-danger" });//dynamic
            }
        }

    }
}
