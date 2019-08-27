using ImportarExcel.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel
{
    public class DatabaseContext : DbContext
    {
        
        public DatabaseContext() :
            base(new SQLiteConnection()
            {
                //ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "C:\\Desenvolvimento\\Moreiraweb\\ImportarExcel\\db\\db.db", ForeignKeys = true }.ConnectionString
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "C:\\Testes\\ImportarExcel\\db\\db.db", ForeignKeys = true }.ConnectionString
            }, true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Planilhas> Planilhas { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<DePara> DeParas { get; set; }
        public DbSet<Parametros> Parametros { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Empresas> Empresas { get; set; }


    }
}
