using CodeTur.Dominio;
using CodeTur.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Testes.Repositorios
{
    class FakeUsuarioRepositorio : IUsuarioRepositorio
    {
        public void Adicionar(Usuario usuario)
        {
            
        }

        public void Alterar(Usuario usuario)
        {
            
        }

        public void AlterarSenha(Usuario usuario)
        {
            
        }

        public Usuario BuscarPorEmail(string email)
        {
            return null;
        }

        public Usuario BuscarPorId(Guid id)
        {
            return new Usuario("Priscila", "pri@email.com", "0987644132", CodeTur.Comum.EnTipoUsuario.Admin);
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            return new List<Usuario>()
            {
                new Usuario("Priscila", "pri@email.com", "0987644132", CodeTur.Comum.EnTipoUsuario.Admin),
                new Usuario("Paulo", "paulo@email.com", "8461315165", CodeTur.Comum.EnTipoUsuario.Admin)
            };
        }
    }
}
