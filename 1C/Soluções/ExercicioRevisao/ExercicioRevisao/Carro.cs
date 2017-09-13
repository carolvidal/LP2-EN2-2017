using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Carro
    {
        public string Modelo;
        public double Quilometragem;
        public int Potencia;
        public int AnoFabricacao;

        public string Classificar()
        {
            string classifRodagem, classifPot;

            if (Quilometragem <= 5000)
                classifRodagem = "Novo";
            else if (Quilometragem <= 30000)
                classifRodagem = "Seminovo";
            else
                classifRodagem = "Velho";

            if (Potencia < 120)
                classifPot = "Popular";
            else if (Potencia <= 200)
                classifPot = "Forte";
            else
                classifPot = "Potente";

            return String.Format("{0} - {1} - {2}", Modelo, classifRodagem, classifPot);
        }

        public void AtualizarKm(double novoKm)
        {
            Quilometragem = novoKm;
        }

        public double TaxaDeUso()
        {
            return Quilometragem / (DateTime.Now.Year - AnoFabricacao);
        }
    }
}
