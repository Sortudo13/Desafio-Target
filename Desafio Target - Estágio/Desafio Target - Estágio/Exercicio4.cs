using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target___Estágio
{
    internal class Exercicio4
    {
        public static void Executar ()
        {
            Console.WriteLine("Resposta do exercicio 4:");
            Console.WriteLine("a) 9. Aqui a lógica está no aumento de 2 a cada iteração");
            Console.WriteLine("b) 128. Aqui a lógica está na multiplicação por 2 a cada iteração");
            Console.WriteLine("c) 49. Aqui a lógica está em somar um valor k a cada iteração, em que k também, por sua vez, aumenta em 2 a cada iteração. Os valores de k são: 1, 3, 5, 7, 9, 11 e 13. No fim, 36 + 13 = 49");
            Console.WriteLine("d) 100. Aqui a lógica está em somar um valor k a cada iteração, em que k também, por sua vez, aumenta em 8 a cada iteração. Os valores de k são: 12, 20, 38, 36. No fim 64 + 32 = 100");
            Console.WriteLine("e) 13. Aqui, a lógica está em calcular o próximo valor baseado na soma do valor anterior com o valor atual. Essa é a lógica utilizada pela sequencia de Fibonacci, que foi usada no exercicio 1");
            Console.WriteLine("f) 20. Aqui a lógica parece ser mais confusa. Os valores são somados com 8, 2, 4, 1, 1, e 1. Apesar dos valores iniciais não aparentar seguir uma lógica explícita, vemos um padrão nos últimos números, aumentando 1 a cada iteração. Portanto, continuando a lógica, o proximo numero seria 20");
        }
        
    }
}
