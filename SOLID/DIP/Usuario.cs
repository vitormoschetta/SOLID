namespace Solid.SOLID.DIP
{
    public class Usuario
    {
        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}