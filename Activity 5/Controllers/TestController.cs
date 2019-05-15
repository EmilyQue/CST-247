using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity4.Models;

namespace Activity4.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> user = new List<UserModel>();
            user.Add(new UserModel("Emily Quevedo", "emily@email.com", "1112223333"));
            user.Add(new UserModel("Mickey Mouse", "mickey@mouse.com", "9998887777"));
            user.Add(new UserModel("Donald Duck", "donald@duck.com", "4445556666"));

            return View("Test", user);
        }
    }
}