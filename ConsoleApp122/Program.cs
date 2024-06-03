using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario1 F1;
            Funcionario2 F2;

            F1 = new Funcionario1();
            F2 = new Funcionario2();

            Console.WriteLine("Soma do primeiro funcionario");
            int SomaFuncionario1 = F1.Soma1();
            Console.WriteLine(SomaFuncionario1);
            Console.WriteLine("Soma do segundo funcionario");
            int SomaFuncionario2 = F2.Soma2();
             Console.WriteLine(SomaFuncionario2);
            Console.ReadLine();


        }
    }
}
