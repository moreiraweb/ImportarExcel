using ImportarExcel.Domain;
using ImportarExcel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository
{
    public class LogsRepository : ILogsRepository, IDisposable
    {

        private readonly DatabaseContext context;

        public LogsRepository()
        {
            this.context = new DatabaseContext();
        }

        public void Adicionar(Logs Logs)
        {
            context.Logs.Add(Logs);
            context.SaveChanges();
        }

        public void Alterar(Logs Logs)
        {
            var emp = context.Logs.Where(x => x.Id == Logs.Id).FirstOrDefault();

            emp.DataHoraEnvio = Logs.DataHoraEnvio;

            context.SaveChanges();
        }

        public Logs Get(int id)
        {
            return context.Logs.FirstOrDefault(x => x.Id == id);
        }

        public IList<Logs> Get()
        {
            try
            {
                return context.Logs.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void Remover(Logs Logs)
        {
            var emp = context.Logs.FirstOrDefault(x => x.Id == Logs.Id);
            context.Logs.Remove(emp);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Logs Get(string nomeDocumento)
        {
            try
            {
                var empresa = context.Logs.FirstOrDefault(x => x.NomeDocumento.ToLower().Contains(nomeDocumento.ToLower()));

                return empresa;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
