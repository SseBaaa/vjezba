using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaX__
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 0;

            Console.WriteLine("Napisi neki broj: ");
            broj = Convert.ToInt32(Console.ReadLine());

            KlasaX brroj = new KlasaX(broj);

            Console.WriteLine(brroj.ToString());

            Console.ReadKey();
        }
    }

    class KlasaX
    {

        int broj;

        public override string ToString()
        {
            int nesto = this.broj + 10;
            string ispis = "Rezulat je " + nesto;
            return ispis;
        }
        public KlasaX(int broj)
        {
            this.broj = broj;

        }
        private int Broj { get => broj; set => broj = value; }
    }
}
