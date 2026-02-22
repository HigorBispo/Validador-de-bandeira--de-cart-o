using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB.obj
{
    public class Express: Cartão
    {
        public override string ValidarBandeira()
        {   
            return "O cartão é do tipo American Express.";
        }

    }
}