using BlogsAPI.Models.DTO.Blog;
using BlogsAPI.Models.Entities;
using Mapster;
using System;
using BlogsAPI.Models.DAL;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace BlogsAPI.Service
{
    public class BlogService
    {
        public GetBlogDTO Create(AddBlogDTO addBlogDTO)
        {
            Blog newBlog = addBlogDTO.Adapt<Blog>();

            newBlog.BlogDateTime = DateTime.Now;

            Blog addedBlog = DAL.Blogs.Add(newBlog);

            return addedBlog.Adapt<GetBlogDTO>();
        }

        public List<GetBlogDTO> GetAll()
        {
            List<Blog> allBlogs = DAL.Blogs.All();

            return allBlogs.Adapt<List<GetBlogDTO>>();
        }

        internal GetBlogDTO GetByID(int blogID)
        {
            Blog blogByID = DAL.Blogs.ByID(blogID);

            if (blogByID == null)
                blogByID = new Blog();

            return blogByID.Adapt<GetBlogDTO>();
        }

        public bool Update(EditBlogDTO blogToUpdate)
        {
            Blog blogToSave = blogToUpdate.Adapt<Blog>();

            blogToSave.BlogContent = blogToUpdate.BlogContent;
            blogToSave.UpdatedDateTime = DateTime.Now;

            bool saveResult = DAL.Blogs.Update(blogToSave);

            return saveResult;
        }

        public async Task<bool> DeleteByID(int id)
        {
            return await DAL.Blogs.DeleteByID(id);
        }
    }
}