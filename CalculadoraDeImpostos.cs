using System;
using Xperiments.DesignPatterns.Decorator.Models;

namespace Xperiments.DesignPatterns.Decorator
{

    public class CalculadoraDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            var x = imposto.Calcula(orcamento);
            Console.WriteLine(x);
            
        }

    }

}