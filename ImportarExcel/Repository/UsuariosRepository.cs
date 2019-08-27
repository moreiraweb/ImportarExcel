using ImportarExcel.Domain;
using ImportarExcel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository
{
    public class UsuariosRepository : IUsuariosRepository, IDisposable
    {

        private readonly DatabaseContext context;

        public UsuariosRepository()
        {
            this.context = new DatabaseContext();
        }

        public void Adicionar(Usuarios Usuarios)
        {
            context.Usuarios.Add(Usuarios);
            context.SaveChanges();
        }

        public void Alterar(Usuarios Usuarios)
        {
            var usr = context.Usuarios.Where(x => x.Usuario == Usuarios.Usuario).FirstOrDefault();

            usr.Usuario = Usuarios.Usuario;
            usr.Senha = Usuarios.Senha;

            context.SaveChanges();
        }

        public Usuarios Get(string usuario)
        {
            return context.Usuarios.FirstOrDefault(x => x.Usuario == usuario);
        }

        public IList<Usuarios> Get()
        {
            try
            {
                return context.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void Remover(Usuarios Usuarios)
        {
            var usr = context.Usuarios.FirstOrDefault(x => x.Usuario == Usuarios.Usuario);
            context.Usuarios.Remove(usr);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
