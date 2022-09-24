using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1a_for
{
    internal class Program
    {
        static void Main(string[] args)
        {// a) Apresentar todos os valores numéricos inteiros impares situados na
            // faixa de 0 a 20.

            for (int n1 = 0; n1 < 20;)
            {
                n1 = n1 + 1;
                if (n1 % 2 != 0)
                    Console.WriteLine(n1);

            }
        }
    }
}
