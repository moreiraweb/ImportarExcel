using ImportarExcel.Domain;
using ImportarExcel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository
{
    public class EmpresasRepository : IEmpresasRepository, IDisposable
    {

        private readonly DatabaseContext context;

        public EmpresasRepository()
        {
            this.context = new DatabaseContext();
        }

        public void Adicionar(Empresas Empresas)
        {
            context.Empresas.Add(Empresas);
            context.SaveChanges();
        }

        public void Alterar(Empresas Empresas)
        {
            var emp = context.Empresas.Where(x => x.Id == Empresas.Id).FirstOrDefault();

            emp.Codigo = Empresas.Codigo;
            emp.Nome = Empresas.Nome;

            context.SaveChanges();
        }

        public Empresas Get(int Id)
        {
            return context.Empresas.FirstOrDefault(x => x.Id == Id);
        }

        public IList<Empresas> Get()
        {
            try
            {
                return context.Empresas.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void Remover(Empresas Empresas)
        {
            var emp = context.Empresas.FirstOrDefault(x => x.Id == Empresas.Id);
            context.Empresas.Remove(emp);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Empresas Get(string nome)
        {
            try
            {
                var empresa = context.Empresas.FirstOrDefault(x => x.Nome.ToLower().Contains(nome.ToLower()));

                return empresa;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
