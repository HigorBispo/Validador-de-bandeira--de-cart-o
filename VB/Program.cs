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
