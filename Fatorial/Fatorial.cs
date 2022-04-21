using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Fatorial
    {
        public long num, fatorial;
        public Fatorial(long numEntrada)
        {
            num = numEntrada;
            fatorial = 1;
        }
        public double Calculo()
        {
            while (num > 1)
            {
                fatorial= fatorial * num;
                num= num - 1;
            }
            return fatorial;
        }
    }
    class Start
    {
        static void Main(string[] args)
        {
            Console.Write("Número : ");
            Fatorial fatorial = new Fatorial(long.Parse(Console.ReadLine()));
            Console.WriteLine("Fatorial : " + fatorial.Calculo());
            Console.Read();

        }
    }
}

        
