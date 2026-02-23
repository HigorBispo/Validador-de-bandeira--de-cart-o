using System;
using VB;
using VB.Cartões;
using VB.obj;

// Este projeto sera para validar a bandeira do cartao de credito, ou seja, descobrir se o cartao e Visa, Mastercard, etc.

//Vamos utilizar POO para treinar arquitetura de software, e tambem para treinar a implementacao de classes, objetos, heranca, etc.

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o número do cartão:");
        string numeroCartao = Console.ReadLine();


        // Aqui, dependendo do número do cartão, podemos criar uma instância da classe correspondente (Visa, Mastercard, etc.).

        //Elo
        if (Elo.prefixosElo.Any(p => numeroCartao.StartsWith(p)) && numeroCartao.Length >= 4)
        {
            Elo elo = new Elo();
            Console.WriteLine(elo.ValidarBandeira());
        }

        // Visa
        else if (numeroCartao.StartsWith("4") && numeroCartao.Length != 4)
        {
            Visa visa = new Visa();
            Console.WriteLine(visa.ValidarBandeira());
        }


        // Mastercard
        else if (Mastercard.PrefixosMastercard.Any(p => numeroCartao.StartsWith(p)))
        {
            Mastercard mastercard = new Mastercard();
            Console.WriteLine(mastercard.ValidarBandeira());
        }


        //American Express
        else if (Express.prefixosExpress.Any(p => numeroCartao.StartsWith(p)))
        {
            Express express = new Express();
            Console.WriteLine(express.ValidarBandeira());
        }

        //HyperCard
        else if (Hypercard.prefixosHyperCard.Any(p => numeroCartao.StartsWith(p)))
        {
            Hypercard hyperCard = new Hypercard();
            Console.WriteLine(hyperCard.ValidarBandeira());
        }

        //Discorvery
        else if (Discovery.prefixosDiscovery.Any(p => numeroCartao.StartsWith(p)))
        {
            Discovery discovery = new Discovery();
            Console.WriteLine(discovery.ValidarBandeira());
        }

        //Aura
        else if (Aura.prefixosAura.Any(p => numeroCartao.StartsWith(p)))
        {
            Aura aura = new Aura();
            Console.WriteLine(aura.ValidarBandeira());
        }

        //Diners Club
        else if (DinersClub.prefixosDinersClub.Any(p => numeroCartao.StartsWith(p)))
        {
            DinersClub dinersClub = new DinersClub();
            Console.WriteLine(dinersClub.ValidarBandeira());
        }

        //EnRoute
        else if (EnRoute.prefixosEnRoute.Any(p => numeroCartao.StartsWith(p)))
        {
            EnRoute enRoute = new EnRoute();
            Console.WriteLine(enRoute.ValidarBandeira());
        }

        //JCB
        else if (JCB.prefixosJCB.Any(p => numeroCartao.StartsWith(p)))
        {
            JCB jcb = new JCB();
            Console.WriteLine(jcb.ValidarBandeira());
        }

        //Voyage
        else if (Voyage.prefixosVoyage.Any(p => numeroCartao.StartsWith(p)))
        {
            Voyage voyage = new Voyage();
            Console.WriteLine(voyage.ValidarBandeira());
        }

        //Caso o número do cartão não corresponda a nenhum dos prefixos conhecidos, podemos exibir uma mensagem de erro ou indicar que a bandeira é desconhecida.
        else
        {
            Console.WriteLine("Bandeira do cartão desconhecida.");
        }
    }
}

//Um readme para o projeto poderia incluir informações sobre as bandeiras de cartão de crédito, os prefixos associados a cada bandeira, e como o programa funciona para validar a bandeira com base no número do cartão.
//
//Exemplo de README:
// validador de bandeira de Cartão de Crédito
// Este projeto é um validador de bandeira de cartão de crédito, que identifica a bandeira do cartão com base no número fornecido pelo usuário. O programa utiliza a Programação Orientada a Objetos (POO) para organizar o código em classes e objetos, representando diferentes bandeiras de cartão de crédito. Ele suporta as seguintes bandeiras:
// - Visa: Cartões que começam com o número 4.
// - Mastercard: Cartões que começam com os números 51 a 55.
// - American Express: Cartões que começam com os números 34 ou 37.
// - Elo: Cartões que começam com os números 4011, 4312, 4389, 4514, 4576, 504175, 506699, 5067, 509, 627780, 636297, 636368.
// - HyperCard: Cartões que começam com os números 606282, 384100, 384140, 384160.
// - Discovery: Cartões que começam com os números 6011, 622126-622925, 644-649, 65.
// - Aura: Cartões que começam com os números 50, 5067, 509, 627780, 636297, 636368.
// - Diners Club: Cartões que começam com os números 300-305, 36, 38.
// - EnRoute: Cartões que começam com os números 2014, 2149
// - JCB: Cartões que começam com os números 3528-3589.
// - Voyage: Cartões que começam com os números 506699, 5067, 509, 627780, 636297, 636368.
// O programa solicita ao usuário que insira o número do cartão de crédito e, em seguida, verifica os prefixos para determinar a bandeira correspondente. Se o número do cartão não corresponder a nenhum dos prefixos conhecidos, o programa informará que a bandeira é desconhecida.