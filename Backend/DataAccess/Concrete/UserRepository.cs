using DataAccess.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public MyAppDbContext _context;

        public UserRepository()
        {
            _context = new MyAppDbContext();
        }

        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void DeleteUser(int id) 
        {
            var deletedUser = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            _context.Users.Remove(deletedUser);
            _context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public List<User> GetUserById(int userId)
        {
            return _context.Users.Where(x => x.Id == userId).ToList();
        }

        public User UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
