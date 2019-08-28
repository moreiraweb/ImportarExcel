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
        public string Server { get; set; }
        public string DataBase { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
