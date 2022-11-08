using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1e_while
{
    internal class Program
    {
        static void Main(string[] args)
        {// e) Apresentar o resultado da soma de todos os valores pares existentes
            // na faixa numérica de 1 a 50.

            int n1 = 2, i = 0;

            while (i<52)
            {
                n1 = n1 + i;
                i = i + 2;
                
                Console.WriteLine(n1);        
            }
        }
    }
}
