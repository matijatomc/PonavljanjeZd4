using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPonavljanjeZd4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jednu cijenu bez PDV-a: ");
            decimal bez = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Unesite istu cijenu sa PDV-eom: ");
            decimal sa = Convert.ToDecimal(Console.ReadLine());

            decimal pdv = ((sa / bez)-1)*100;

            Console.WriteLine("PDV je: " + pdv + "%");
            Console.ReadKey();
        }
    }
}
