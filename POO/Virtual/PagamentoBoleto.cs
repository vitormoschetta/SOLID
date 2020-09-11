using System;

namespace Solid.POO.Virtual
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(decimal valor) : base(valor)
        {
        }

        public override void Validar() // Sobrescreve o método Validar da classe base
        {
            Console.WriteLine("Pagamento com Cartão Validado");
        }
    }
}