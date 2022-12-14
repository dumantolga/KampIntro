using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 1,
                BirthYear = 1998,
                FirstName ="TOLGA",
                LastName ="DUMAN",
                IdentityNumber =12345
            }); 
        }
    }
}
//1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği,
//kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu
//e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz.
//(E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.
//Bunu yapacak servisi simule etmeniz yeterlidir.)

//2.Oyun satışı yapılabilecek satış ortamını simule ediniz.
//( Yapılan satışlar oyuncu ile ilişkilendirilmelidir.
//Oyuncunun parametre olarak metotta olmasını kastediyorum.)

//3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

//4.Satışlarda kampanya entegrasyonunu simule ediniz.
