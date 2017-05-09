using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = Console.ReadLine();
            int qtd = 0;

            for(int i = 0; i < texto.Length; i++)
            {
                if(texto[i] == 'a' || texto[i] == 'A' || texto[i] == 'e' || texto[i] == 'E' || texto[i] == 'i'
                     || texto[i] == 'I' || texto[i] == 'o' || texto[i] == 'O' || texto[i] == 'u' || texto[i] == 'U')
                {
                    qtd++;
                }
            }

            Console.WriteLine("O texto fornecido contém %d vogais", qtd);
        }
    }
}
