namespace Xperiments.DesignPatterns.Decorator.Models
{
        
    public class BRL : TemplateDeImpostoCondicional
    {
        public BRL() : base() { }
        public BRL(Imposto outroImposto) : base(outroImposto){ }
        
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
        
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.7;
        }
        
        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
        
    }
}