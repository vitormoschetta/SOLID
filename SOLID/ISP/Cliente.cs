using Solid.SOLID.ISP.Contract;

namespace Solid.SOLID.ISP
{
    public class Cliente : IEndereco
    {
        public string Cep { get; set; }


        public void ValidarEndereco() // => Não preciso desse método no Cliente. Logo estou ferindo o princípio de Segregação por interface.
        {
            throw new System.NotImplementedException();
        }
    }
}