using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB.Cartões
{
    public class Voyage : Cartão
    {
        public static string[] prefixosVoyage = { "8699" };
        public override string ValidarBandeira()
        {
            return "O cartão é do tipo Voyage.";
        }
    }
}