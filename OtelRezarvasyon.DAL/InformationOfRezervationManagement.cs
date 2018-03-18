using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DAL
{
 public   class InformationOfRezervationManagement :IRepository<InformationOfRezervation, Int32>
    {
        public InformationOfRezervation Get(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from InformationOfRezervation where RezarvationId={0}", id), SqlHelper.Cnn);
            InformationOfRezervation informationRezarvation = new InformationOfRezervation();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        
                        informationRezarvation.RezervationId = (int)datarReader["RezervationId"];
                        informationRezarvation.CustomerId = (int)datarReader["CustomerId"];
                        informationRezarvation.EnteringDate = (DateTime)datarReader["EnteringDate"];
                        informationRezarvation.LeavingDate = (DateTime)datarReader["LeavingDate"];
                        informationRezarvation.MoneyCost = (decimal)datarReader["MoneyCost"];
                        informationRezarvation.IsActive = (bool)datarReader["IsActive"];
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
            return informationRezarvation;
        }

        public List<InformationOfRezervation> GetAll()
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from InformationOfRezarvation"), SqlHelper.Cnn);
            List<InformationOfRezervation> rezervationList = new List<InformationOfRezervation>();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        InformationOfRezervation informationRezarvation = new InformationOfRezervation();
                        informationRezarvation.RezervationId = (int)datarReader["RezervationId"];
                        informationRezarvation.CustomerId = (int)datarReader["CustomerId"];
                        informationRezarvation.EnteringDate =(DateTime)datarReader["EnteringDate"];
                        informationRezarvation.LeavingDate = (DateTime)datarReader["LeavingDate"];
                        informationRezarvation.MoneyCost = (decimal)datarReader["MoneyCost"];
                        informationRezarvation.IsActive = (bool)datarReader["IsActive"];
                    }
                }
            }
            catch (Exception e)
            {

                throw;
                //return-1
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return rezervationList;
        }

        public int Insert(InformationOfRezervation inforezervation)
        {
            SqlCommand cmd = new SqlCommand("Insert Into InformationOfRezervation(RezervationId,CustomerId,EnteringDate,LeavingDate,MoneyCost,IsActive)Values(@RezervationId,@CustomerId,@EnteringDate,@LeavingDate,@MoneyCost,@IsActive)", SqlHelper.Cnn);

            cmd.Parameters.AddWithValue("@RezervationId", inforezervation.RezervationId);
            cmd.Parameters.AddWithValue("@CustomerId", inforezervation.CustomerId);
            cmd.Parameters.AddWithValue("EnteringDate", inforezervation.EnteringDate);
            cmd.Parameters.AddWithValue("LeavingDate", inforezervation.LeavingDate);
            cmd.Parameters.AddWithValue("MoneyCost", inforezervation.MoneyCost);
            cmd.Parameters.AddWithValue("IsActive", "true");

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

        public int IsActiveSituation(InformationOfRezervation informationOfRezervation)
        {
            SqlCommand cmd = new SqlCommand("Update informationOfRezervation set IsActive=@IsActive where CustomerId=@CustomerId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerId", informationOfRezervation.CustomerId);
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

        public int Update(InformationOfRezervation inforezervation)
        {
            SqlCommand cmd = new SqlCommand("Update InformationOfRezervation set RezervationId=@RezervationId,CustomerId=@CustomerId,EnteringDate=@EnteringDate,LeavingDate=@LeavingDateMoneyCost=@MoneyCost,IsActive=@IsActive", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@RezervationId", inforezervation.RezervationId);
            cmd.Parameters.AddWithValue("@CustomerId", inforezervation.CustomerId);
            cmd.Parameters.AddWithValue("@EnteringDate", inforezervation.EnteringDate);
            cmd.Parameters.AddWithValue("@LeavingDate", inforezervation.LeavingDate);
            cmd.Parameters.AddWithValue("@MoneyCost", inforezervation.MoneyCost);
            cmd.Parameters.AddWithValue("@IsActive", inforezervation.MoneyCost);

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
