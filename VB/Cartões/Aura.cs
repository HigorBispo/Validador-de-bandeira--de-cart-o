using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB.Cartões
{
    public class Aura : Cartão
    {
        public static string[] prefixosAura = { "50" };
        public override string ValidarBandeira()
        {
            return "O cartão é do tipo Aura.";
        }
    }
}