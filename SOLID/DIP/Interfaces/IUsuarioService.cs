namespace Solid.SOLID.DIP.Interfaces
{
    public interface IUsuarioService<Usuario> where Usuario : class
    {
        void Salvar(Usuario usuario);
    }
}