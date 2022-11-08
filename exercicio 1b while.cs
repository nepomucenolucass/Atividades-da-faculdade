using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1b_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, i = 0;
            while (i <= 100)
            {
                n1 = n1 + i;
                i++;
            }
            Console.WriteLine("A soma de todos os números é: " + n1);
        }
    }
}
