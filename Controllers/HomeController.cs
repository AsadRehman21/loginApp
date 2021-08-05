using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using loginApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace loginApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context ;
        private readonly ILogger<HomeController> _logger;

        public HomeController(DataContext context,ILogger<HomeController> logger)
        {
            _logger = logger;
            this.context=context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }

         public IActionResult logout()
        {
            return View();
        }

        public IActionResult Customer()
        {  
            var customer = new CustomerandOrderList 
            {
                
                Customers = context.Customers.ToList(),
                Orders=context.Orders.ToList()
               
            };
            
            return View(customer);
        }

        public IActionResult Orders()
        {
             var customer = new CustomerandOrderList 
            {
                
                Customers = context.Customers.ToList(),
                Orders=context.Orders.ToList()
               
            };
            
            return View(customer);
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



[HttpPost]
 public IActionResult Update(IFormCollection f)
        {

           
            
                  int id=Int32.Parse(f["Id"]);
                  var CompanyName= f["CompanyName"];
                  var  ContactName= f["ContactName"];
                  var ContactTitle=f["ContactTitle"];
                  var Address=f["Address" ];
                  var City=f["City"];
                  var Region= f["Region"];
                  var PostalCode= f["PostalCode"];
                  var Country=f["Country"];
                  var Phone=f["Phone"];
                  var Fax=f["Fax"];

                    var updated= context.Customers
                      .Where(p=>p.Id ==  id)
                      .FirstOrDefault();


                      if (updated != null)
                        {
                            
                            updated.CompanyName= CompanyName;
                            updated.ContactName= ContactName;
                            updated.ContactTitle=ContactTitle;
                            updated.Address=Address;
                            updated.City=City;
                            updated.Region= Region;
                            updated.PostalCode= PostalCode;
                            updated.Country=Country;
                            updated.Phone=Phone;
                            updated.Fax=Fax;
                            context.SaveChanges();
                        }
          

          return RedirectToAction("Customer");
            
    }

     public IActionResult Delete(int id1)
        {
                     var customer=  context.Customers
                      .OrderBy(p=>p.Id ==  id1).Include(p => p.Orders).FirstOrDefault();
                      var order=customer.Orders;
                      context.Customers.Remove(customer);
                       
                    //   var order= context.Orders
                    //   .Where(p=>p.Id ==  id2)
                    //   .FirstOrDefault();
                    //   context.Orders.Remove(order);

                    foreach(var temp in order)
                    {
                          var result= context.Orders
                      .Where(p=>p.Id ==  temp.Id)
                      .FirstOrDefault();
                      context.Orders.Remove(result);
                    }
                      context.SaveChanges();
                      
           return RedirectToAction("Customer");
        }
}
}
