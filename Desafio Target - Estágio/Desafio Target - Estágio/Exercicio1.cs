using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target___Estágio
{
    internal class Exercicio1
    {
        private static int Fibonacci(int targetNumber)
        {
            int lastNumber = 0;
            int actualNumber = 1;
            int nextNumber;

            if (targetNumber == 0)
                return 1;

            while (actualNumber <= targetNumber)
            {

                if (actualNumber == targetNumber)
                {
                    return 1;

                }
                else
                {
                    nextNumber = actualNumber + lastNumber;
                    lastNumber = actualNumber;
                    actualNumber = nextNumber;
                }
            }
            return 0;
        }

        public static void Executar()
        {
            int number;

            Console.WriteLine("Informe um número maior que 0 (Checaremos se pertence a sequencia de Fibonacci)");
            number = Convert.ToInt32(Console.ReadLine());

            if (Fibonacci(number) == 1)
            {
                Console.WriteLine("O numero " + number + " está na sequencia de Fibonacci!");
            }
            else
            {
                Console.WriteLine("O numero " + number + " NÃO está na sequencia de Fibonacci!");
            }
        } 
    }
}
