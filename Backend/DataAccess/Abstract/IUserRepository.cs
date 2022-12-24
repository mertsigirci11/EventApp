using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserRepository
    {
        public List<User> GetAllUsers();
        public List<User> GetUserById(int userId);
        public User CreateUser(User user);
        User UpdateUser(User user);
        public void DeleteUser(int id);
    }
}
