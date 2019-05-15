using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Activity3.Models;
using Activity3.Services.Business;
using Activity3.Services.Utility;
using NLog;

namespace Activity3.Controllers
{
    [CustomAction]
    public class LoginController : Controller
    {
        //private static Logger logger = LogManager.GetLogger("myAppLoggerRules");
        private static MyLogger1 logger = MyLogger1.GetInstance();

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            logger.Info("Entering LoginController.Login()");
            logger.Info("Parameters are: {0}", new JavaScriptSerializer().Serialize(model));
            if (!ModelState.IsValid)
            {
                return View("Login");
            }

            SecurityService services = new SecurityService();
            try
            {
                //call security service to authenticate the user
                SecurityService service = new SecurityService();
                bool result = service.Authenticate(model);

                if (result)
                {
                    logger.Info("Exit LoginController.Login() with login passed");
                    return View("LoginPassed", model);
                }
                else
                {
                    logger.Info("Exit LoginController.Login() with login failed");
                    return View("LoginFailed");
                }
            }

            catch (Exception e)
            {
                logger.Error("Exception LoginController.Login(): ", e.Message);
                return View("LoginError");
            }
        }

        [HttpGet]
        [CustomAuthorization]
        public string Protected()
        {
            return "I am protected";
        }

        public string GetAllUsers()
        {
            var cache = MemoryCache.Default;

            // Get Users from the Cache and if Users do not exist in the Cache then put them in Cache 
            List<UserModel> users = cache.Get("Users") as List<UserModel>;
            if (users == null)
            {
                // Log Message
                MyLogger1.GetInstance().Info("Creating Users and putting in the Cache.");

                // Create a List of Users
                users = new List<UserModel>();
                users.Add(new UserModel("Emily", "password"));
                users.Add(new UserModel("Gaby", "password2"));
                users.Add(new UserModel("Mickey", "password3"));

                // Save the Users in the Cache with a 60s expiration policy
                var policy = new CacheItemPolicy().AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(60.0);
                cache.Set("Users", users, policy);
            }
            else
            {
                // Log Message
                MyLogger1.GetInstance().Info("Got Users from the Cache.");
            }

            return new JavaScriptSerializer().Serialize(users);
        }
    }
}