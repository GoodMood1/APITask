using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BlogsAPI.Models.Entities
{
    [Table("Blogs")]
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [Required]
        public string BlogContent { get; set; }

        [Required]
        public DateTime BlogDateTime { get; set; }

        public Nullable<DateTime> UpdatedDateTime { get; set; } 

        [Required]
        public int fk_UserID { get; set; } 
        
        [ForeignKey("fk_UserID")]
        public User User { get; set; }
    }
}