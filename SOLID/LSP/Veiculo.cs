using System;

namespace Solid.SOLID.LSP
{
    public class Veiculo
    {
        // Esse método pode ser sobrescrito na classe 'filho', devido a plavra chave 'virtual'
        public virtual void LigarMotor()
        {
            Console.WriteLine("Ligou o motor");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerou");
        }
    }


    public interface IVeiculo
    {
        void LigarMotor() { }
        void Acelerar() { }
    }



}