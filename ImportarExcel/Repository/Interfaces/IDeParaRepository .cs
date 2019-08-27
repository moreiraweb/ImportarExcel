using ImportarExcel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository.Interfaces
{
    public interface IDeParaRepository
    {
        DePara Get(int id);
        IList<DePara> Get();
        void Adicionar(DePara DePara);
        void Alterar(DePara DePara);
        void Remover(DePara DePara);
    }
}
