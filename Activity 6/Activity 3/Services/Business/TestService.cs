using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Activity3.Services.Utility;
using Unity;

namespace Activity3.Services.Business
{
    public class TestService : ITestService
    {
        private ILogger logger;

        [InjectionMethod]
        public void Initialize(ILogger logger)
        {
            this.logger = logger;
        }

        public void TestLogger()
        {
            logger.Info("Test Logging in TestService.TestLogger() invoked");
        }
    }
}