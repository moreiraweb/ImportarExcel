using ImportarExcel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository.Interfaces
{
    public interface IParametrosRepository
    {
        Parametros Get(int id);
        IList<Parametros> Get();
        void Adicionar(Parametros Parametros);
        void Alterar(Parametros Parametros);
        void Remover(Parametros Parametros);
    }
}
