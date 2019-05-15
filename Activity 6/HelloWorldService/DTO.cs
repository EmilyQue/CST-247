using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Activity3.Models;

namespace HelloWorldService
{
    [DataContract]
    public class DTO
    {
        [DataMember]
        public int ErrorCode;

        [DataMember]
        public string ErrorMsg;

        [DataMember]
        public List<UserModel> Data;

        public DTO(int ErrorCode, string ErrorMsg, List<UserModel> Data)
        {
            this.ErrorCode = ErrorCode;
            this.ErrorMsg = ErrorMsg;
            this.Data = Data;
        }
            
    }
}