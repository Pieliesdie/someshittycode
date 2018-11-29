using Common;
using System.Collections.Generic;

namespace DAL
{
    public interface IMemory
    {
        int? AddUser(User user, IEnumerable<int> rewardIds);
        bool UpdateUser(User user);
        bool UpdateReward(Reward reward);
        bool AddReward(Reward reward);
        bool DeleteReward(int id);
        bool AddRewardToUser(int id, IEnumerable<int> rewardIds);
        bool DeleteRewardFromUser(int id, int rewardId);
        List<User> GetUsers();
        List<Reward> GetUserRewardsByID(int id);
        List<Reward> GetRewards();
        bool DeleteUser(int id);
    }
}
