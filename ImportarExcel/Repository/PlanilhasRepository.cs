using ImportarExcel.Domain;
using ImportarExcel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository
{
    public class PlanilhasRepository : IPlanilhasRepository, IDisposable
    {

        private readonly DatabaseContext context;

        public PlanilhasRepository()
        {
            this.context = new DatabaseContext();
        }

        public void Adicionar(Planilhas Planilhas)
        {
            context.Planilhas.Add(Planilhas);
            context.SaveChanges();
        }

        public void Alterar(Planilhas Planilhas)
        {
            var par = context.Planilhas.Where(x => x.Id == Planilhas.Id).FirstOrDefault();

            par.Descricao = Planilhas.Descricao;

            context.SaveChanges();
        }

        public Planilhas Get(int id)
        {
            return context.Planilhas.FirstOrDefault(x => x.Id == id);
        }

        public IList<Planilhas> Get()
        {
            try
            {
                return context.Planilhas.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void Remover(Planilhas Planilhas)
        {
            var pla = context.Planilhas.FirstOrDefault(x => x.Id == Planilhas.Id);
            context.Planilhas.Remove(pla);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
