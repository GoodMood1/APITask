using BlogsAPI.Models.DTO.User;
using BlogsAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogsAPI.Controllers
{
    public class UsersController : ApiController
    {
        private UserService _userService = new UserService();

        // GET: api/Users
        public IEnumerable<GetUserDTO> Get()
        {
            return _userService.GetAll();
        }

        // GET: api/Users/5
        public GetUserDTO Get(int id)
        {
            return _userService.GetByID(id);
        }

        // POST: api/Users
        public GetUserDTO Post([FromBody] AddUserDTO userToAdd)
        {
             return _userService.Create(userToAdd);
        }

        // PUT: api/Users/
        public bool Put([FromBody] EditUserDTO userToUpdate)
        {
            return _userService.Update(userToUpdate);
        }

        // DELETE: api/Users/5
        public bool Delete(int id)
        {
            return _userService.DeleteByID(id);
        }
    }
}
