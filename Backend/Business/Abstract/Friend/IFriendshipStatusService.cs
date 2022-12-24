using Models.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Friend
{
    public interface IFriendshipStatusService
    {
        public List<FriendshipStatus> GetFriendshipStatuses();
        public List<FriendshipStatus> GetFriendshipStatusById(int friendshipStatusId);
        public FriendshipStatus CreateFriendshipStatus(FriendshipStatus friendshipStatus);
        FriendshipStatus UpdateFriendshipStatus(FriendshipStatus friendshipStatus);
        public void DeleteFriendshipStatus(int id);
    }
}
