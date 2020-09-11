using System;

namespace Solid.SOLID.LSP
{
    public class Barco : Veiculo
    {
        public override void LigarMotor()
        {
            Console.WriteLine("Ligou o Motor do Barco");
        }
    }
}