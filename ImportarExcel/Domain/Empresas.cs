using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Domain
{
    public class Empresas
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}
