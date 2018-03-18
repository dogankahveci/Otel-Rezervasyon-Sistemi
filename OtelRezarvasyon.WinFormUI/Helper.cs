using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezarvasyon.DTO;
using System.Text.RegularExpressions;
using System.Reflection;

namespace OtelRezarvasyon.WinFormUI
{
    static class Helper
    {
        public static void OnlyText(object sender, KeyPressEventArgs e)
        {
            int PressedKey = Convert.ToInt32(e.KeyChar);
            if ((PressedKey >= 48 && PressedKey <= 57))
            {
                e.Handled = true;
            }
        }

        public static void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            int PressedKey = Convert.ToInt32(e.KeyChar);
            if (!(PressedKey >= 48 && PressedKey <= 57 || PressedKey == 8))
            {
                e.Handled = true;
            }

        }
        public static void ShowMessage(Mesaj _mesaj)
        {
            MesajForm mesajfrm = new MesajForm();
            mesajfrm.Controls["lblMesaj"].Text = _mesaj.Content;
            mesajfrm.Controls["lblMesaj"].ForeColor = _mesaj.Color;
            mesajfrm.Show();
        }

        public static bool IsTelephoneNumber(string input)
        {
            Regex rgx = new Regex(@"\+?[0-9]{0,4}[0-9]{10}"); //parametre olarak senin oluşturduğun pattern i alır. internetten yada kendin yazareak bir regex pattern oluştur.ne iş yapcak o pattern girdiğin ifade o pattern a uyup yumadığını sogulayacağız. örneğin telefon numarasında + karakterini serbest bıraktın. lakin adam ++++++ şeklinde giriş yaparsa ne yapacaksın. burada bizim şöyle bir kalıbımız var onu girerse olur dememiz lazım.anladım şimdi telefon için regex bulalım.. başına @ işaretini içerideki özel karakterleri alsın diye koyuyoruz.Tammdır şimdi gelelim fasulyaya..

            return rgx.Match(input).Success;// bu kadar..:D regex kısmı zor :) ilk kullanım için zor geliyor. lakin zaten bu metotları bir kere yazacan.. Evet bir de internette hazır yazılmışları da var.
        }

        public static bool IsEmail(string input)
        {
            Regex rgx = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*)@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");
            return rgx.Match(input).Success;
        }

        //public static List<T> Search<T>(List<T> list, string input)
        //{
        //    List<T> result = new List<T>();//result olarak döneceğim list
        //    foreach (T item in list) //her ögesini dolaştığım foreach bu parametreden gelen dimi evet surada Burada dıışarıdan gelen bir list i dolaşıyorum. parametre olarak gelen listte.. onu nerde tutuyoruz bu bir metot. bunu dışarıdan çağırırken biz vereceğiz. tamam anladım
        //    {
        //        foreach (PropertyInfo propertyInfo in item.GetType().GetProperties()) // gettype bir nesnenin classının yansımasını verir. direk classı elinle tutamasanda bir bilgi nesnesi elde edersin.Getproperties() ise class yansıması içinde tüm properylerin yansımalarını veriri. direk olarak property elinde değil ama bir bilgi nesnesi elinde olur.
        //        {
        //            string propertyValue = propertyInfo.GetValue(item).ToString().ToLower();// şimdi eğer elinde bir propertyInfo var ise şunu diyebiliyorsun. eyy nesne senin bu infoya ait properynin verisini bana ver. işte burada bu işlimi getvalue yapıyor. anladın mı Tamam tabi bizim gelen değiri stirng e çevirmemiz lazım.
        //            // sol olarak bunun inputu içerdiğini soracaz..
        //            if (propertyValue.Contains(input.ToLower())) //eğer içeriyor sa.. buada büyük küçük harf durumunu atlamışız. böyle durumlarda aranacak ve aratılacak tamamen küçük harfe çekilir.
        //            {
        //                result.Add(item); // 
        //                //şimdi burada bir sorun var. örneğin ilk property de bu değer geçiyor. onu gitti resulta ekledi. lakin birde baktı ki ikinci property de de geçiyor. ozman resulta ikincikez eklemiş olur. bunun önüne geçmek için eklediğim an property dolaşmasını sonlandırmam lazım.
        //                break;// bundan yazdık bunu.. ok?tmm
        //            }
        //        }
        //    }
        //    //tüm liste dolaşıldı. bize kalan sonucu dönmek sadece..
        //    return result; //tamammıdır tmm bunla ilgili bişe sorammı sana abi bu arama kısmı 
        //}ok söyle bu metot ee tüm verileri her halukarda dönüyor sıkıntı değilmi bu alttakı benim yazdıgım  yorumda olan seninki aynısıeski yorumlar sıkıntılı olabliri. pardon aynı işte bir bakayım

        public static List<T> Search<T>(List<T> list, string input)
        {
            List<T> result = new List<T>();
            foreach (var item in list) //gelenlistein her elemenı için işlemyap
            {

                foreach (PropertyInfo propertyinfo in item.GetType().GetProperties()) //elemanın her properysini dolaş.
                {
                    string propertyValue = propertyinfo.GetValue(item).ToString().ToLower();//her property nin değerini oku
                    if (propertyValue.Contains(input.ToLower())) //gelen değerde aranan metin var mı
                    {
                        result.Add(item);//varsa ekle..

                        break;//bunu ise her property için bir daha ekleme yapmanıza gerek yokter diye yazıyoruz. 
                    }
                }
            }

            return result;
        }

       
        /// <summary>
        /// Girilen list içerisindeki tüm nesnelerin tüm propertylerinin doldurulup doldurulmadığını kontrol eden metot.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool isFillin<T>(List<T> list)
        {
            bool isFill = true;
            foreach (T item in list)
            {
                foreach (PropertyInfo info in item.GetType().GetProperties())
                {
                    //if (info.GetValue(item).GetType().IsClass) //eğer bir nesne ise null olup olmadığına bakıyoruz.IsClass nesne oldugunmu soyluyor aynen.
                    //{
                        if (info.GetValue(item) == null)
                        {
                            isFill = false;
                            break;
                        }
                   // }
                    else
                    {
                        if (info.GetValue(item).ToString() == "")
                        {
                            isFill = false;
                            break;
                        }
                    }

                }
            }
            return isFill;//ok. nese ben onu tekrar ederken oturturum :D zaten bu da böyle yazılmamalı. her property değerine bir regex yazmalı ve burada değeri okuyup regexe uyup uymadığına bakmalı.ohooo:D:D:D hatta burasının da işi değil. bu sadece ön kontrol . asıl kontrolü bll yapmalı.o ne yapcak ben ne yaptıgımızı unuttum bunu ne icin yaptık yav :D:D o işte regex uygulayacak. ama regex ler bll e değil ayrı bir validation katman yada dll inde olmalı. hacı ben yoruldum. biraz burası da karışıyor. akşam devam edelim. tamam son bişe sorcam bunu yazdık ama unuttum ne ıcın oldugunu customer nesneleri gerçekten doldurulmuş mu yoksa boş mu bırakılmışlar. hata verdircez burda dimi aynen..
        }
    }
}
