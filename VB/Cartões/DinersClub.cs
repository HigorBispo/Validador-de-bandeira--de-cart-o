using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB.Cartões
{

    public class DinersClub : Cartão
    {
        public static string[] prefixosDinersClub = { "300", "301", "302", "303", "304", "305", "36", "38" };

        public override string ValidarBandeira()
        {
            return "O cartão é do tipo Diners Club.";
        }
    }
}