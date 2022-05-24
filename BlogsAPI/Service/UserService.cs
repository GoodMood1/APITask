using BlogsAPI.Models.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogsAPI.Models.Entities;
using BlogsAPI.Tools;
using BlogsAPI.Models.DAL;

using Mapster;

namespace BlogsAPI.Service
{
    public class UserService
    {
        public GetUserDTO Create(AddUserDTO addUserDTO)
        {
            User newUser = addUserDTO.Adapt<User>();
            newUser.Password = Hash.CreateHash_SHA512(addUserDTO.PasswordText);

            User addedUser = DAL.Users.Add(newUser);

            return addedUser.Adapt<GetUserDTO>();
        }

        public List<GetUserDTO> GetAll()
        {
            List<User> allUsers = DAL.Users.All();

            return allUsers.Adapt<List<GetUserDTO>>();
        }

        public GetUserDTO GetByID(int userID)
        {
            User userByID = DAL.Users.ByID(userID);
            
            if(userByID == null)
                userByID = new User();

            return userByID.Adapt<GetUserDTO>();
        }

        public bool DeleteByID(int userID)
        {
            return DAL.Users.DeleteByID(userID);
        }

        public bool Update(EditUserDTO userToUpdate)
        {
            User userToSave = userToUpdate.Adapt<User>();

            userToSave.Password = Hash.CreateHash_SHA512(userToUpdate.NewPassword);

            bool saveResult = DAL.Users.Update(userToSave);

            return saveResult;
        }
    }
}