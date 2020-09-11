using System;
using Solid.SOLID.DIP.Interfaces;

namespace Solid.SOLID.DIP.Repositorio
{
    public class OutroRepositorio : IUsuarioRepositorio
    {
        public void Salvar(Usuario usuario)
        {
            Console.WriteLine("Salvo neste outro repositório");
        }
    }
}