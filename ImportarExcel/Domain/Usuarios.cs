using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Domain
{
    public class Usuarios
    {
        [Key]
        public string Usuario { get; set; }

        public string Senha { get; set; }
    }
}
