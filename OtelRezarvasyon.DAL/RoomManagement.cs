using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DAL
{
    public class RoomManagement : IRepository<Room, Int32>
    {
        public Room Get(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from Room where RoomId={0}", id), SqlHelper.Cnn);
            Room room = new Room();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        room.RoomId = (int)datarReader["RoomId"];
                        room.RoomNumber = (string)datarReader["RoomNumber"];
                        room.RoomCost = (int)datarReader["RoomCost"];
                        room.IsActive = (bool)datarReader["IsActive"];
                        room.Capacity = (byte)datarReader["Capacity"];


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
            return room;
        }

        public List<Room> GetAll()
        {
            SqlCommand cmd = new SqlCommand("select * from Room", SqlHelper.Cnn);
            List<Room> RoomList = new List<Room>();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        Room room = new Room();
                        room.RoomId = (int)datarReader["RoomId"];
                        room.RoomNumber = (string)datarReader["RoomNumber"];
                        room.RoomCost = (decimal)datarReader["RoomCost"];
                        room.IsActive = (bool)datarReader["IsActive"];
                        room.Capacity = (byte)datarReader["Capacity"];


                        RoomList.Add(room);

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
                //return-1
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return RoomList;
        }

        public int Insert(Room room)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Room (RoomNumber,RoomCost,Capacity,IsActive)Values(@RoomNumber,@RoomCost,@Capacity,@IsActive)", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@RoomNumber",room.RoomNumber);
            cmd.Parameters.AddWithValue("@RoomCost", room.RoomCost);
            cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
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

        public int IsActiveSituation(Room room)
        {
            SqlCommand cmd = new SqlCommand("Update room set IsActive=@IsActive where RoomId=@RoomId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@RoomId", room.RoomId);
            cmd.Parameters.AddWithValue("IsActive", "false");
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

        public int Update(Room room)
        {

            SqlCommand cmd = new SqlCommand("Update Room set RoomNumber=@RoomNumber,RoomCost=@RoomCost,Capacity=@Capacity,IsActive=@IsActive Where RoomId=@RoomId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@RoomId",room.RoomId);
            cmd.Parameters.AddWithValue("@RoomNumber",room.RoomNumber);
            cmd.Parameters.AddWithValue("@RoomCost", room.RoomCost);
            cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
            cmd.Parameters.AddWithValue("@IsActive", room.IsActive);

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

