using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogsAPI.Models.Entities;

namespace BlogsAPI.Models.DAL
{
    public static partial class DAL
    {
        public static class Users
        {
            public static User Add(User newUser)
            {
                using (var db = new BlogAPIDbContext())
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();

                    return newUser;
                }
            }

            public static User ByID(int UserID)
            {
                User user = null;

                using (var db = new BlogAPIDbContext())
                {
                    var searchResults = db.Users.Where(u => u.UserID == UserID);

                    if (searchResults.Any())
                    {
                        user = searchResults.First();
                    }
                }

                return user;
            }

            public static bool DeleteByID(int UserID)
            {
                int numberOfDeletedRecords = 0;

                using (var db = new BlogAPIDbContext())
                {
                    var searchResults = db.Users.Where(u => u.UserID == UserID);

                    if (searchResults.Any())
                    {
                        User UserToDelete = searchResults.First();

                        db.Users.Remove(UserToDelete);

                        numberOfDeletedRecords = db.SaveChanges();
                    }
                }

                return numberOfDeletedRecords > 0;
            }

            public static List<User> All()
            {             
                using (var db = new BlogAPIDbContext())
                {
                    return db.Users.ToList();
                }
            }

            public static bool Update(User userToSave)
            {
                int numberOfUpdatedRecords = 0;

                using (var db = new BlogAPIDbContext())
                {
                    var searchResults = db.Users.Where(u => u.UserID == userToSave.UserID);

                    if (searchResults.Any())
                    {
                        User userFromDB = searchResults.First();

                        userFromDB.Password = userToSave.Password;

                        numberOfUpdatedRecords = db.SaveChanges();
                    }
                }

                return numberOfUpdatedRecords > 0;
            }
        }
    }


}