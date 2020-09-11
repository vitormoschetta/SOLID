using System;
using Solid.SOLID.ISP.Contract;

namespace Solid.ISP
{
    public class NotaFiscal : IEndereco
    {
        public string Cep { get; set; }

        public void ValidarEndereco()
        {
            Console.WriteLine("Endereço Validado.");
        }
    }
}