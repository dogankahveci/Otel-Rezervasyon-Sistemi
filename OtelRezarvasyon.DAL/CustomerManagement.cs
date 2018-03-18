using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DAL
{
   public class CustomerManagement : IRepository<Customer, Int32>
    {
        public Customer Get(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from Customer where CustomerID={0}", id), SqlHelper.Cnn);
            Customer customer = new Customer();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();
               
                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                       
                        customer.CustomerId = (int)datarReader["CustomerId"];
                        customer.CustomerName = (string)datarReader["CustomerName"];
                        customer.CustomerLastName =(string)datarReader["CustomerLastName"];
                        customer.IdentityNumber =(string)datarReader["IdentityNumber"];
                        customer.Gender = (string)datarReader["Gender"];
                        customer.IsActive = (bool)datarReader["IsActive"];
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return customer;
            
        }


        public List<Customer> GetAll()
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from Customer"),SqlHelper.Cnn);
            List<Customer> CustomerList = new List<Customer>();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerId = (int)datarReader["CustomerId"];
                        customer.CustomerName = (string)datarReader["CustomerName"];
                        customer.CustomerLastName = (string)datarReader["CustomerLastName"];
                        customer.IdentityNumber = (string)datarReader["IdentityNumber"];
                        customer.Gender = (string)datarReader["Gender"];
                        customer.IsActive = (bool)datarReader["IsActive"];

                        CustomerList.Add(customer);
                    }
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return CustomerList;
        }

        public int Insert(Customer customer)
        {
            int ID = 0;
            
            SqlCommand cmd = new SqlCommand("Insert Into Customer (CustomerName,CustomerLastName,IdentityNumber,Gender,IsActive)Values(@CustomerName,@CustomerLastName,@IdentityNumber,@Gender,@IsActive) Select SCOPE_IDENTITY()", SqlHelper.Cnn);


            //cmd.Parameters.Add("CustomerId")
            cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerLastName",customer.CustomerLastName);
            cmd.Parameters.AddWithValue("@IdentityNumber",customer.IdentityNumber);
            cmd.Parameters.AddWithValue("@Gender", customer.Gender);
            cmd.Parameters.AddWithValue("@IsActive", "true");
            try
            {
                SqlHelper.Cnn.Open();
                ID = Convert.ToInt32(cmd.ExecuteScalar());
               
              
            }
            catch (Exception)
            {
                
                throw;//veritabanındaki veri tipinden fazla karakter gikrdi  evet ama bunu olmadan engellemen lazım. onun için ui da kısıtlayacaksın kullanıcıyı. muhtemelen telefon numarasında patladı..Dogru telefon için ve mail için regex kullanmalısın. aynı zamanda keypress sırasında telefon alanında parantez,sayı,boşluk ve  + dışında bir girişi engelleyeceksin.Tamam tek tek koşul olarak yazmam lazım heralde keypress te girişecek karakterleri engelleyebilirsin. ama onun bir telefon numarası olduğunu teyit etmen lazım. buradada kaydet butonuna basıldığında arka planda onun telefon olup olmadığını teyit eden bir regex kontrolu olmalıdır. regex nedir :D 
                //return-1
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return ID;
        }

        public int Update(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("Update Customer set CustomerName=@CustomerName,CustomerLastName=@CustomerLastName,IdentityNumber=@IdentityNumber,IsActive=@IsActive where CustomerId=@CustomerId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
            cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerLastName", customer.CustomerName);
            cmd.Parameters.AddWithValue("@IdentityNumber", customer.IdentityNumber);
            cmd.Parameters.AddWithValue("IsActive","false");
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

        public int IsActiveSituation(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("Update Customer set IsActive=@IsActive where CustomerId=@CustomerId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerId",customer.CustomerId);
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

      


    }
}
