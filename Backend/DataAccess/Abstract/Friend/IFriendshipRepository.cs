using Models.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Friend
{
    public interface IFriendshipRepository
    {
        public List<Friendship> GetFriendships();
        public List<Friendship> GetFriendshipById(int friendshipId);
        public Friendship CreateFriendship(Friendship friendship);
        Friendship UpdateFriendship(Friendship friendship);
        public void DeleteFriendship(int id);
    }
}
