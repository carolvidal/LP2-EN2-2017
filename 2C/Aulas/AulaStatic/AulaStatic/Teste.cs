using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaStatic
{
    class Teste
    {
        public int A { get; set; }
        public static /*const*/ double Constante = 1.657813; // Inicialização

        public Teste(int n)
        {
            A = n;
        }

        public static void Oi()  //Método de classe
        // Não preciso de instância pra usar esse método
        {
            Console.WriteLine("Oi"); 
            //Console.WriteLine(A); // ERRO!!!! 
            //Não podemos usar membros de instância dentro de métodos estáticos
            // Oi(10); O mesmo para métodos!
        }
        public void Oi(int x) //Método de instância
        {
            Console.WriteLine(A*x);
        }
    }
}
