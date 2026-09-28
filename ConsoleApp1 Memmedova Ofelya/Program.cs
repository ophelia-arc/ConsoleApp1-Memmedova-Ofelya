//1 Sadə dəyişənlər
//using System;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Adınızı daxil edin:");
//            string ad = Console.ReadLine();

//            Console.WriteLine("Yaşınızı daxil edin:");
//            string agetext = Console.ReadLine();
//            int.TryParse(agetext, out int yas);

//            Console.WriteLine("Boyunuzu daxil edin:");
//            string heighttext = Console.ReadLine();
//            double.TryParse(heighttext, out double boy);

//            Console.WriteLine("----------------");
//            Console.WriteLine($"Salam, mənim adım {ad}dır. Mən {yas} yaşım var, boyum {boy} m-dir.");

//            Console.ReadKey();
//        }
//    }
//}

//2 Sabitlərdən istifadə
//using System;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            const double Pi = 3.14159;

//            Console.WriteLine("Dairənin radiusunu daxil edin:");
//            string radiusText = Console.ReadLine();
//            double.TryParse(radiusText, out double r);

//            double S = Pi * r * r;

//            Console.WriteLine("----------------");
//            Console.WriteLine($"Dairənin sahəsi: {S}");

//            Console.ReadKey();
//        }
//    }
//}

//3 Valyuta çevirmə kalkulyatoru
//using System;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            const double usd = 1.7;
//            const double eur = 1.82;

//            Console.WriteLine("Manat məbləğini daxil edin:");
//            string manatText = Console.ReadLine();

//            if (double.TryParse(manatText, out double manat))
//            {
//                double dollar = manat / usd;
//                double avro = manat / eur;

//                Console.WriteLine("----------------");
//                Console.WriteLine($"Dollar (USD): {dollar}");
//                Console.WriteLine($"Avro (EUR): {avro}");
//            }
//            else
//            {
//                Console.WriteLine("Xəta: Zəhmət olmasa düzgün rəqəm daxil edin!");
//            }

//            Console.ReadKey();
//        }
//    }
//}

//4 Şagirdin orta balı
//using System;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("1-ci fənnin qiymətini daxil edin:");
//            string q1Text = Console.ReadLine();
//            int q1 = int.Parse(q1Text);

//            Console.WriteLine("2-ci fənnin qiymətini daxil edin:");
//            string q2Text = Console.ReadLine();
//            int q2 = int.Parse(q2Text);

//            Console.WriteLine("3-cü fənnin qiymətini daxil edin:");
//            string q3Text = Console.ReadLine();
//            int q3 = int.Parse(q3Text);

//            Console.WriteLine("4-cü fənnin qiymətini daxil edin:");
//            string q4Text = Console.ReadLine();
//            int q4 = int.Parse(q4Text);

//            Console.WriteLine("5-ci fənnin qiymətini daxil edin:");
//            string q5Text = Console.ReadLine();
//            int q5 = int.Parse(q5Text);

//            double ortaBal = (q1 + q2 + q3 + q4 + q5) / 5.0;

//            Console.WriteLine("----------------");
//            Console.WriteLine("Orta bal: " + ortaBal);

//            if (ortaBal < 51)
//            {
//                Console.WriteLine("Kəsildiniz");
//            }
//            else if (ortaBal >= 51 && ortaBal <= 90)
//            {
//                Console.WriteLine("Orta nəticə");
//            }
//            else
//            {
//                Console.WriteLine("Əla nəticə");
//            }

//            Console.ReadKey();
//        }
//    }
//}

//5 Bank depoziti hesablayan proqram
//using System;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            const double faiz = 0.12;

//            Console.WriteLine("İlkin məbləği daxil edin:");
//            string meblegText = Console.ReadLine();
//            double.TryParse(meblegText, out double ilkinMebleg);

//            Console.WriteLine("Neçə il saxlayacağınızı daxil edin:");
//            string ilText = Console.ReadLine();
//            int.TryParse(ilText, out int ilSayi);

//            double gelecekMebleg = ilkinMebleg * (1 + faiz * ilSayi);

//            Console.WriteLine("----------------");
//            Console.WriteLine($"Gələcək məbləğ: {gelecekMebleg}");

//            Console.ReadKey();
//        }
//    }
//}

//6 Avtomobilin yanacaq sərfiyyatı
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Məsafəni daxil edin (km):");
            string mesafeText = Console.ReadLine();
            double.TryParse(mesafeText, out double mesafe);

            Console.WriteLine("Sərf olunan yanacağı daxil edin (litr):");
            string yanacaqText = Console.ReadLine();
            double.TryParse(yanacaqText, out double yanacaq);

            if (mesafe <= 0 || yanacaq < 0)
            {
                Console.WriteLine("----------------");
                Console.WriteLine("Daxil edilən məlumat yanlışdır!");
            }
            else
            {
                double serfiyyat = (yanacaq / mesafe) * 100;

                Console.WriteLine("----------------");
                Console.WriteLine($"100 km üçün yanacaq sərfiyyatı: {serfiyyat} litr");
            }

            Console.ReadKey();
        }
    }
}