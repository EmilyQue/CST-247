using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity3.Services.Business;
using Activity3.Services.Utility;

namespace Activity3.Controllers
{
    public class TestLoggingService3Controller : Controller
    {
        private readonly ILogger logger;
        private readonly ITestService service;

        public TestLoggingService3Controller(ILogger logger, ITestService service)
        {
            this.logger = logger;
            this.service = service;
        }

        // GET: TestLoggingService3
        public string Index()
        {
            logger.Info("Test Logging Service 3 index() invoked.");
            service.TestLogger();
            return "Test Logging Service 3 index() invoked.";
        }
    }
}