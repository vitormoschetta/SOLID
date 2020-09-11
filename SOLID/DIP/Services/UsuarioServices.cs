using Solid.SOLID.DIP.Interfaces;
using Solid.SOLID.DIP.Repositorio;
using Solid.Validacoes;

namespace Solid.SOLID.DIP.Services
{
    public class UsuarioServices : IUsuarioService<Usuario>
    {
        private IUsuarioRepositorio _repositorio;
        public UsuarioServices(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        // Esse método esta dependendo da implementação de UsuarioRepositorio. 
        // Se quisermos mudar o repositório, teremos que alterar esse método.        
        // Fere o princípio da Inversão de Dependência.
        public void SalvarErrado(Usuario usuario)
        {
            ValidaArgumento.NuloOuVazio(usuario.Nome, "Nome inválido.");
            ValidaArgumento.NuloOuVazio(usuario.Senha, "Senha inválida.");

            var repositorioErrado = new UsuarioRepositorio();
            repositorioErrado.Salvar(usuario);

        }


        // Este método faz referência a abstração do repositório. 
        // Quando quisermos mudar o repositório, basta passar outro repositório na instância do UsuarioServices.
        public void Salvar(Usuario usuario)
        {
            ValidaArgumento.NuloOuVazio(usuario.Nome, "Nome inválido.");
            ValidaArgumento.NuloOuVazio(usuario.Senha, "Senha inválida.");

            _repositorio.Salvar(usuario);
        }
    }
}