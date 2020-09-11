using System;

namespace Solid.POO.Abstract
{
    public class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(decimal valor) : base(valor)
        {
        }

        public override void Validar()
        {
            Console.WriteLine("Pagamento CArtão Validado.");
        }
    }
}