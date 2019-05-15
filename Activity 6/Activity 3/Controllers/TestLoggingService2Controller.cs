using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity3.Services.Utility;
using Unity;

namespace Activity3.Controllers
{
    public class TestLoggingService2Controller : Controller
    {
        [Dependency]
        public ILogger logger { get; set; }

        // GET: TestLoggingService2
        public string Index()
        {
            logger.Info("Test Logging Service 2 at index()");
            return "Test Logging Service 2 at index()";
        }
    }
}