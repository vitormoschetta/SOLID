namespace Solid.SOLID.ISP.Contract
{
    public interface IEndereco
    {
        string Cep { get; set; }


        void ValidarEndereco();
    }
}