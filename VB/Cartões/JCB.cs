using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB.Cartões
{
    public class JCB : Cartão
    {
        public static string[] prefixosJCB = { "3528", "3589" };
        public override string ValidarBandeira()
        {
            return "O cartão é do tipo JCB.";
        }

    }
}