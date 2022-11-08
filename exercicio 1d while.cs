using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1d_while
{
    internal class Program
    {
        static void Main(string[] args)
        {// d) Apresentar os quadrados dos números inteiros de 15 a 200.

            int n1 = 14, n2 = 0;

            while (n1 <= 199)
            {
                n1 = n1 + 1;
                n2 = n1 * n1;
                
                Console.WriteLine(n2);
            }
            
        }
    }
}
