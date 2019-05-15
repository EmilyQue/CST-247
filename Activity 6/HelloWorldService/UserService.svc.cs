using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Activity3.Models;

namespace HelloWorldService
{
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        List<UserModel> users = new List<UserModel>();

        public UserService()
        {
            users.Add(new UserModel("EmilyQ", "password"));
            users.Add(new UserModel("Gaby1", "password2"));
            users.Add(new UserModel("MickeyM", "password3"));
        }

        public DTO GetAllUsers()
        {
            DTO dto = new DTO(0, "OK", users);
            return dto;
        }

        public DTO GetUser(string id)
        {
            int index = Int32.Parse(id);
            if (index > users.Count)
            {
                DTO dto = new DTO(-1, "User Does Not Exist", null);
                return dto;
            }
            else
            {
                List<UserModel> user = new List<UserModel>();
                user.Add(users[index]);
                DTO dto = new DTO(0, "OK", user);
                return dto;
            }
        }

        public string SayHello()
        {
            return "Hello From My First WCF Rest Service!";
        }
             
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetObjectModel(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            CompositeType composite = new CompositeType();
            composite.BoolValue = false;
            composite.StringValue = "Your value was " + id;
            return composite;
        }
    }
}
