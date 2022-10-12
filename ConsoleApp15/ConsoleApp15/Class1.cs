using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp15
{
    class Produkt
    {
        public int ID;
        public string nazov;
        public int cena;
        public Produkt(string nazov, int cena)
        {
            Random r = new Random();
            this.ID = r.Next(10000,99999);
            this.nazov = nazov;
            this.cena = cena;
        }

        public void info()
        {
            Console.WriteLine(nazov + " je produkt z ID " + ID + " a cenou " + cena);
        }
    }
}
