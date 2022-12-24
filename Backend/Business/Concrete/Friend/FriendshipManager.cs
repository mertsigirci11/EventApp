using Business.Abstract.Friend;
using DataAccess.Abstract.Friend;
using DataAccess.Concrete.Friend;
using Models.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Friend
{
    public class FriendshipManager : IFriendshipService
    {
        private IFriendshipRepository _repository;
        public FriendshipManager()
        {
            _repository = new FriendshipRepository();
        }

        public Friendship CreateFriendship(Friendship friendship)
        {
            return _repository.CreateFriendship(friendship);
        }

        public void DeleteFriendship(int id)
        {
            _repository.DeleteFriendship(id);
        }

        public List<Friendship> GetFriendshipById(int friendshipId)
        {
            return _repository.GetFriendshipById(friendshipId);
        }

        public List<Friendship> GetFriendships()
        {
            return _repository.GetFriendships();
        }

        public Friendship UpdateFriendship(Friendship friendship)
        {
            return _repository.UpdateFriendship(friendship);
        }
    }
}
