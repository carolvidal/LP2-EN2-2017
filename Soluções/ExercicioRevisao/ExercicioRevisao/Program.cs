using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        public struct Carro
        {
            public string Modelo;
            public double Quilometragem;
            public int Potencia;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Carro[] carros = new Carro[n];

            for (int i = 0; i < n; i++)
            {
                carros[i].Modelo = Console.ReadLine(); //Palio
                carros[i].Quilometragem = double.Parse(Console.ReadLine()); //20000
                carros[i].Potencia = int.Parse(Console.ReadLine()); // 300
            }

            for(int i=0; i < n; i++)
                Console.WriteLine(Classificar(carros[i]));
        }

        public static string Classificar(Carro c)
        {
            string classifRodagem, classifPot;

            if (c.Quilometragem <= 5000)
                classifRodagem = "Novo";
            else if (c.Quilometragem <= 30000)
                classifRodagem = "Seminovo";
            else
                classifRodagem = "Velho";

            if (c.Potencia < 120)
                classifPot = "Popular";
            else if (c.Potencia <= 200)
                classifPot = "Forte";
            else
                classifPot = "Potente";

            return String.Format("{0} - {1} - {2}", c.Modelo, classifRodagem, classifPot);
        }

    }
}
