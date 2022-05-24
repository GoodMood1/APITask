using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsAPI.Models.DTO.User
{
    public class EditUserDTO
    {
        public int UserID { get; set; }

        public string NewPassword { get; set; }
    }
}