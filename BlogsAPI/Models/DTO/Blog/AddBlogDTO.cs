using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsAPI.Models.DTO.Blog
{
    public class AddBlogDTO
    {
        public string BlogContent { get; set; }

        public int fk_UserID { get; set; }
    }
}