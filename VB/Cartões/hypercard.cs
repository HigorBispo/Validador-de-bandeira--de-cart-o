using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB.Cartões
{
    public class hypercard : Cartão
    {
        
        public override string ValidarBandeira()
        {   
            return "O cartão é do tipo Hypercard.";
        }
    }
}