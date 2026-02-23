
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB
{
    public class Mastercard : Cartão
    {
        public static string[] PrefixosMastercard = new string[] { "51", "55", "2221", "2720" };
    
        public override string ValidarBandeira()
        {
                return "O cartão é Mastercard.";
        }

    
    
}
}