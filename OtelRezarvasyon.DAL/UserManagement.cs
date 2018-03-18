using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DAL
{
    public class UserManagement : IRepository<User, Int32>
    {
        public User Get(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from User where UserId={0}", id), SqlHelper.Cnn);
            User user = new User();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {

                        user.UserId= (int)datarReader["UserID"];
                        user.CustomerId= (int)datarReader["CustomerID"];
                        user.UserName = (string)datarReader["UserName"];
                        user.Password = (short)datarReader["Password"];
                        user.IsActive = (bool)datarReader["IsActive"];

                    }
                }
            }
            catch (Exception)
            {

                throw;
                //return-1
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return user;
        }

        public List<User> GetAll()
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from User"), SqlHelper.Cnn);

            List<User> UserList = new List<User>();

            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        User user = new User();
                        user.UserId= (int)datarReader["UserID"];
                        user.CustomerId= (int)datarReader["CustomerID"];
                        user.UserName = (string)datarReader["UserName"];
                        user.Password = (short)datarReader["Password"];
                        user.IsActive = (bool)datarReader["IsActive"];
                        UserList.Add(user);
                    }
                }
            }
            catch (Exception)
            {

                throw;
                //return-1
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return UserList;
        }

        public int Insert(User user)
        {
            SqlCommand cmd = new SqlCommand("Insert Into User(CustomerID,UserName,Password,IsActive)Values(@CustomerID,@CustomerName,@UserName,@Password,@IsActive)", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerID", user.CustomerId);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@IsActive", "true");

            try
            {
                SqlHelper.Cnn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
                //return-1
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
        }

        public int IsActiveSituation(User user)
        {
            SqlCommand cmd = new SqlCommand("Update Customer set IsActive=@IsActive where CustomerId=@CustomerId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerId", user.CustomerId);
            cmd.Parameters.AddWithValue("@IsActive", "false");
            try
            {
                SqlHelper.Cnn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
                //return-1
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
        }

        public int Update(User user)
        {
            SqlCommand cmd = new SqlCommand("Update User CustomerID=@CustomerID,UserName=@UserName,Password=@Password,IsActive=@IsActive)", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerID",user.CustomerId);
            cmd.Parameters.AddWithValue("@UserName",user.UserName);
            cmd.Parameters.AddWithValue("@Password",user.Password);
            cmd.Parameters.AddWithValue("@IsActive",user.IsActive);
                                                                 
            try
            {
                SqlHelper.Cnn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
                //return-1
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
        }
        
    }
}


