using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB
{
    public class Elo: Cartão
    {
        public override string ValidarBandeira()
        {   
            return "O cartão é do tipo Elo.";
        }
    }
}