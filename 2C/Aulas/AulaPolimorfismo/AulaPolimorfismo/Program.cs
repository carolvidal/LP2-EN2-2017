using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            double x2 = 1.5;
            float x3 = 3.2F;
            char x4 = 'A';
            bool x5 = false;
            string x6 = "abc";
            long x7 = 123456789;

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
            Console.WriteLine(x6);
            Console.WriteLine(x7);

            A a = new A();
            a.b(1);
            a.b(3.1);
            a.b(1.5, 2);
            a.b(2, 1.5);

            Pessoa p = new Pessoa("Ana Júlia Silva de Almeida da Silva");

            Console.WriteLine(p.PrimeiroNome);
            Console.WriteLine(p.UltimoNome);
            Console.WriteLine(p.NomeCompleto);
            Console.WriteLine(p.NomeSobrenome);

            p.UltimoNome = "Albuquerque";
            Console.WriteLine(p.NomeCompleto);
            Console.WriteLine(p.NomeSobrenome);
            p.UltimoNome = "Martins";
            Console.WriteLine(p.NomeCompleto);
            Console.WriteLine(p.NomeSobrenome);
            p.UltimoNome = "Rebarte";
            Console.WriteLine(p.NomeCompleto);
            Console.WriteLine(p.NomeSobrenome);
            p.UltimoNome = "Barraqui";
            Console.WriteLine(p.NomeCompleto);
            Console.WriteLine(p.NomeSobrenome);

        }
    }
}
