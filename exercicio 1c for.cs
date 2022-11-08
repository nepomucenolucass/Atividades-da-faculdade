using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1c_for
{
    internal class Program
    {
        static void Main(string[] args)
        {// c) Apresentar todos os números divisíveis por 4 que sejam menores que
            // 30.Iniciar a contagem com o valor 1(um).

            for (int n1 = 0, i = 0; i < 30; n1 = n1 + 1, i++)
            {
                if (n1 % 4 == 0)
                {
                    Console.WriteLine(n1);
                }

            }
        }
    }
}
