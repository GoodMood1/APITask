using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsAPI.Models.DTO.User
{
    public class AddUserDTO
    {
        public string UserName { get; set; }
        public string PasswordText { get; set; }
    }
}