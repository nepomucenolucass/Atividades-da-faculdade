using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1b_for
{
    internal class Program
    {
        static void Main(string[] args)
        {// b) Apresentar o total da soma dos cem primeiros números inteiros,
         // representados pela sequencia 1 + 2 + 3 + 4 + 5 + 6 + 7 + ...+97 + 98 + 99 + 100.


            for (int i = 0, n1 = 0; i <= 101; n1 = n1 + i, i++)
            {                
                Console.WriteLine(n1);
            }
        }
    }
}
