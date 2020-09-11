using Solid.Validacoes;

namespace Solid.POO.Abstract
{
    public abstract class Pagamento : IPagamento
    {
        public Pagamento(decimal valor)
        {
            ValidaArgumento.ValorMinimo(valor, 50, "Valor Mínimo é R$ 50,00");
        }

        public abstract void Validar(); // => A classe derivada será obrigada a implementar este método

    }




    public interface IPagamento
    {
        void Validar();
    }
}