using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Automobil a1 = new Automobil("Seat","Leon",2012,190,150,"Bela");
            Automobil a2 = new Automobil("Bmw", "M5", 2020, 270, 260, "Crna");
            a1.IspisiAtribute();


            a2.Ubrzaj();
            a2.Ubrzaj();
            a2.IspisiAtribute();
            a2.Uspori();
            a2.IspisiAtribute();



        }
       
    }
}
