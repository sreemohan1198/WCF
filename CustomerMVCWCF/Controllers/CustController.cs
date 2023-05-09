using EntityFrameworkClassLibrary.EntityData;
using Microsoft.AspNetCore.Mvc;

namespace CustomerMVCWCF.Controllers
{
    public class CustController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult CustIndex()
        {       
                using (var context = new CustomerOrdersContext())
                {
                    var customers = context.Customers.ToList();
                    return View(customers);
                }            
        }

    }
}
