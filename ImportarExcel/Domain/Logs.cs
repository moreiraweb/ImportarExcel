using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Domain
{
    public class Logs
    {
        [Key]
        public int Id { get; set; }

       
        public string IdUsuario { get; set; }
        public DateTime DataHoraEnvio { get; set; }
        public string NomeDocumento { get; set; }
        public string Status { get; set; }
    }
}
