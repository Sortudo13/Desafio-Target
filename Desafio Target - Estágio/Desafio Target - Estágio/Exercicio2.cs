using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target___Estágio
{
    internal class Exercicio2
    {
        private static bool ContainsChar(string str,char c)
        {
            return str.Contains('a');
        }
        public static void Executar()
        {
            string[] exampleString = new string[4] { "A esperança já chegou!", "A EsperAnçA já Chegou", "ppp a ppp", "O livro foi escrito!" };

            for (int i = 0; i < exampleString.Length; i++) {
                Console.WriteLine("\nA frase: " + exampleString[i]);
                if (ContainsChar(exampleString[i], 'a'))
                {
                    Console.WriteLine("Contém o caractere a");
                }
                else
                {
                    Console.WriteLine("NÃO contém o caractere a");
                }
            } 
        }
    }
}
