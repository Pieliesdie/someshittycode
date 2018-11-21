using Common;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UserAndRewardList : IMemory
    { 
        class UsersAndRewards
        {
            public int UserId;
            public int RewardId;
        }

        private static int UserId;
        private static int RewardId;
        private static List<UsersAndRewards> usersAndRewards = new List<UsersAndRewards>();
        private static List<Users> users = new List<Users>();
        private static List<Rewards> rewards = new List<Rewards>();

        public bool DeleteRewardFromUser(int id, int rewardId)
        {
            return usersAndRewards.Remove(usersAndRewards.Find(x => x.UserId == id && x.RewardId == rewardId));
        }

        public bool AddRewardToUser(int id, IEnumerable<int> rewardIds)
        {
            foreach (int i in rewardIds)
            {
                if (rewards.Find(x => x.ID == i) == null)
                {
                    return false;
                }
                if (usersAndRewards.Find(x => x.UserId == id && x.RewardId == i) != null)
                {
                    return false;
                }
            }
            foreach (int i in rewardIds)
            {
                usersAndRewards.Add(new UsersAndRewards() { UserId = id, RewardId = i });
            }
            return true;
        }

        public bool DeleteReward(int id)
        {
            rewards.Remove(rewards.Find(x => x.ID == id));
            usersAndRewards.RemoveAll(x => x.RewardId == id);
            return true;
        }

        public bool AddReward(Rewards reward)
        {
            rewards.Add(new Rewards()
            {
                ID = RewardId++,
                Title = reward.Title,
                Decription = reward.Decription
            });
            return true;
        }

        public bool UpdateReward(Rewards reward)
        {
            var _reward = rewards.Find(x => x.ID == reward.ID);
            _reward.Title = reward.Title;
            _reward.Decription = reward.Decription;
            return true;
        }

        public bool UpdateUser(Users user)
        {
            var _user = users.Find(x => x.ID == user.ID);
            _user.FirstName = user.FirstName;
            _user.LastName = user.LastName;
            _user.Birthday = user.Birthday;
            return true;
        }

        public int? AddUser(Users user, IEnumerable<int> rewardIds)
        {
            users.Add(new Users()
            {
                ID = UserId++,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Birthday = user.Birthday
            });
            AddRewardToUser(UserId - 1, rewardIds);
            return UserId-1;
        }

        public bool DeleteUser(int id)
        {
            users.Remove(users.Find(x => x.ID == id));
            usersAndRewards.RemoveAll(x=>x.UserId==id);
            return true;
        }

        public List<Rewards> GetRewards()
        {
            return rewards;
        }

        public List<Rewards> GetUserRewardsByID(int id)
        {
            var _rewards = usersAndRewards.Join(rewards,
                p => p.RewardId,
                t => t.ID,
                (p, t) => new Rewards() { ID = p.RewardId, Title = t.Title, Decription = t.Decription });
            return _rewards.ToList();
        }

        public List<Users> GetUsers()
        {
            return users;
        }
    }
}
