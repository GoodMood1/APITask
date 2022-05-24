using BlogsAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogsAPI.Models.DAL
{
    public static partial class DAL
    {
        public static class Blogs
        {
            public static Blog Add(Blog newBlog)
            {
                using (var db = new BlogAPIDbContext())
                {
                    db.Blogs.Add(newBlog);
                    db.SaveChanges();

                    return newBlog;
                }
            }

            public static Blog ByID(int BlogID)
            {
                Blog blog = null;

                using (var db = new BlogAPIDbContext())
                {
                    var searchResults = db.Blogs.Where(b => b.BlogID == BlogID);

                    if (searchResults.Any())
                    {
                        blog = searchResults.First();
                    }
                }

                return blog;
            }

            public static async Task<bool> DeleteByID(int BlogID)
            {
                int numberOfDeletedRecords = 0;

                using (var db = new BlogAPIDbContext())
                {
                    var searchResults = db.Blogs.Where(b => b.BlogID == BlogID);

                    if (searchResults.Any())
                    {
                        Blog blogToDelete = searchResults.First();

                        db.Blogs.Remove(blogToDelete);

                        numberOfDeletedRecords = await db.SaveChangesAsync();
                    }
                }

                return numberOfDeletedRecords > 0;
            }

            public static List<Blog> All()
            {
                using (var db = new BlogAPIDbContext())
                {
                    return db.Blogs.ToList();
                }
            }

            public static bool Update(Blog blogToSave)
            {
                int numberOfUpdatedRecords = 0;

                using (var db = new BlogAPIDbContext())
                {
                    var searchResults = db.Blogs.Where(b => b.BlogID == blogToSave.BlogID);

                    if (searchResults.Any())
                    {
                        Blog blogFromDB = searchResults.First();

                        blogFromDB.BlogContent = blogToSave.BlogContent;
                        blogFromDB.UpdatedDateTime = blogToSave.UpdatedDateTime;

                        numberOfUpdatedRecords = db.SaveChanges();
                    }
                }

                return numberOfUpdatedRecords > 0;
            }
        } 
    }


}