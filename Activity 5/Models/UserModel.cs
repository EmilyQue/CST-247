using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity4.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public UserModel(string Name, string Email, string Phone)
        {
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
        }
    }
}