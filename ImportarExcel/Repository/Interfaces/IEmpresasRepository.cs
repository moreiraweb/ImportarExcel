using ImportarExcel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository.Interfaces
{
    public interface IEmpresasRepository
    {
        Empresas Get(string nome);
        Empresas Get(int codigo);
        IList<Empresas> Get();
        void Adicionar(Empresas Empresas);
        void Alterar(Empresas Empresas);
        void Remover(Empresas Empresas);
    }
}
