using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity3.Services.Utility;

namespace Activity3.Controllers
{
    public class TestLoggingService1Controller : Controller
    {
        private readonly ILogger logger;

        public TestLoggingService1Controller(ILogger service)
        {
            this.logger = service;
        }

        // GET: TestLoggingService1
        public string Index()
        {
            logger.Info("Test Logging Service 1 at index()");
            return "Test Logging Service 1 at index()";
        }
    }
}