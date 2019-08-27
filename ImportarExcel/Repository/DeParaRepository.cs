using ImportarExcel.Domain;
using ImportarExcel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository
{
    public class DeParaRepository :  IDeParaRepository, IDisposable
    {

        private readonly DatabaseContext context;

        public DeParaRepository()
        {
            this.context = new DatabaseContext();
        }

        public void Adicionar(DePara DePara)
        {
            throw new NotImplementedException();
        }

        public void Alterar(DePara DePara)
        {
            throw new NotImplementedException();
        }

        public DePara Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DePara> Get()
        {
            try
            {
                return context.DeParas
                    .ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public void Remover(DePara DePara)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
