using BlogsAPI.Models.DTO.Blog;
using BlogsAPI.Models.Entities;
using BlogsAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BlogsAPI.Controllers
{
    public class BlogsController : ApiController
    {
        private BlogService _blogService = new BlogService();

        // GET: api/Blogs
        public IEnumerable<GetBlogDTO> Get()
        {
            return _blogService.GetAll();
        }

        // GET: api/Blogs/5
        public GetBlogDTO Get(int id)
        {
            return _blogService.GetByID(id);
        }

        // POST: api/Blogs
        public GetBlogDTO Post([FromBody] AddBlogDTO blogToAdd)
        {
            return _blogService.Create(blogToAdd);
        }

        // PUT: api/Blogs/
        public bool Put([FromBody] EditBlogDTO blogToUpdate)
        {
            return _blogService.Update(blogToUpdate);
        }

        // DELETE: api/Blogs/5
        public async Task<bool> Delete(int id)
        {
            return await _blogService.DeleteByID(id);
        }
    }
}
