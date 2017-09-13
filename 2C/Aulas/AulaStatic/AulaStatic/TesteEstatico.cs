using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaStatic
{
    static class TesteEstatico
    {
        //public int Valor { get; set; } ERRO!!!!!!
        // Tudo dentro de uma classe estática só pode ser referenciado através
        // do nome da classe.

        // Exemplos: Utilização das classes Math, Console, Convert, etc....
        public static int Numero { get; set; }
    }
}
