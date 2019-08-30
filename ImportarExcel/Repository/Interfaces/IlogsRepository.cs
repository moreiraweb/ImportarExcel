using ImportarExcel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository.Interfaces
{
    public interface ILogsRepository
    {
        Logs Get(int id);
        IList<Logs> Get();
        void Adicionar(Logs Logs);
        void Alterar(Logs Logs);
        void Remover(Logs Logs);
    }
}
