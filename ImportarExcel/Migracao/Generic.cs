using ImportarExcel.Domain;
using ImportarExcel.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarExcel.Migracao
{
    public static class Generic
    {
        public static string MonteSql(string classificacao, int ordem, string campoExcel, string planilha, string titleEmpresa)
        {
            return "SELECT " + classificacao + " as CODDISCRI, " +
                    titleEmpresa + " AS EMPRESA, " +
                    ordem + " as Ordem, " +
                    campoExcel + " as QTD " +
                   "FROM[" + planilha + "$] where " + campoExcel + "<>''";
        }


        public static List<CamposBanco> PreencherObjeto(List<CamposBanco> listaCampo, DataTable result, int ano, int mes)
        {

            try
            {
                EmpresasRepository empresasRepository = new EmpresasRepository();
                CamposBanco camposBanco;
                foreach (var item in result.Rows)
                {
                    if (((DataRow)item).ItemArray[1].ToString() != "")
                    {
                        var empresa = empresasRepository.Get(((DataRow)item).ItemArray[1].ToString());
                        if (empresa == null)
                        {
                            continue;
                        }
                        else
                        {
                            camposBanco = new CamposBanco();
                            camposBanco.CODDISCRI = int.Parse(((DataRow)item).ItemArray[0].ToString());
                            camposBanco.CODEMPRESA = empresa.Codigo;
                            camposBanco.ORDEM = int.Parse(((DataRow)item).ItemArray[2].ToString());
                            camposBanco.ANO = ano;
                            camposBanco.CDMES = mes;
                            camposBanco.QTD = double.Parse(((DataRow)item).ItemArray[3].ToString());
                            listaCampo.Add(camposBanco);
                        }

                    }
                }
                return listaCampo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public static void MigrarDados(List<CamposBanco> lista)
        {
            ParametrosRepository parametrosRepository = new ParametrosRepository();
            var parametros = parametrosRepository.Get().FirstOrDefault();


            DBConnectMysql dBConnectMysql = new DBConnectMysql(parametros.Server, parametros.DataBase, parametros.Usuario, parametros.Senha);

            dBConnectMysql.Insert(lista);

           
        }
    }
}
