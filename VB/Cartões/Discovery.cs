using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB
{


    public class Discovery : Cartão
    {
        public static string[] prefixosDiscovery = { "6011", "65" , "644", "645", "646", "647", "648", "649" };
        public override string ValidarBandeira()
        {
           return "O cartão é do tipo Discovery.";

        }

    }
}