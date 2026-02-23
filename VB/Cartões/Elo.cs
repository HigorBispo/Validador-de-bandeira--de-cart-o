using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace VB
{
    public class Elo : Cartão
    {
        public static string[] prefixosElo = { "4011", "4312", "4389", "4514", "4576", "5041", "5066", "5090", "6277", "6362", "6363" };

        public override string ValidarBandeira()
        {
             return "O cartão é Elo.";
        
        }
    }
}