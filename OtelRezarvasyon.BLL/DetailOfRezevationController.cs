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
    public class DetailOfRezevationController
    {
        DetailOfRezarvationManagement _drem;
        Mesaj mesaj = new Mesaj();
        public DetailOfRezevationController()
        {
            _drem = new DetailOfRezarvationManagement();
        }

        public DetailOfRezervation Get(int id)
        {
            return _drem.Get(id);
        }

        public List<DetailOfRezervation> GetAll()
        {
            return _drem.GetAll();
        }

        public Mesaj Insert(DetailOfRezervation detailOfRezarvation)
        {
            int row = _drem.Insert(detailOfRezarvation);
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

        public Mesaj Update(DetailOfRezervation detailOfRezarvation)
        {
            int row = _drem.Update(detailOfRezarvation);
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

      
    }
}
