using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _repository;
        public UserManager()
        {
            _repository = new UserRepository();
        }

        public User CreateUser(User user)
        {
            return _repository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            _repository.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public List<User> GetUserById(int userId)
        {
            return _repository.GetUserById(userId);
        }

        public User UpdateUser(User user)
        {
            return _repository.UpdateUser(user);
        }
    }
}
