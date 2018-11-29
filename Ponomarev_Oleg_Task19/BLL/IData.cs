using Common;
using System.Collections.Generic;

namespace BLL
{
    public interface IData
    {
        int? AddUser(User user,IEnumerable<int> rewardIds);
        bool UpdateUser(User user);
        bool UpdateReward(Reward reward);
        bool AddReward(Reward reward);
        bool DeleteReward(int id);
        bool AddRewardToUser(int id, IEnumerable<int> rewardIds);
        bool DeleteRewardFromUser(int id, int rewardId);
        SortableList<User> GetUsers();
        SortableList<Reward> GetUserRewardsByID(int id);
        SortableList<Reward> GetRewards();
        bool DeleteUser(int id);
    }
}
