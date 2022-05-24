using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsAPI.Models.DTO.Blog
{
    public class GetBlogDTO
    {
        public int BlogID { get; set; }

        public string BlogContent { get; set; }

        public DateTime BlogDateTime { get; set; }

        public int fk_UserID { get; set; }

        public DateTime? UpdatedDateTime { get; set; }
    }
}