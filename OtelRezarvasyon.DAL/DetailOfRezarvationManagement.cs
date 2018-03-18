using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DAL
{
  public  class DetailOfRezarvationManagement : IRepository<DetailOfRezervation, Int32>
    {//o 
        public DetailOfRezervation Get(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from DetailOfRezarvation where RezervationId={0}", id), SqlHelper.Cnn);

            DetailOfRezervation rezarvationDetail = new DetailOfRezervation();

            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        rezarvationDetail.RezervationId =(int) datarReader["RezervationId"];
                        rezarvationDetail.CustomerId =(int) datarReader["CustomerId"];
                        rezarvationDetail.RoomId = (int)datarReader["RoomId"];

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
            return rezarvationDetail;
        }

        public List<DetailOfRezervation> GetAll()
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from DetailOfRezarvation"),SqlHelper.Cnn);

            List<DetailOfRezervation> rezervationDetailList = new  List<DetailOfRezervation>();

            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        DetailOfRezervation rezervationDetail = new DetailOfRezervation();
                        rezervationDetail.RezervationId = (int)datarReader["RezervationId"];
                        rezervationDetail.CustomerId = (int)datarReader["CustomerId"];
                        rezervationDetail.RoomId = (int)datarReader["RoomId"];

                        rezervationDetailList.Add(rezervationDetail);
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
            return rezervationDetailList;
        }

        public int Insert(DetailOfRezervation rezarvationDetail)
        {
            SqlCommand cmd = new SqlCommand("Insert Into DetailOfRezarvation (RezervationId,CustomerId,RoomId,IsActive)Values(@RezervationId,@CustomerId,@RoomId,@IsActive)", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@RezervationId", rezarvationDetail.RezervationId);
            cmd.Parameters.AddWithValue("@CustomerId", rezarvationDetail.CustomerId);
            cmd.Parameters.AddWithValue("@RoomId", rezarvationDetail.RoomId);
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

        public int IsActiveSituation(DetailOfRezervation detailRezervation)
        {
            SqlCommand cmd = new SqlCommand("Update DetailORezervation set IsActive=@IsActive where CustomerId=@CustomerId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerId", detailRezervation.CustomerId);
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

        public int Update(DetailOfRezervation rezervationDetail)
        {
            SqlCommand cmd = new SqlCommand("Update DetailOfRezarvation RezervationId=@RezervationId,CustomerId=@CustomerId,RoomId=@RoomId,IsActive=@IsActive", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@RezervationId", rezervationDetail.RezervationId);
            cmd.Parameters.AddWithValue("@CustomerId", rezervationDetail.CustomerId);
            cmd.Parameters.AddWithValue("@RoomId", rezervationDetail.RoomId);
            cmd.Parameters.AddWithValue("@IsActive", rezervationDetail.IsActive);
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
