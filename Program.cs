using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Program
    {
        public class User
        {



            static void Main(string[] args)
            {
                //Kullanıcının gırecegı TC
                long code;

                //Default olarak karşılayacak 2 adet kullanıcı tanımladım
                List<long> Users = new List<long>();
                Users.Add(12345678901);
                Users.Add(98765432101);



            xx:

                //Açılış ekranı

                Console.WriteLine(" Kayıt Programına Hoşgeldiniz");
                Console.WriteLine("Lütfen Ne Yapmak İstediğinizi Seçiniz");
                Console.WriteLine("Kayıt Olmak İstiyorsanız (2) Tuşuna basınız");
                Console.WriteLine();
                Console.WriteLine("Giriş Yapmak İstiyorsanız (1) Tuşuna Basınız");
                Console.WriteLine();
                Console.WriteLine("Uygulamadan Çıkmak İsityorsanız Herhangi Bir Rakama Basınız");

                //Giriş yapma kısmı
                int read = Convert.ToInt32(Console.ReadLine());
                switch (read)
                {
                    case (1):

                    yy:

                        Console.WriteLine();
                        Console.WriteLine("Lütfen TC Giriniz");
                        Console.Write("TC = ");
                        code = Convert.ToInt64(Console.ReadLine());

                        //Girilen tc bizimkilerin içinde tanımlı ise veya kayıt edilmişse
                        if (Users.Contains(code))
                        {
                            Console.WriteLine("Giriş Başarılı");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("Bilgileriniz:");
                            Console.WriteLine();

                            Console.WriteLine("Giriş TC'niz = " + code);
                            Console.WriteLine();

                            Console.WriteLine("Kayıt Olup Giriş Yaptığınız İçin Teşekkürler");
                            goto zz;

                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(8000);
                            Environment.Exit(0);

                        }
                        else
                        {
                            Console.WriteLine("Giriş Başarısız");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("Lütfen TC'nizi Doğru Girdiğinizden Emin Olun");
                            System.Threading.Thread.Sleep(500);

                            goto yy;

                        }
                        break;

                    default:
                        Console.WriteLine("Uygulama Kapanıyor");
                        System.Threading.Thread.Sleep(500);
                        Environment.Exit(0);
                        break;


                    //Kayıt Olma kısmı
                    case (2):

                        //Kullanıcıdan TC istiyoruz

                        Console.WriteLine();
                        Console.WriteLine("Kayıt İşlemi Başladı");
                        Console.Write("Lütfen TC Giriniz:");
                        Console.WriteLine();
                        code = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Lütfen Bekleyin... Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(1000);

                        Console.WriteLine("Kayıt Başarılı !");

                        Console.WriteLine("Bilgileriniz:");

                        Console.WriteLine("Giriş Kullanıcı TC'niz = " + code);
                        Console.WriteLine();
                        Users.Add(code);
                        Console.WriteLine("Başa Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(1000);

                        goto xx;
                        break;

                       


                }

            //Başarılı girişten sonra ekrana gelecek ürün listesi
            zz:
               double ch, pc, total, amount = 0;  //seçim,adet,toplam ve tutar 
                Console.WriteLine("");
                Console.WriteLine("**         URUNLER         **");
                Console.WriteLine("**                         **");
                Console.WriteLine("**     1-Gömlek - 50 TL    **");
                Console.WriteLine("**                         **");
                Console.WriteLine("**     2-Ceket - 150 TL    **");
                Console.WriteLine("**                         **");
                Console.WriteLine("**     3-Kravat - 20 TL    **");
                Console.WriteLine("**                         **");
                Console.WriteLine("**     4-Pantolon - 100 TL **");

                //Ürün seçim kısmı

                for (int i = 1; i < 100; i++)
                {
                    Console.WriteLine("");
                    Console.Write("Ürünün numarısını giriniz: ");
                    ch = Convert.ToDouble(Console.ReadLine());

                    if (ch == 1)
                    {
                        Console.Write("Kaç Adet Gömlek istersiniz?: ");
                        pc = Convert.ToDouble(Console.ReadLine());
                        total = pc * 50;
                        amount = amount + total;
                    }

                    else if (ch == 2)
                    {
                        Console.Write("Kaç Adet Ceket istersiniz?: ");
                        pc = Convert.ToDouble(Console.ReadLine());
                        total = pc * 150;
                        amount = amount + total;
                    }

                    else if (ch == 3)
                    {
                        Console.Write("Kaç Adet Kravat istersiniz?: ");
                        pc = Convert.ToDouble(Console.ReadLine());
                        total = pc * 20;
                        amount = amount + total;
                    }
                    else if (ch == 4)
                    {
                        Console.Write("Kaç Adet Pantolon istersiniz?: ");
                        pc = Convert.ToDouble(Console.ReadLine());
                        total = pc * 100;
                        amount = amount + total;
                    }

                    else

                    Console.WriteLine("Böyle bir seçim yok");
                    Console.WriteLine("");
                    Console.Write("Başka isteğiniz var mı? ");
                    string ans = Console.ReadLine(); 
                    //alınacak cevap
                    if (ans == "h" || ans == "H" || ans == "Hayır" || ans == "HAYIR" || ans == "hayır")
                        break;


                }
                //Siparişlerden sonra ki en son kısım
                Console.WriteLine("Siparişleriniz alınmıştır");
                Console.WriteLine("");
                Console.WriteLine("Toplam tutar:" + amount + " TL");
                Console.Read();

               
                

            }




        }

       

       


    }
}