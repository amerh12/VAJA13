using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga13Vaje2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int stevec = 1;
            int vpisanoSt;
            int vsota = 0;
            do
            {
                Console.Write("Vpisi {0}. stevilo:", stevec);
                vpisanoSt = Convert.ToInt32(Console.ReadLine());

                vsota += vpisanoSt;

                stevec++;

            }while (stevec < 11);

            Console.WriteLine(vsota);









        }
    }
}
