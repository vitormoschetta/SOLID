

using Solid.Validacoes;

namespace Solid.BoasPraticas.Value_Objects.ValueObjects
{
    public class Email
    {
        public string EnderecoEmail { get; set; }
        public Email(string email)
        {
            ValidaArgumento.NuloOuVazio(email, "Email inválido.");

            EnderecoEmail = email;
        }
    }

}