using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            int kateta1 = 0;
            int kateta2 = 0;
            int hipotenuza = 0;

            start: Console.WriteLine("Upisi vrijednost prve katete(cm): ");
            kateta1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisi vrijednost druge katete(cm): ");
            kateta2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisi vrijednost hipotenuze(cm): ");
            hipotenuza = Convert.ToInt32(Console.ReadLine());

            if(kateta1 == 0 || kateta2 == 0 || hipotenuza == 0)
            {
                goto start;
            }


            if(Math.Pow(hipotenuza, 2) == (Math.Pow(kateta1, 2) + Math.Pow(kateta2, 2)))
            {
                Console.WriteLine("Ovo je pravokutan trokut :) " + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Ovo nije pravokutan trokut :( " + Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}
