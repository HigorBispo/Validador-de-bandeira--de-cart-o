using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VB
{
    // A classe Cartão é a classe base para os diferentes tipos de cartões de crédito. Ela possui uma propriedade Numero e um método virtual ValidarBandeira que pode ser sobrescrito pelas classes derivadas para implementar a lógica específica de validação de cada bandeira.

    //  os cartões serão Mastercard, Visa, American Express e Discover. Cada uma dessas classes irá herdar da classe Cartão e implementar a lógica de validação de acordo com as regras específicas de cada bandeira.
    
    // Vamos criar diferentes Arquivos para cada tipo de cartão, onde cada um irá herdar da classe Cartão e implementar a lógica de validação de acordo com as regras específicas de cada bandeira.

    //isso facilita a manutenção do código, pois cada tipo de cartão tem sua própria classe e lógica de validação, tornando o código mais organizado e modular. Além disso, a classe base Cartão pode conter propriedades e métodos comuns a todos os tipos de cartões, evitando a duplicação de código.

    //melhor do que utilizar todos os cartoes em um unico arquivo, pois isso pode tornar o código confuso e difícil de manter. Separar cada tipo de cartão em arquivos diferentes torna o código mais organizado e fácil de entender, além de facilitar a manutenção e a adição de novos tipos de cartões no futuro.    
    //porem

    public class Cartão()
    {
        public int Numero { get; set; }

        public virtual string ValidarBandeira()
        {
            return "Bandeira do cartão desconhecida.";
        }

    }
    
}