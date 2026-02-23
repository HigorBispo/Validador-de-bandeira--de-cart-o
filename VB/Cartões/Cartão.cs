using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB
{
    // A classe Cartão é a classe base para os diferentes tipos de cartões de crédito. Ela possui uma propriedade Numero e um método virtual ValidarBandeira que pode ser sobrescrito pelas classes derivadas para implementar a lógica específica de validação de cada bandeira.

    //  os cartões serão Mastercard, Visa, American Express e Discover. Cada uma dessas classes irá herdar da classe Cartão e implementar a lógica de validação de acordo com as regras específicas de cada bandeira.

    public class Cartão()
    {
        public int Numero { get; set; }

        public virtual string ValidarBandeira()
        {
            return "Bandeira do cartão desconhecida.";
        }

    }
    
}