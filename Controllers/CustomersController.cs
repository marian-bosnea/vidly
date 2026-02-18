using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {

            var customers = new List<Customer> {
             new() {  Name="John Smith"  },
             new() { Name="Mary Williams" }
            };

            var viewModel = new CustomersViewModel { Customers = customers };

            return View(viewModel);
        }
    }
}
