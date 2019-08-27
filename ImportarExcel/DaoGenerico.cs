using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel
{
    public class DaoGenerico
    {
        //private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=No;IMEX=1\";";
        //private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=YES\";";
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";";

        public DataTable GetDados(string sql, string arquivo)
        {
            OleDbConnection conexao = null;
            OleDbDataAdapter adapter = null;
            try
            {

                String connString = string.Format(connectionString, arquivo);

                conexao = new OleDbConnection(connString);

                using (adapter = new OleDbDataAdapter(sql, conexao))
                {

                    DataSet ds = new DataSet();

                    adapter.Fill(ds);

                    var table = ds.Tables[0];

                    return table;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public DataTable GetPlanilhas(string arquivo)
        {
            OleDbConnection conexao = null;

            try
            {
                String connString = string.Format(connectionString, arquivo);
                conexao = new OleDbConnection(connString);
                conexao.Open();
                using (conexao)
                {

                    return conexao.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }


    }
}
