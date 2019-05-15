using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Activity3.Models
{
    [DataContract]
    public class UserModel
    { 
        public UserModel(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        //properties
        [DataMember]
        [Required]
        [DisplayName("Username")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Username { get; set; }

        [DataMember]
        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Password { get; set; }


    }
}