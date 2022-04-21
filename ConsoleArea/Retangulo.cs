using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArea
{
    class Retangulo
    {
        public Retangulo()
        {
        }
        public int altura, area, comprimento;

        public int Calculo()
        {
            area = comprimento * altura;
            return area;
        }
    }
    class Start
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.Write("Comprimento : ");
            retangulo.comprimento = int.Parse(Console.ReadLine());
            Console.Write("Altura :");
            retangulo.altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Area : " + retangulo.Calculo());
            Console.Read();
        }
    }
}
