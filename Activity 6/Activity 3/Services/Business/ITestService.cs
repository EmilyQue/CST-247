using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity3.Services.Utility;

namespace Activity3.Services.Business
{
    public interface ITestService
    {
        void Initialize(ILogger logger);
        void TestLogger();
    }
}
