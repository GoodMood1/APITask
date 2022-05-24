using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsAPI.Models.DTO.Blog
{
    public class EditBlogDTO
    {
        public int BlogID { get; set; }

        public string BlogContent { get; set; }
    }
}