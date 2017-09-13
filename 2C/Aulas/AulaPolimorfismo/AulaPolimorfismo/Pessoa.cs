using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPolimorfismo
{
    class Pessoa
    {
        private string primeiroNome, nomesMeio, ultimoNome;

        public string NomeCompleto
        {
            get { return String.Format("{0} {1} {2}", primeiroNome, nomesMeio, ultimoNome); }
            set
            {
                string[] partes = value.Split(' ');
                
                primeiroNome = partes[0];
                ultimoNome = partes[partes.Length - 1];

                int i;
                for (i=1; i < partes.Length - 2; i++)
                {
                    nomesMeio += partes[i] + " ";
                }
                nomesMeio += partes[i];
            }
        }

        public string NomeSobrenome {
            get { return String.Format("{0} {1}", primeiroNome, ultimoNome);  }
        }
        public string PrimeiroNome {
            get { return primeiroNome; }
        }
        public string UltimoNome {
            get { return ultimoNome; }
            set { ultimoNome = value; }
        }

        public Pessoa(string nomeCompleto)
        {
            NomeCompleto = nomeCompleto;
        }

    }
}
