using DataAccess.Abstract.Friend;
using Models.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Friend
{
    public class FriendshipStatusRepository : IFriendshipStatusRepository
    {
        public MyAppDbContext _context;

        public FriendshipStatusRepository()
        {
            _context = new MyAppDbContext();
        }

        public FriendshipStatus CreateFriendshipStatus(FriendshipStatus friendshipStatus)
        {
            _context.FriendshipStatuses.Add(friendshipStatus);
            _context.SaveChanges();
            return friendshipStatus;
        }

        public void DeleteFriendshipStatus(int id)
        {
            var deletedItem = _context.FriendshipStatuses.Where(x => x.Id == id).FirstOrDefault();
            _context.FriendshipStatuses.Remove(deletedItem);
            _context.SaveChanges();
        }

        public List<FriendshipStatus> GetFriendshipStatusById(int friendshipStatusId)
        {
            return _context.FriendshipStatuses.Where(x => x.Id == friendshipStatusId).ToList();
        }

        public List<FriendshipStatus> GetFriendshipStatuses()
        {
            return _context.FriendshipStatuses.ToList();
        }

        public FriendshipStatus UpdateFriendshipStatus(FriendshipStatus friendshipStatus)
        {
            _context.FriendshipStatuses.Update(friendshipStatus);
            _context.SaveChanges();
            return friendshipStatus;
        }
    }
}
