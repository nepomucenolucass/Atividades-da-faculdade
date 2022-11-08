using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1d_for
{
    internal class Program
    {
        static void Main(string[] args)
        {// d) Apresentar os quadrados dos números inteiros de 15 a 200.

            for (int n1 = 14, i = 0; n1 <= 200; n1 = n1 + 1, i = n1 * n1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
