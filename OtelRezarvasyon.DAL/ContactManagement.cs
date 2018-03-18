using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DAL
{
    public class ContactManagement : IRepository<Contact, Int32>
    {
        public Contact Get(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from Contact where CustomerId={0}", id), SqlHelper.Cnn);
            Contact contact = new Contact();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        contact.ContactId = (int)datarReader["ContactId"];
                        contact.CustomerId = (int)datarReader["CustomerId"];
                        contact.Adress = (string)datarReader["Adress"];
                        contact.Tel = (string)datarReader["Tel"];
                        contact.Email = (string)datarReader["Email"];
                        contact.IsActive = (bool)datarReader["IsActive"];

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
            return contact;
        }

        public List<Contact> GetAll()
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from Contact"), SqlHelper.Cnn);
            List<Contact> ContactList = new List<Contact>();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        Contact contact = new Contact();
                        contact.ContactId = (int)datarReader["ContactId"];
                        contact.CustomerId = (int)datarReader["CustomerId"];
                        contact.Adress = (string)datarReader["Adress"];
                        contact.Tel = (string)datarReader["Tel"];
                        contact.Email = (string)datarReader["Email"];
                        contact.IsActive = (bool)datarReader["IsActive"];

                        ContactList.Add(contact);
                    }

                }
            }

            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return ContactList;
        }

        public List<Contact> GetByCustomerId(int id) 
        {
            SqlCommand cmd = new SqlCommand(string.Format("select * from Contact where CustomerId={0}", id), SqlHelper.Cnn);
            List<Contact> ContactList = new List<Contact>();
            try
            {
                SqlHelper.Cnn.Open();
                SqlDataReader datarReader = cmd.ExecuteReader();

                if (datarReader.HasRows)
                {
                    while (datarReader.Read())
                    {
                        Contact contact = new Contact();
                        contact.ContactId = (int)datarReader["ContactId"];
                        contact.CustomerId = (int)datarReader["CustomerId"];
                        contact.Adress = (string)datarReader["Adress"];
                        contact.Tel = (string)datarReader["Tel"];
                        contact.Email = (string)datarReader["Email"];
                        contact.IsActive = (bool)datarReader["IsActive"];

                        ContactList.Add(contact);
                    }

                }
            }

            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
            return ContactList;
        }

        public int Insert(Contact contact)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Contact (CustomerId,Adress,Email,Tel,IsActive) Values(@CustomerId,@Adress,@Email,@Tel,@IsActive)", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerId", contact.CustomerId);
            cmd.Parameters.AddWithValue("@Adress", contact.Adress);
            cmd.Parameters.AddWithValue("@Email", contact.Email);
            cmd.Parameters.AddWithValue("@Tel", contact.Tel);
            cmd.Parameters.AddWithValue("@IsActive", "true");
            try
            {
                SqlHelper.Cnn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                // throw;
                return -1;
            }
            finally
            {
                SqlHelper.Cnn.Close();
            }
        }

        public int Update(Contact contact)
        {
            SqlCommand cmd = new SqlCommand("Update Contact set Adress=@Adress,Email=@Email,Tel=@Tel where CustomerId=@CustomerId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@CustomerId", contact.CustomerId);
            cmd.Parameters.AddWithValue("@Adress", contact.Adress);
            cmd.Parameters.AddWithValue("@Tel", contact.Tel);
            cmd.Parameters.AddWithValue("@Email", contact.Email);
            //cmd.Parameters.AddWithValue("@IsActive", "false");
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
        public int IsActiveSituation(Contact contact)
        {
            SqlCommand cmd = new SqlCommand("Update Contact set IsActive=@IsActive where ContactId = @ContactId", SqlHelper.Cnn);
            cmd.Parameters.AddWithValue("@ContactId",contact.ContactId);
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
