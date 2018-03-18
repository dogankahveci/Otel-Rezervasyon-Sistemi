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
    public class UserController
    {
        UserManagement _um;

        Mesaj mesaj = new Mesaj();

        public UserController()
        {
            _um = new UserManagement();
        }

        public User Get(int id)
        {
            return _um.Get(id);   
        }

        public List<User> GetAll(User user)
        {
            return _um.GetAll();
        }

        public Mesaj Insert(User user)
        {
            int row = _um.Insert(user);
            
            if (row > 0)
            {
                mesaj.Content = "Kayıt Başarılı";
                mesaj.Color = Color.Green;
            }
            else
            {
                mesaj.Content = "Kayıt Yapılamadı";
                mesaj.Color = Color.Red;
            }
          
            return mesaj;
        }

        public Mesaj Update(User user)
        {
            int row = _um.Update(user);
            if (row>0)
            {
                mesaj.Content = "Güncelleme Yapıldı";
            }
            else
            {
                mesaj.Content = "Kayı Güncellenemedi";
            }

            return mesaj;
        }

       
        public Mesaj IsActiveSituation(User user)
        {
            int row = _um.IsActiveSituation(user);
            if (row > 0)
            {
                mesaj.Content = "Kayıt Silindi";
            }
            else
            {
                mesaj.Content = "Kayıt Silinemedi";
            }
            return mesaj;
        }
    }


}
