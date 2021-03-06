using CodeTur.Comum.Commands;
using CodeTur.Comum.Handlers.Contracts;
using CodeTur.Dominio.Commands.Usuario;
using CodeTur.Dominio.Repositorios;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Dominio.Handlers.Usuarios
{
    public class CriarContaHandle : Notifiable<Notification>, IHandler<CriarContaCommand>
    {
        private IUsuarioRepositorio _usuarioRepositorio;

        public CriarContaHandle(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public ICommandResult Handler(CriarContaCommand command)
        {
            command.Validar();

            if (!command.IsValid)
            {
                return new GenericCommandResult
                    (
                        false,
                        "Informe corretamente os dados de usuário",
                        command.Notifications
                    );
            }

            var usuarioExiste = _usuarioRepositorio.BuscarPorEmail(command.Email);
            if (usuarioExiste != null)
                return new GenericCommandResult(false, "Email já cadastrado", "Informe outro email");

            Usuario u1 = new Usuario
                (
                    command.Nome,
                    command.Email,
                    command.Senha,
                    command.TipoUsuario
                );

            if (!u1.IsValid)
                return new GenericCommandResult(false, "Dados de usuário inválidos", u1.Notifications);

            _usuarioRepositorio.Adicionar(u1);

            return new GenericCommandResult(true, "Usuário Criado", "Token");
        }
    }
}
