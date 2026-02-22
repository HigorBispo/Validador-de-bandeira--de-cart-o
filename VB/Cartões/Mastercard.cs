
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB
{
    public class Mastercard : Cartão
    {
        public override string ValidarBandeira()
        {
            string numeroStr = Numero.ToString();
            if (numeroStr.StartsWith("5") && (numeroStr.Length == 16))
            {
                return "O cartão é Mastercard.";
            }
            else
            {
                return "Bandeira do cartão desconhecida.";
            }
        }

    }
}