using System;

namespace Solid.SOLID.LSP
{
    public class Carro : Veiculo
    {
        public override void LigarMotor()
        {
            Console.WriteLine("Ligou o Motor do Carro");
        }

    }
}