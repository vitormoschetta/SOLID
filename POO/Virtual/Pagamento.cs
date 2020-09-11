using System;
using Solid.Validacoes;

namespace Solid.POO.Virtual
{
    public abstract class Pagamento : IPagamento
    {
        public Pagamento(decimal valor)
        {
            ValidaArgumento.ValorMinimo(valor, 50, "Valor Mínimo é R$ 50,00");
        }

        public virtual void Validar() // => A classe derivida PODE, se quiser, sobrescrever este método 
        {
            Console.WriteLine("Pagamento com Cartão Validado");
        }
    }



    public interface IPagamento
    {
        void Validar();
    }
}