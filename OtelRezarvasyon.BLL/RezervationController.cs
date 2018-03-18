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
    public class RezervationController
    {
        InformationOfRezervationManagement _rem;
        Mesaj mesaj = new Mesaj();
        public RezervationController()
        {
            _rem = new InformationOfRezervationManagement();
        }

        public InformationOfRezervation Get(int id)
        {
            return _rem.Get(id);
        }

        public List<InformationOfRezervation> GetAll()
        {
            return _rem.GetAll();
        }

        public Mesaj Insert(InformationOfRezervation inforezervation)
        {
            int row = _rem.Insert(inforezervation);
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
            if (inforezervation.RezervationId== inforezervation.RezervationId)
            {
                mesaj.Content = "Aynı Kayıttdan Bir tane daha var";
            }
            return mesaj;

        }

        public Mesaj Update(InformationOfRezervation inforezervation)
        {
            int row = _rem.Update(inforezervation);
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
