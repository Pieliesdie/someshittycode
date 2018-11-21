using Common;
using System.Collections.Generic;

namespace DAL
{
    public interface IMemory
    {
        int? AddUser(Users user, IEnumerable<int> rewardIds);
        bool UpdateUser(Users user);
        bool UpdateReward(Rewards reward);
        bool AddReward(Rewards reward);
        bool DeleteReward(int id);
        bool AddRewardToUser(int id, IEnumerable<int> rewardIds);
        bool DeleteRewardFromUser(int id, int rewardId);
        List<Users> GetUsers();
        List<Rewards> GetUserRewardsByID(int id);
        List<Rewards> GetRewards();
        bool DeleteUser(int id);
    }
}
