using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Domain
{
   public class Parametros
    {
        [Key]
        public int Id { get; set; }
        public String NomeBancoMigracao { get; set; }
        public string StringConexaoBancoMigracao { get; set; }
    }
}
