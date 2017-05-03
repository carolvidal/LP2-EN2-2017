using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        struct Carro
        {
            public string Modelo;
            public double Quilometragem;
            public int Potencia;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Carro carro;

            for (int i = 0; i < n; i++)
            {
                carro.Modelo = Console.ReadLine(); //Palio
                carro.Quilometragem = double.Parse(Console.ReadLine()); //20000
                carro.Potencia = int.Parse(Console.ReadLine()); // 300

                Console.WriteLine(Classificar(carro));
                                          //"Palio"    20000          300 
            }

            string s = "Francisco";
            char c = s[5];
            
            char sexo = Console.ReadLine().ToUpper()[0];
            switch(sexo)
            {
                case 'M': { s = "Masculino"; break; }
                case 'F': { s = "Feminino"; break; }
                default: throw new Exception(); 
            }

            if (sexo == 'M')
                s = "Masculino";
            else if (sexo == 'F')
                s = "Feminino";
            else
                throw new Exception(); 
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
