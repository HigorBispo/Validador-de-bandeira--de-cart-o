using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB.Cartões
{
    public class EnRoute: Cartão
    {
        public static string[] prefixosEnRoute = { "2014", "2149" };
        public override string ValidarBandeira()    
        {
            return "O cartão é do tipo EnRoute.";
        }

    }
}