using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _7_Simple_Model_View_Binding.ViewModel;

namespace _7_Simple_Model_View_Binding.Controllers
{
    public class ClientController : Controller
    {
        // Use to bind Model to View
        [BindProperty]

        public ClientUIModel ClientUIModel { get; set; }

        // Write seperate Action for Bind Data
        [HttpPost]
        public IActionResult OnSubmit()
        {
            return View("Index");
        }
               
        public IActionResult Index()
        {
            return View();
        }
    }
}