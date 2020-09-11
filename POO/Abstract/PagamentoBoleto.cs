using System;

namespace Solid.POO.Abstract
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(decimal valor) : base(valor)
        {
        }

        public override void Validar()
        {
            Console.WriteLine("Pagamento Boleto Validado.");
        }
    }
}