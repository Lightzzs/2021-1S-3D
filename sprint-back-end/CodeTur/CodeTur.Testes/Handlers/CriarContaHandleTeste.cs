using CodeTur.Comum.Commands;
using CodeTur.Dominio.Commands.Usuario;
using CodeTur.Dominio.Handlers.Usuarios;
using CodeTur.Testes.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTur.Testes.Handlers
{
    public class CriarContaHandleTeste
    {
        [Fact]
        public void DeveRetornarCasoDadosDoHandleSejamValidos()
        {
            var command = new CriarContaCommand();
            command.Nome = "Priscila";
            command.Email = "pri@email.com";
            command.Senha = "1234567890";
            command.TipoUsuario = CodeTur.Comum.EnTipoUsuario.Admin;

            var handle = new CriarContaHandle(new FakeUsuarioRepositorio());

            var resultado = (GenericCommandResult)handle.Handler(command);

            Assert.True(resultado.Sucesso, "Usuário válido");
        }

    }
}
