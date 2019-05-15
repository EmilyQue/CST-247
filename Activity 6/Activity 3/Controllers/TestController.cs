using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [CustomAuthorization]
        [HttpGet]
        public String Index()
        {
            return "Test Controller";
        }
    }
}