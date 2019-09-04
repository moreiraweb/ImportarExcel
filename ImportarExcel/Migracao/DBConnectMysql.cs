using ImportarExcel.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Migracao
{
   public class DBConnectMysql
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string nomeTabela;

        public DBConnectMysql(string server, string database, string uid, string password, string nomeTabela)
        {
         
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;
            this.nomeTabela = nomeTabela;

            Initialize();
        }

        private void Initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        throw new Exception("Cannot connect to server.  Contact administrator");
                    case 1045:
                        throw new Exception("Invalid username/password, please try again");
                }
                return false;
            }
        }

        
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public void Insert(List<CamposBanco> lista)
        {
            string query = "INSERT INTO "+ nomeTabela + " (CDDISCRI, CDEMPRESA, ORDEM, ANO, CDMES, QTD) VALUES ";

            var totalItens = lista.Count();
            int i = 1;
            foreach (var item in lista)
            {
                query += "('" + item.CODDISCRI + "', '" + item.CODEMPRESA + "','" + item.ORDEM + "','" + item.ANO + "','" + item.CDMES + "','" + item.QTD + "')";

                if (i != totalItens)
                {
                    query += ",";
                }

                i++;
            }

            query += ";";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

     
        public List<CamposBanco> Select()
        {
            string query = "SELECT * FROM " + nomeTabela;

            CamposBanco camposBanco = null;
            List<CamposBanco> list = new List<CamposBanco>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    camposBanco = new CamposBanco();
                    if (dataReader["CDDISCRI"] != DBNull.Value) camposBanco.CODDISCRI = Convert.ToInt32(dataReader["CDDISCRI"]);
                    if (dataReader["CDEMPRESA"] != DBNull.Value) camposBanco.CODEMPRESA = Convert.ToInt32(dataReader["CDEMPRESA"]);
                    if (dataReader["ORDEM"] != DBNull.Value) camposBanco.ORDEM = Convert.ToInt32(dataReader["ORDEM"]);
                    if (dataReader["ANO"] != DBNull.Value) camposBanco.ANO = Convert.ToInt32(dataReader["ANO"]);
                    if (dataReader["CDMES"] != DBNull.Value) camposBanco.CDMES = Convert.ToInt32(dataReader["CDMES"]);
                    if (dataReader["QTD"] != DBNull.Value) camposBanco.QTD = Convert.ToInt32(dataReader["QTD"]);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                throw new Exception("Error , unable to backup!");
            }
        }


        public void Restore()
        {
            try
            {
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                throw new Exception("Error , unable to Restore!");
            }
        }
    }
}
