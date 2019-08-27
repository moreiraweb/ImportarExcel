using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Domain
{
    public  class DePara
    {
        [Key]
        public virtual int Id { get; set; }
       
        public virtual int IdPlanilha { get; set; }

        public virtual string CampoPlanilha { get; set; }
        public virtual string CampoBancoDados { get; set; }
    }
}
