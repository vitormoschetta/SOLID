using System;
using Solid.SOLID.DIP.Interfaces;

namespace Solid.SOLID.DIP.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public void Salvar(Usuario usuario)
        {
            Console.WriteLine("Usuario " + usuario.Nome + " salvo com sucesso.");
        }
    }
}