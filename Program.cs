using System;

namespace AtmSimulasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bakiye = 5000.00m; 
            bool devamEt = true;

            Console.WriteLine(" Bankamıza Hoş Geldiniz!");

            while (devamEt)
            {
                Console.WriteLine("\n--- İŞLEM MENÜSÜ ---");
                Console.WriteLine("1. Bakiye Sorgula");
                Console.WriteLine("2. Para Yatır");
                Console.WriteLine("3. Para Çek");
                Console.WriteLine("4. Çıkış Yap");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçin (1-4): ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine($"\n Güncel Bakiyeniz: {bakiye:C2}");
                        break;

                    case "2":
                        Console.Write("\nYatırmak istediğiniz tutarı girin: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal yatirilan) && yatirilan > 0)
                        {
                            bakiye += yatirilan;
                            Console.WriteLine($" İşlem başarılı! Yeni bakiyeniz: {bakiye:C2}");
                        }
                        else
                        {
                            Console.WriteLine(" Geçersiz miktar girdiniz!");
                        }
                        break;

                    case "3":
                        Console.Write("\nÇekmek istediğiniz tutarı girin: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal cekilen) && cekilen > 0)
                        {
                            if (cekilen <= bakiye)
                            {
                                bakiye -= cekilen;
                                Console.WriteLine($" İşlem başarılı! Kalan bakiyeniz: {bakiye:C2}");
                            }
                            else
                            {
                                Console.WriteLine(" Hesabınızda bu kadar bakiye yok!");
                            }
                        }
                        else
                        {
                            Console.WriteLine(" Geçersiz miktar girdiniz!");
                        }
                        break;

                    case "4":
                        Console.WriteLine("\n Bizi tercih ettiğiniz için teşekkür ederiz. İyi günler!");
                        devamEt = false;
                        break;

                    default:
                        Console.WriteLine("\n Hatalı seçim yaptınız. Lütfen 1-4 arasında bir değer girin.");
                        break;
                }
            }
        }
    }
}