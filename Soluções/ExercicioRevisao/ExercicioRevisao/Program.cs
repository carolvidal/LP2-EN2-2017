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
                string nome = Console.ReadLine(); //Palio
                double quilometragem = double.Parse(Console.ReadLine()); //20000
                int potencia = int.Parse(Console.ReadLine()); // 300

                Console.WriteLine(Classificar(nome, quilometragem, potencia));
                                          //"Palio"    20000          300 
            }
        }

        public static string Classificar(string mod, double km, int pot)
        {                               // "Palio"    20000       300
            string classifRodagem, classifPot;

            if (km <= 5000)
                classifRodagem = "Novo";
            else if (km <= 30000)
                classifRodagem = "Seminovo";
            else
                classifRodagem = "Velho";

            if (pot < 120)
                classifPot = "Popular";
            else if (pot <= 200)
                classifPot = "Forte";
            else
                classifPot = "Potente";

            return String.Format("{0} - {1} - {2}", mod, classifRodagem, classifPot);
        }
    }
}
