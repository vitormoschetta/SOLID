using System;
using Solid.BoasPraticas.Value_Objects.ValueObjects;

namespace Solid.BoasPraticas.Value_Objects
{
    public class Usuario
    {
        public Usuario(string nome, string email)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = new Email(email);
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
    }
}