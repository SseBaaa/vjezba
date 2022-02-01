using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prijestupne_godine
{
    class Program
    {
        static void Main(string[] args)
        {


            for(int a = 1900; a<=2100; a++)
            {
                if (a % 4 == 0 || a % 400 == 0)
                {
                    if(a % 100 != 0)
                    Console.WriteLine(a);
                }
            }
            Console.ReadKey();
        }
    }
}
