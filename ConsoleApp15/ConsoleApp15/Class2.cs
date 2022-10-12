using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Pocitac : Produkt
    {
        private int RAM;
        private int DISK;
        Pocitac(int RAM, int DISK) : base("lol", 58)
        {
            this.DISK = DISK;
            this.RAM = RAM;
        }
        



    }
}
