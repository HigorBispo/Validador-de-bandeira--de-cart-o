using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB
{
    public class Discovery : Cartão
    {
        //Validação do cartão Discovery: O número do cartão deve começar com 6011, 622126-622925, 644-649 ou 65 e deve ter 16 dígitos.
        public override string ValidarBandeira()
        {
            return "O cartão é do tipo Discovery.";
        }

    }
}