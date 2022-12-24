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
    public class FriendshipStatusManager : IFriendshipStatusService
    {
        private IFriendshipStatusRepository _repository;
        public FriendshipStatusManager()
        {
            _repository = new FriendshipStatusRepository();
        }

        public FriendshipStatus CreateFriendshipStatus(FriendshipStatus friendshipStatus)
        {
            return _repository.CreateFriendshipStatus(friendshipStatus);
        }

        public void DeleteFriendshipStatus(int id)
        {
            _repository.DeleteFriendshipStatus(id);
        }

        public List<FriendshipStatus> GetFriendshipStatusById(int friendshipStatusId)
        {
            return _repository.GetFriendshipStatusById(friendshipStatusId);
        }

        public List<FriendshipStatus> GetFriendshipStatuses()
        {
            return _repository.GetFriendshipStatuses();
        }

        public FriendshipStatus UpdateFriendshipStatus(FriendshipStatus friendshipStatus)
        {
            return _repository.UpdateFriendshipStatus(friendshipStatus);
        }
    }
}
