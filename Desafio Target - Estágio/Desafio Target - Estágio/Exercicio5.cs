using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target___Estágio
{
    internal class Exercicio5
    {
        public static void Executar()
        {
            Console.WriteLine("Resposta do exercício 5:");
            Console.WriteLine("Primeiro, eu ligaria o interruptor 1 e esperaria 10 minutos");
            Console.WriteLine("Depois, eu acenderia o interruptor 2");
            Console.WriteLine("Agora, iria conferir a sala da primeira lâmpada");
            Console.WriteLine("- Se estiver acesa e quente, ela é controlada pelo interruptor 1 (pois acendi ela primeiro)");
            Console.WriteLine("- Se estiver acesa e fria, ela é controlada pelo interruptor 2");
            Console.WriteLine("- Se estiver apagada, ela é controlada pelo interruptor 3");
            Console.WriteLine("Baseado nisso, conseguimos dizer com certeza qual interruptor controla essa lâmpada!");
            Console.WriteLine("Agora, iria para a sala da segunda lampada");
            Console.WriteLine("- Aqui, como já sabemos qual interruptor controla a primeira lâmpada, e vimos se a primeira lâmpada estava acessa ou não, assim como sua temperatura, \nconseguimos deduzir qual interruptor controla a segunda lâmpada com certeza, já que estamos a vendo agora.");
            Console.WriteLine("Por fim, sabendo quais interruptores controlam a primeira e segunda lâmpada, por ser a única sobrando, podemos dizer qual interruptor controla a lâmpada da sala 3");
        }
    }
}
