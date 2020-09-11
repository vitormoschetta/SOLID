using System;
using Solid.BoasPraticas.Value_Objects;
using Solid.POO.Abstract;
using Solid.SOLID.DIP.Interfaces;
using Solid.SOLID.DIP.Repositorio;
using Solid.SOLID.DIP.Services;
using Solid.SOLID.LSP;
using Solid.SOLID.OCP;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  BoasPraticas - ValueObjects
            try
            {
                //Usuario user = new Usuario("Vitor", "");                              // => instancia que gera exceção
                Usuario user = new Usuario("Vitor", "vitormoschetta@gmail.com");        // => instancia com validação positiva  

                Console.WriteLine("Nome: " + user.Nome + " / E-mail: " + user.Email.EnderecoEmail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion


            #region  POO - Abstract
            try
            {
                decimal valor = 50;
                PagamentoBoleto pb = new PagamentoBoleto(valor);
                pb.Validar();

                PagamentoCartao pc = new PagamentoCartao(valor);
                pc.Validar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion


            #region  SOLID - O
            try
            {
                PessoaFisica pf = new PessoaFisica("Vitor", "00000000000");
                Console.WriteLine("Nome: " + pf.Nome + " / CPF: " + pf.CPF);

                PessoaJuridica pj = new PessoaJuridica("Vitor SA", "00000000000-0001-00");
                Console.WriteLine("Nome: " + pj.Nome + " / CPF: " + pj.CNPJ);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion


            #region  SOLID - L
            Veiculo veiculo = new Veiculo();
            veiculo.LigarMotor();
            veiculo.Acelerar();

            // Se substituir o codigo acima por uma classe derivada de Veículo, continua a funcionar?:

            Barco barco = new Barco();
            barco.LigarMotor();
            barco.Acelerar();
            #endregion


            #region  SOLID - D
            var usuario = new SOLID.DIP.Usuario("Admin", "123456");
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuarioService = new UsuarioServices(usuarioRepositorio); // => Injetamos o repositório via construtor
            usuarioService.Salvar(usuario);

            // Posso mudar o repositório quando quiser, pois estou aplicando a inversão de dependência:
            var outroRepositorio = new OutroRepositorio();
            usuarioService = new UsuarioServices(outroRepositorio); // => Injetamos o repositório via construtor
            usuarioService.Salvar(usuario);
            #endregion

        }
    }
}