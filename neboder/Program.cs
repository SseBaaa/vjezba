using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neboder
{
    class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder(200, 100);
            Console.WriteLine(Tower.ToString());
            Console.ReadKey();
        }
    }

    class Neboder
    {
        int visina;
        int brojKatova;
        public Neboder(int visina, int brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;
         
        }

        public override string ToString()
        {
            int visina1 = this.visina + 10;
            int brojKatova1 = this.brojKatova + 1;
            double prosjek = this.visina / this.brojKatova;
            string ispis = "Visina: " + visina1 + Environment.NewLine +"Broj katova je: " + brojKatova1 + Environment.NewLine + "Prosjek veličine kata je: " + prosjek;
            return ispis;
        }
        private int Visina { get => visina; set => visina = value; }
        private int BrojKatova { get => brojKatova; set => brojKatova = value; }
    }
}
