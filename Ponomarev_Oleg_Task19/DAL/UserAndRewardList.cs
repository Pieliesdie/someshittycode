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
        private static List<User> users = new List<User>();
        private static List<Reward> rewards = new List<Reward>();

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

        public bool AddReward(Reward reward)
        {
            rewards.Add(new Reward()
            {
                ID = RewardId++,
                Title = reward.Title,
                Decription = reward.Decription
            });
            return true;
        }

        public bool UpdateReward(Reward reward)
        {
            var _reward = rewards.Find(x => x.ID == reward.ID);
            _reward.Title = reward.Title;
            _reward.Decription = reward.Decription;
            return true;
        }

        public bool UpdateUser(User user)
        {
            var _user = users.Find(x => x.ID == user.ID);
            _user.FirstName = user.FirstName;
            _user.LastName = user.LastName;
            _user.Birthday = user.Birthday;
            return true;
        }

        public int? AddUser(User user, IEnumerable<int> rewardIds)
        {
            users.Add(new User()
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

        public List<Reward> GetRewards()
        {
            return rewards;
        }

        public List<Reward> GetUserRewardsByID(int id)
        {
            var _rewards = usersAndRewards.Join(rewards,
                p => p.RewardId,
                t => t.ID,
                (p, t) => new Reward() { ID = p.RewardId, Title = t.Title, Decription = t.Decription });
            return _rewards.ToList();
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}
