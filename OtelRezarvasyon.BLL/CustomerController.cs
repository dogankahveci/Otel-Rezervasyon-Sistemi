using OtelRezarvasyon.DAL;
using OtelRezarvasyon.DTO;
using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OtelRezarvasyon.BLL
{
    public class CustomerController
    {
        CustomerManagement _cm;
        Mesaj mesaj = new Mesaj();
        public CustomerController()
        {
            _cm = new CustomerManagement();
        }

        public Customer Get(int id)
        {
            return _cm.Get(id);
        }

        public List<Customer> GetAll()
        {
            return _cm.GetAll();
        }

        public List<Customer> GetAllByIsActive()
        {
            return _cm.GetAll().Where(x => x.IsActive).ToList();
        }

        public Mesaj Insert(Customer customer)
        {   
                   
            int id = _cm.Insert(customer);
            if (id > 0)
            {
                customer.CustomerId = id;
                mesaj.Content = "Kayıt yapıldı";
                mesaj.Color = Color.Green;
            }
            else
            {
                mesaj.Content = "Kayıt Yapılamadı";
                mesaj.Color = Color.Red;
            }

         
            return mesaj;
        }

        public Mesaj Update(Customer customer)
        {
            int row = _cm.Update(customer);
            if (row>0)
            {
                mesaj.Content = "Güncelleme Yapıldı";
            }
            else
            {
                mesaj.Content = "Kayıt güncellenemedi";
            }
            return mesaj;
        }

      

        public Mesaj IsActiveSituation(Customer customer)
        {
            int row = _cm.IsActiveSituation(customer);
            if (row > 0)
            {
                mesaj.Content = "Kayıt Silindi";
                mesaj.Color = Color.Green;
            }
            else
            {
                mesaj.Content = "Kayıt Silinemedi";
                mesaj.Color = Color.Red;
            }

            return mesaj;
        }
    }
}
