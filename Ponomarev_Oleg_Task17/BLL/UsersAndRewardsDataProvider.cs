using System.Collections.Generic;
using Common;
using DAL;


namespace BLL
{
    public class UsersAndRewardsDataProvider : IData
    {
        IMemory memory { get; set; }

        public enum MemoryType
        {
            DataBase,
            Memory
        }

        public UsersAndRewardsDataProvider(MemoryType type)
        {
            switch (type)
            {
                case MemoryType.DataBase:
                    {
                        memory = new DataBaseUserAndReward();
                        break;
                    }
                case MemoryType.Memory:
                    {
                        memory = new UserAndRewardList();
                        break;
                    }
            }
        }

        public int? AddUser(Users user,IEnumerable<int> rewardIds)
        {
            try
            {
                return memory.AddUser(user, rewardIds);
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateUser(Users user)
        {
            try
            {
                return memory.UpdateUser(user);
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateReward(Rewards reward)
        {
            try
            {
                return memory.UpdateReward(reward);
            }
            catch
            {
                return false;
            }
        }

        public bool AddReward(Rewards reward)
        {
            try
            {
                return memory.AddReward(reward);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteReward(int id)
        {
            try
            {
                return memory.DeleteReward(id);
            }
            catch
            {
                return false;
            }
        }

        public bool AddRewardToUser(int id, IEnumerable<int> rewardIds)
        {
            try
            {
                return memory.AddRewardToUser(id, rewardIds);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteRewardFromUser(int id, int rewardId)
        {
            try
            {
                return memory.DeleteRewardFromUser(id, rewardId);
            }
            catch
            {
                return false;
            }
        }

        public SortableList<Users> GetUsers()
        {
            try
            {
                return new SortableList<Users>(memory.GetUsers());
            }
            catch
            {
                return null;
            }
        }

        public SortableList<Rewards> GetUserRewardsByID(int id)
        {
            try
            {
                return new SortableList<Rewards>(memory.GetUserRewardsByID(id));
            }
            catch { return null; }
        }

        public SortableList<Rewards> GetRewards()
        {
            try
            {
                return new SortableList<Rewards>(memory.GetRewards());
            }
            catch { return null; }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                return memory.DeleteUser(id);
            }
            catch { return false; }
        }
    }
}
