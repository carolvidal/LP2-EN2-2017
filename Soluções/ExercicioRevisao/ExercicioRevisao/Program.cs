using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double quilometragem = double.Parse(Console.ReadLine());
                int potencia = int.Parse(Console.ReadLine());

                string classifRodagem, classifPot;

                if (quilometragem <= 5000)
                    classifRodagem = "Novo";
                else if (quilometragem <= 30000)
                    classifRodagem = "Seminovo";
                else
                    classifRodagem = "Velho";

                if (potencia < 120)
                    classifPot = "Popular";
                else if (potencia <= 200)
                    classifPot = "Forte";
                else
                    classifPot = "Potente";

                Console.WriteLine("{0} - {1} - {2}", nome, classifRodagem, classifPot);
            }
        }
    }
}
