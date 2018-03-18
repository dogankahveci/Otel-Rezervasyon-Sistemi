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
    public class RoomController
    {
        RoomManagement _rom;
        DetailOfRezarvationManagement _drm;
        InformationOfRezervationManagement _rem;
        Mesaj mesaj = new Mesaj();
        public RoomController()
        {
            _rom = new RoomManagement();
            _drm = new DetailOfRezarvationManagement();
            _rem = new InformationOfRezervationManagement();
        }

        public Room Get(int id)
        {
            return _rom.Get(id);
        }

        public List<Room> GetAll()
        {
            return _rom.GetAll();
        }

        public List<Room> GetAllByIsActive( )
        {
            return _rom.GetAll().Where(x => x.IsActive).ToList();
        }

        public Mesaj Insert(Room room)
        {
            int row = _rom.Insert(room);
            if (row>0)
            {
                mesaj.Content = "Kayıt Ekleme Başarılı";
                mesaj.Color = Color.Green;
            }
            else
            {
                mesaj.Content = "Kayıt Ekleme Başarısız";
                mesaj.Color = Color.Red;
            }
            return mesaj;
        }

        public Mesaj Update(Room room)
        {
            int row = _rom.Update(room);
            if (row > 0)
            {
                mesaj.Content = "Güncelleme Yapıldı";
                mesaj.Color = Color.Green;
            }
            else
            {
                mesaj.Content = "Kayıt güncellenemedi";
                mesaj.Color = Color.Red;
            }
            return mesaj;
        }

        public Mesaj IsActiveSituation(Room room)
        {
            int row = _rom.IsActiveSituation(room);
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

        public List<Room> GetEmptyRoom(DateTime checkin,DateTime checkout)
        {
            //tamammuy checkin checkout giriş cıkıst mı aynen..tamam
            // elimizde  giriş tarihleri var. bu tarihlerde boş olan bir odayı bulacağız. ters mantık kuracam.  o tarihte kiralanmış olan odalardan tüm odaları çıkardığımda geriye o tarihte boş olan odalarım kalır.anladım
            //peki o tarihte hangi odalar dolu??onu daha yapmadıkki :D
            // olmadııı birde reservation a ihtiyacımız var..abi senin o istediklerin reservationun icinde giriş cıkış tarihleri fala naynen durr. burada bu arada boş olan tümleri getirmemiz lazım.
            //yani le 10 unden 20 sine kadar istedik.
            //ama bir odamız 11 inde doldu. onun için diyecez ki giriş tarihi bu ve bunden büyük. çıkış tarihi ise bu ve bundan küçük olanlar diyecez. anladınmı tekrar okuyorum 
            //10 u ile 20 si arasını kapatmak istiyorsun. lakin bir oda 13 ile 19 arasında kapalı. eşittir dersek yanlış yaparız. bu aralıkta hiç dolu  oda olmaması lazım aynen. onun için eşitttir olmaz.

           List<InformationOfRezervation> reservations= _rem.GetAll().Where(x => x.EnteringDate >= checkin && x.LeavingDate <= checkout).ToList();//bu bize o arada bize engel olan reservationları verir..abi 1 dk hemen gelioyurm  geldim dolu ola 
            //_drm.GetAll().Where(x=> x.) abı su kodu bi acıklarmısın bana tam anlamadım tüm reservationları çektikten sonra benim istediği tarih aralığında kalanları çekiyorum. dışardan giriş cıkışt tarhleri geldi
            //entirindate>dışardan gelen giriş tarihinden buyuk ve eşit.. cıkış tarhinden kucuk ve eeşit o aralıgımı yakalıyoruz yani aynen. o aralıkta hangi reservasyonlar var. diğerleri bizim için önemli dğeiltamam
            // bu reservation larda tutulan odalar dolu durumdadır. onları tüm odalistemizden çıkarırsak elimizde boş odalar kalır. o aralıktaki odalarmı dolu durumda aynen orada reservasyon var çünkü. onu nasıl anladık. reservasyonlara soracaz şimdi sen hangi odaları aldın diye.tamam hiç uyarmuyonnn
            List<int> reservationIds = reservations.Select(r => r.RezervationId).ToList(); //reservasyon listemizden 
            //sonradan kullanılmak üsere sadece idleri alıyoruz. ok. tamamdır
            List<DetailOfRezervation> dofs = _drm.GetAll().Where(x => reservationIds.Contains(x.RezervationId)).ToList(); //o reservationıd lere ait detayları list halinde çekiyorum.tamam
            List<int> roomIds = dofs.Select(dof => dof.RoomId).Distinct().ToList(); // o reservationdetay da geçen oda idlerini çekiyorum. distinc kullanıyorum ki tekrar olmasın.tamam
            //artık elimizde dolu olan odaların id leri var. tüm odalarda bu id olmayanlar benim boş odalarımdır.
          return _rom.GetAll().Where(r => !roomIds.Contains(r.RoomId)).ToList();//burda ne demiş olduk önce bu idlere ait odaları ver dedim. sonra değil kullanarak bu idler dışındakileri vder dedim.Tamam bişe sorcam  ustteki 3 tane lamda kodu  o aralıkdaki dolu olanlarımı verdi bize şimdi evet 3 adeti bize dolu olanların id lerini verdi. Çünkü önce o tarihteki reservasyonlara baktık. o reservasyonlara verilmiş odaları listeledik aslında. ok tamam bu arada bu iş bukadar kaşıık olmasının sebebi expression alan metot kullanmamamız ve ado.net ile çalışıyor olmamız. bir orm tool ile bu iş biraz daha kolay olacaktır. ben expresion hic bilmiyorum o yüzden o üstteki kodlar bana bişe ifade etmedi sen demesen anlamam yani. çok kolay aslında ama algoritmasını kurarken biraz kafayı yiyiyorsun. zaten entity framework e geçtiğimizde bir hafta linq çalışacan..aynen bu arada eğer bir generic repository pattern ile unitofwork kullanmadıysan bu sorguyu direk sql de yazıp sonucu veren sorguyu direk dal katmanında bir metot olarak da yazabilirsin. bu yazdığımız aslına bakarsan çok performanslı çalışmaz. ama repository pattern gösterdiğimde ekleme işlemini daha uygun yapıyor olacağız.Tamam bu iki pattern den sonra dal katmanına ek yapmak hem işkence hemde mimari bozulması..

        }


    }
}
