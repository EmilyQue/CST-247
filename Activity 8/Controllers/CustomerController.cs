using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICA8.Models;

namespace ICA8.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            customers.Add(new CustomerModel(0, "Emily", 20));
            customers.Add(new CustomerModel(1, "Mickey", 45));
            customers.Add(new CustomerModel(2, "Donald", 40));
        }

        // GET: Customer
        [HttpGet]
        public ActionResult Index()
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[0]);
            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string user)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[Int32.Parse(user)]);
            return View("Customer", tuple); 
        }

        [HttpPost]
        public PartialViewResult OnSelectCustomer2(string user)
        {
            return PartialView("_CustomerDetails", customers[Int32.Parse(user)]);
        }

        [HttpPost]
        public string GetMoreInfo(string user)
        {
            return "Test";
        }
    }
}