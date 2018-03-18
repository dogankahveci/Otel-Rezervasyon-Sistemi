using OtelRezarvasyon.DAL;
using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OtelRezarvasyon.DTO;

namespace OtelRezarvasyon.BLL
{
    public class ContactController
    {
        ContactManagement _ctm;
        Mesaj mesaj = new Mesaj();
        public ContactController()
        {
            _ctm = new ContactManagement();
        }

        public Contact Get(int id)
        {
            return _ctm.Get(id);
        }

        public List<Contact> GetAll()
        {
            return _ctm.GetAll();
        }
        public List<Contact> GetByCustomerIdPassive(int id) 
        {
            return _ctm.GetByCustomerId(id).Where(x => !x.IsActive).ToList();
        }

        public List<Contact> GetByCustomerIdActive(int id)
        {
            return _ctm.GetByCustomerId(id).Where(x => x.IsActive).ToList();
        }


        public Mesaj Insert(Contact contact)
        {

            int row = _ctm.Insert(contact);
            if (row > 0)
            {

                mesaj.Content = "Kayıt Başarılı";
                mesaj.Color = Color.Green;
            }
            else
            {
                mesaj.Content = "Kayıt Başarız";
                mesaj.Color = Color.Red;
            }


            return mesaj;
        }

        public Mesaj Update(Contact contact)
        {
            int row = _ctm.Update(contact);
            if (row > 0)
            {
                mesaj.Content = "Güncelleme Yapıldı";
            }
            else
            {
                mesaj.Content = "Kayıt güncellenemedi";
            }
            return mesaj;
        }

       

        public Mesaj IsActiveSituation(Contact contact)
        {
            int row = _ctm.IsActiveSituation(contact);
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
