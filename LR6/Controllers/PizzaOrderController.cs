using LR6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LR6.Controllers
{
    public class PizzaOrderController : Controller
    {

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user.Age > 16)
            {
                ViewBag.ShowOrderQuantityField = true;
            }
            else
            {
                ViewBag.ShowOrderQuantityField = false;
            }
            return View("Order", user);
        }


        [HttpPost]
        public IActionResult ConfirmOrder(User user, List<Product> products)
        {
            ViewBag.User = user;
            ViewBag.Products = products;
            return View();
        }
    }
}
