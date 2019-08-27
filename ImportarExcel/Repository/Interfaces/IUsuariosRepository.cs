using ImportarExcel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Repository.Interfaces
{
    public interface IUsuariosRepository
    {
        Usuarios Get(string id);
        IList<Usuarios> Get();
        void Adicionar(Usuarios Usuarios);
        void Alterar(Usuarios Usuarios);
        void Remover(Usuarios Usuarios);
    }
}
