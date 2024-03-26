using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleContratacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp;
            int sb;
            int st;
            int cont = 0;

            Console.WriteLine("deseja iniciar? S (Sim), N (Não):");
            resp = Console.ReadLine().ToUpper();

            while (resp == "S") 
            {
                Console.WriteLine("Informa sua situação trabalhista (assalariado, comissionado, horista):");
                string sit = Console.ReadLine();

                switch (sit) 
                {
                    case "assalarido":

                        Console.WriteLine("Informe o salário do funcionario: ");
                        int salario = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor dos descontos: ");
                        int descontos = int.Parse(Console.ReadLine());

                        int total = salario - descontos;

                        Console.WriteLine("O salario liquido é de: " +  total);

                        sb += total;

                        cont++;

                        break;
                }
            }


                


            


            Console.ReadKey();
        }
    }
}
