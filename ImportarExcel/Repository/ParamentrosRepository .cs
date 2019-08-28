using ImportarExcel.Domain;
using ImportarExcel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository
{
    public class ParametrosRepository :  IParametrosRepository, IDisposable
    {
        private readonly DatabaseContext context;

        public ParametrosRepository()
        {
            this.context = new DatabaseContext();
        }

        public void Adicionar(Parametros Parametros)
        {
            context.Parametros.Add(Parametros);
            context.SaveChanges();
        }

        public void Alterar(Parametros Parametros)
        {
            var par = context.Parametros.Where(x => x.Id == Parametros.Id).FirstOrDefault();

            par.Server = Parametros.Server;
            par.DataBase = Parametros.DataBase;
            par.Usuario = Parametros.Usuario;
            par.Senha = Parametros.Senha;
            context.SaveChanges();
        }

        public Parametros Get(int id)
        {
           return context.Parametros.FirstOrDefault(x => x.Id == id);
        }

        public IList<Parametros> Get()
        {
            try
            {
                return context.Parametros.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public void Remover(Parametros Parametros)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
