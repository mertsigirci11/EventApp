using DataAccess.Abstract.Friend;
using Models.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Friend
{
    public class FriendshipRepository : IFriendshipRepository
    {
        public MyAppDbContext _context;

        public FriendshipRepository()
        {
            _context = new MyAppDbContext();
        }

        public Friendship CreateFriendship(Friendship friendship)
        {
            _context.Friendships.Add(friendship);
            _context.SaveChanges();
            return friendship;
        }

        public void DeleteFriendship(int id)
        {
            var deletedItem = _context.Friendships.Where(x => x.Id == id).FirstOrDefault();
            _context.Friendships.Remove(deletedItem);
            _context.SaveChanges();
        }

        public List<Friendship> GetFriendshipById(int friendshipId)
        {
            return _context.Friendships.Where(x => x.Id == friendshipId).ToList();
        }

        public List<Friendship> GetFriendships()
        {
            return _context.Friendships.ToList();
        }

        public Friendship UpdateFriendship(Friendship friendship)
        {
            _context.Friendships.Update(friendship);
            _context.SaveChanges();
            return friendship;
        }
    }
}
