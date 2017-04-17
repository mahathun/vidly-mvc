using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> customersList = new List<Customer>()
            {
                new Customer(){Id=1,Name="Paaul"},
                new Customer(){Id=2,Name="Shaun"},
                new Customer(){Id=3,Name="Nick"},
            };
        // GET: Customers
        public ActionResult Index()
        {
            
            var customers = new IndexCustomersViewModel() { Customers=customersList };

            return View(customers);
        }

        [Route("customers/view/{id}")]
        public ActionResult View(int id)
        {

            var customer = customersList.Find(c => c.Id == id);
            if (customer!=null)
            {
                return View(customer);

            }
            else
            {
                return HttpNotFound();
            }


        }
    }
}