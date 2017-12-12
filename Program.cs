using System;
using Xperiments.DesignPatterns.Decorator.Models;

namespace Xperiments.DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItens(new Item("Caneta", 20));
            orcamento.AdicionaItens(new Item("Lápis", 15));
            orcamento.AdicionaItens(new Item("Borracha", 3));
            orcamento.AdicionaItens(new Item("Mochila", 300));

            CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();
            Imposto iss = new ICMS(new IBB());
        
            calculadora.RealizaCalculo(orcamento, iss);
            
        }
    }
}
