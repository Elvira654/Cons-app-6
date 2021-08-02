using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Napisati program koji računa ukupan broj poena učenika, tako što se unosi
prosječna ocjena sa sve četiri školske godine (koji ne smije biti manji od 2 niti veći
od 5 u suprotnom ispisuje se „Greska u unosu"). Takođe se unosi i broj poena sa
prijemnog ispita (koji ne smije biti manji od 0 niti veći od 60). Ukupan broj poena se
dobija tako što se prosječne ocjene iz škole množe sa 2 i sabiraju sa brojem poena
sa prijemnog ispita.*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pr = new double[4];
            double x = 0;
            int bodovi;

            for (int i = 0; i < 4; i++)
            {

                do
                {
                    Console.WriteLine(" Prosjek za " + (i + 1) + ". godinu je? ");
                    pr[i] = double.Parse(Console.ReadLine());

                    if (pr[i] > 5 || pr[i] < 2)
                        Console.WriteLine("Greska. Unesite ponovo: ");
                } while (pr[i] > 5 || pr[i] < 2);
            }

            do
            {
                Console.WriteLine("Broj bodova sa prijemnog ispita? ");
                bodovi = int.Parse(Console.ReadLine());
                if (bodovi < 0 || bodovi > 60)
                    Console.WriteLine("Greska. Unesite ponovo: ");
            } while (bodovi < 0 || bodovi > 60);

            for (int i = 0; i < 4; i++)
            {

                x += pr[i] * 2;
            }

            Console.WriteLine("Ukupan broj bodova je " + (x + bodovi));

            Console.ReadKey();
        }
    }
}
