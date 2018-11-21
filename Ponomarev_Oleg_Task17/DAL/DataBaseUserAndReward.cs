using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataBaseUserAndReward : IMemory
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public bool DeleteRewardFromUser(int id,int rewardId)
        {
            int result=0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("DeleteRewardFromUser", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@RewardId", rewardId);
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }
            return result > 0 ? true : false;
        }

        public bool AddRewardToUser(int id, IEnumerable<int> rewardIds)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable myDataTable = new DataTable();
                myDataTable.Columns.Add("id",typeof(Int32));
                foreach (int i in rewardIds)
                {
                    myDataTable.Rows.Add(i);
                }

                SqlParameter parameter = new SqlParameter();
                parameter.TypeName = "AwardsIds";
                parameter.SqlDbType = System.Data.SqlDbType.Structured;
                parameter.Value = myDataTable;
                parameter.ParameterName = "@awardIds";

                using (SqlCommand command = new SqlCommand("AddUserRewards", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.Add(parameter);
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }
            return result > 0 ? true : false;
        }

        public bool DeleteReward(int id)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("DeleteReward", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }
            return result > 0 ? true : false;
        }

        public bool AddReward(Rewards reward)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("InsertReward", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@title", reward.Title);
                    command.Parameters.AddWithValue("@decription", reward.Decription);
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }
            return result > 0 ? true : false;
        }

        public bool UpdateReward(Rewards reward)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("UpdateReward", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", reward.ID);
                    command.Parameters.AddWithValue("@title", reward.Title);
                    command.Parameters.AddWithValue("@decription", reward.Decription);
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }
            return result > 0 ? true : false;
        }

        public bool UpdateUser(Users user)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("UpdateUser", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", user.ID);
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@birthdate", user.Birthday);
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }
            return result > 0 ? true : false;
        }

        public int? AddUser(Users user, IEnumerable<int> rewardIds)
        {
            int? result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("InsertUser", connection))
                {
                    DataTable myDataTable = new DataTable();
                    myDataTable.Columns.Add("id", typeof(Int32));
                    foreach (int i in rewardIds)
                    {
                        myDataTable.Rows.Add(i);
                    }

                    SqlParameter parameter = new SqlParameter();
                    parameter.TypeName = "AwardsIds";
                    parameter.SqlDbType = System.Data.SqlDbType.Structured;
                    parameter.Value = myDataTable;
                    parameter.ParameterName = "@awardIds";

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@birthdate", user.Birthday);
                    command.Parameters.Add(parameter);
                    connection.Open();
                    result = (int)command.ExecuteScalar();
                }
            }
            return result;
        }

        public bool DeleteUser(int id)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("DeleteUser", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userid", id);
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
            }
            return result > 0 ? true : false;
        }

        public List<Rewards> GetRewards()
        {
            List<Rewards> rewards = new List<Rewards>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetRewards", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    using (var result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Rewards tmp = new Rewards()
                                {
                                    ID = result.GetInt32(0),
                                    Title = result.GetString(1),
                                    Decription = result.GetString(2)
                                };
                                rewards.Add(tmp);
                            }
                        }
                    }
                }
                return rewards;
            }
        }

        public List<Rewards> GetUserRewardsByID(int id)
        {
            List<Rewards> rewards = new List<Rewards>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetUserRewards", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userid", id);
                    connection.Open();
                    using (var result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Rewards tmp = new Rewards()
                                {
                                    ID = result.GetInt32(0),
                                    Title = result.GetString(1),
                                    Decription = result.GetString(2)
                                };
                                rewards.Add(tmp);
                            }
                        }
                    }
                }
                return rewards;
            }
        }

        public List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetUsers", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    using (var result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Users tmp = new Users()
                                {
                                    ID = result.GetInt32(0),
                                    FirstName = result.GetString(1),
                                    LastName = result.GetString(2),
                                    Birthday = result.GetDateTime(3)
                                };
                                users.Add(tmp);
                            }
                        }
                    }
                }
                return users;
            }
        }
    }
}
