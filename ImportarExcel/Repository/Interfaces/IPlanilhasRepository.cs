using ImportarExcel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository.Interfaces
{
    public interface IPlanilhasRepository
    {
        Planilhas Get(int id);
        IList<Planilhas> Get();
        void Adicionar(Planilhas planilhas);
        void Alterar(Planilhas planilhas);
        void Remover(Planilhas planilhas);
    }
}
