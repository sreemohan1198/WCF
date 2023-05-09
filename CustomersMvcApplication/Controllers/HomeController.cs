

using CustomersMvcApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewEntityClassLibrary;
using System.Diagnostics;

namespace CustomersMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerOrdersEntities1 _dbContext=new CustomerOrdersEntities1();

        //public HomeController(CustomerOrdersEntities1 context)
        //{
        //    _dbContext = context;
        //
        public IEnumerable<customer> GetCustomers()
        {
            return _dbContext.customers.ToList();
        }
            
        public customer GetCustomerById(int id)
        {
            return _dbContext.customers.Find(id);
        }
           public void Add(customer customer)
        {
            _dbContext.customers.Add(customer);
            _dbContext.SaveChanges();
        }

           

            //public void Update(customer customer)
            //{
            //    _dbContext.Entry(customer).State = EntityState.Modified;
            //    _dbContext.SaveChanges();
            //}

            //public void Delete(int id)
            //{
            //    var model = _dbContext.customers.Find(id);
            //    _dbContext.customers.Remove(model);
            //    _dbContext.SaveChanges();
            //}

            public void Dispose()
            {
                _dbContext.Dispose();
            }
        }


    }










    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}


    //public IActionResult Index()
    //{
    //    return View();
    //}

    //public IActionResult Privacy()
    //{
    //    return View();
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
