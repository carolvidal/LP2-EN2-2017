using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPolimorfismo
{
    class A
    {
        // Um método b qualquer
        public void b(int x)
        {
            Console.WriteLine(x);
            this.b(1, 2.0);
        }

        //Mudando o tipo do parâmetro. É possível?  SIM!
        public void b(double x)
        {
            Console.WriteLine(x);
        }

        //Mudando o NOME do PARÂMETRO. É possível? NÃO!!!!!
        /*public void b(double y)
        {
            Console.WriteLine(y);
        }*/

        //Mudando a QUANTIDADE de PARÂMETROS. É possível? SIM!!!
        public void b(double x, int y)
        {
            Console.WriteLine(x+y);
        }

        //Invertendo os PARÂMETROS. É possível?
        public void b(int y, double x)
        {
            Console.WriteLine(x*y);
        }

        //Alterando a visibilidade. É possivel? NÃO!
        /*private void b(int y, double x)
        {
            Console.WriteLine(x*y);
        }*/

        //Alterando tipo de retorno. É possivel? NÃO!
        /*public int b(int y, double x)
        {
            Console.WriteLine(x*y);
            return 1;
        }*/

        // PERGUNTA: O que define unicamente um método? (ou seja, o que o c# considera
        // para decidir se um novo método é "repetido"?
        // Nome e (tipos, quantidades e ordem) dos parâmetros --> ASSINATURA DE UM MÉTODO.
    }
}
