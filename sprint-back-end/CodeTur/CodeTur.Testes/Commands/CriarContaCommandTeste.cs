using CodeTur.Dominio.Commands.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTur.Testes.Commands
{
    public class CriarContaCommandTeste
    {
        [Fact]
        public void DeveRetornarSucessoSeDadosForemValidos()
        {
            var command = new CriarContaCommand();
            command.Nome = "Paulo"; 
            command.Email = "paulo@email.com";
            command.Senha = "36553184231631584";
            command.TipoUsuario = CodeTur.Comum.EnTipoUsuario.Admin;

            command.Validar();

            Assert.True(command.IsValid, "Os dados foram preenchidos corretamente");

        }
    }
}
