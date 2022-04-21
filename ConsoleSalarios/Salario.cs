using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Salario
    {
        //variaves
        public double bruto, segSocial, irs, liquido;

        //Construtor
        public Salario(double brutoEntradaSalario)
        {
            bruto = brutoEntradaSalario;
        }
        //Metodo
        public double Calculos()
        {
            segSocial = bruto * 0.2;
            if (bruto < 500)
            {
                irs = 0;
            }
            else if (bruto >= 500 && bruto < 1000)
            {
                irs = bruto * 0.12;
            }
            else if (bruto >= 1000 && bruto < 1500)
            {
                irs = bruto * 0.15;
            }
            else
            {
                irs = bruto * 0.18;
            }
            liquido = bruto - segSocial - irs;
            return liquido;
        }
    }
    class Start
    {
        static void Main(string[] args)
        {
            Console.Write ("Salário Bruto : ");
            Salario salario = new Salario(double.Parse(Console.ReadLine()));
            Console.WriteLine("Liquido: " + salario.Calculos());
            Console.Read();


        }
    }


        
}
