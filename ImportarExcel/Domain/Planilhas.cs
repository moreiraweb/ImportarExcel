using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImportarExcel.Domain
{
    //[Table(Name = "Planilhas")]
    public class Planilhas
    {
       //[Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public virtual int Id { get; set; }

        //[Column(Name = "EmpName", DbType = "VARCHAR")]
        public virtual string Descricao { get; set; }

      

    }
}
