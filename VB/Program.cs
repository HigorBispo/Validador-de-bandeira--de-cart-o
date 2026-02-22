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
       //vamos instanciar um objeto de cada tipo de cartao, e chamar o metodo ValidarBandeira para verificar a bandeira do cartao.
    Cartão cartão = new Cartão();
    Console.WriteLine("Digite o número do cartão:");
    cartão.Numero = int.Parse(Console.ReadLine());

    //vamos verificar a bandeira do cartao utilizando o metodo ValidarBandeira, e imprimir o resultado na tela.
    //Utilizando Switch para verificar a bandeira do cartao, e chamar o metodo ValidarBandeira de acordo com a bandeira do cartao.
    //Utilzando o numero do cartao para verificar a bandeira, e chamar o metodo ValidarBandeira de acordo com a bandeira do cartao.
    
   
}}