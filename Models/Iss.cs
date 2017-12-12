
namespace Xperiments.DesignPatterns.Decorator.Models
{

    public class ISS : Imposto
    {
        public ISS() : base() { }
        public ISS(Imposto outroImposto) : base(outroImposto){ }
            
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6 + CalculoDoOutroImposto(orcamento);
        }

    }

}