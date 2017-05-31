using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 600, L = 800;

            Console.Write("Digite X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y inicial: ");
            int y = int.Parse(Console.ReadLine());

            /* O tipo Objeto2D não existirá até que você crie uma nova 
             * classe para representá-lo em seu projeto!*/
            Objeto2D obj = new Objeto2D();
            /* COMPLETAR: Inicialização da posição do objeto */

            Console.Write("Digite comando: ");
            ConsoleKey comando = Console.ReadKey().Key;

            if (comando == ConsoleKey.RightArrow)
            {
                /* As duas linhas abaixo só funcionarão corretamente caso a 
                 * classe Objeto2D tenha sido construida de forma adequada, 
                 * ou seja, que saiba realizar as tarefas de andar para a direita 
                 * e de retornar uma string exibindo suas coordenadas */

                obj.AndarParaADireita();
                Console.WriteLine(obj.Coordenadas());
            }
        }
    }
}
