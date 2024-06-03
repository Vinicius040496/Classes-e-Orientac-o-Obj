using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp122
{
    internal class Funcionario1
    {
        public int A;
        public int B;
        public int C;

        public int Soma1()
        {
            A = 10;
            B = 20;
            C = 30;

            int Soma1 = (A + B) * C;
            return Soma1;
        }
    }
}
