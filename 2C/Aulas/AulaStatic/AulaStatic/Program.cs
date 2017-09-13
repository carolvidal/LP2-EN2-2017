using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaStatic
{
    class Program  // Classe não é estática
    {
        static void Main(string[] args) // Método estático em classe não estática? PODE!
        {                               // Program.Main(...);
            Teste t1 = new Teste(10);
            //Teste t2 = new Teste(20);

            Teste.Oi(); //Oi
            t1.Oi(5);
            Console.WriteLine(Teste.Constante);
            Teste.Constante = 5.65; //Funciona como um atributo normal, porém o valor é único para a classe. 
            // Se estiver marcado como const, o valor não pode ser alterado ao longo do programa.
            Console.WriteLine(Teste.Constante);
            Menu();

            //Console c = new Console();
            //Convert c1 = new Convert();              // Classes estáticas NÃO PODEM SER INSTANCIADAS!
            //Math m = new Math();
            //TesteEstatico te = new TesteEstatico();
        }

        public static void Menu()
        {
            //.....
        }
    }
}
