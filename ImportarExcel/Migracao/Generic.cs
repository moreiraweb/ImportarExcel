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
        public static string MonteSql(string classificacao,
                                      int ordem,
                                      string campoExcel,
                                      string planilha,
                                      string titleEmpresa,
                                      string CamposSoma = "")
        {
            string camposParaSoma = ", '' as SOMA";

            //verifica se a planilha possui espaços
            if (planilha.IndexOf("'") == -1)
                planilha = planilha + "$";
            else
                planilha = "'" + planilha.Replace("'", "") + "$'";


            string sql = "SELECT " + classificacao + " as CODDISCRI, " +
                                titleEmpresa + " AS EMPRESA, " +
                                ordem + " as Ordem, " +
                                campoExcel + " as QTD " + ((CamposSoma != "") ? "," + CamposSoma : camposParaSoma) +
                               " FROM[" + planilha + "] where " + campoExcel + "<>''";

            return sql;


        }


        public static List<CamposBanco> PreencherObjeto(List<CamposBanco> listaCampo, DataTable result, int ano, string mes, bool fazSoma = false, int qtdCampoSoma = 0, bool fazDivisao = false)
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

                            if (fazSoma)
                            {
                                camposBanco.QTD = 0;
                                for (int i = 1; i <= qtdCampoSoma; i++)
                                {
                                    int indexArray = i + 3;
                                    if (double.TryParse(((DataRow)item).ItemArray[indexArray].ToString(), out var v0))
                                    {
                                        camposBanco.QTD += v0;
                                    }
                                   
                                }

                                if (fazDivisao)
                                {
                                    //index 3 = F3
                                    if (double.TryParse(((DataRow)item).ItemArray[3].ToString(), out var v1))
                                    {
                                        if (camposBanco.QTD > 0)
                                            camposBanco.QTD = (v1 * 1000000) / camposBanco.QTD;
                                    }
                                }

                            }
                            else
                            {
                                if (double.TryParse(((DataRow)item).ItemArray[3].ToString(), out var v1))
                                    camposBanco.QTD = v1;
                                else
                                    camposBanco.QTD = 0;
                            }

                            
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


        public static string[] GetMesAno(string arquivo)
        {
            string[] AnoMes = new string[2];

            string sql = "select f4 from[Empresa$] where f4<>''";

            var result = new DaoGenerico().GetDados(sql, arquivo);

            int i = 1;
            foreach (var item in result.Rows)
            {
                if (i == 1)
                    AnoMes[0] = ((DataRow)item).ItemArray[0].ToString();
                else if (i == 2)
                {

                    Mes mes = (Mes)System.Enum.Parse(typeof(Mes), ((DataRow)item).ItemArray[0].ToString().Trim().ToUpper());

                    AnoMes[1] = Convert.ToInt32(mes).ToString().PadLeft(2, '0');
                }
                else
                    break;

                i++;
            }

            return AnoMes;
        }


        public static void MigrarDados(List<CamposBanco> lista)
        {
            ParametrosRepository parametrosRepository = new ParametrosRepository();
            var parametros = parametrosRepository.Get().FirstOrDefault();


            DBConnectMysql dBConnectMysql = new DBConnectMysql(parametros.Server, parametros.DataBase, parametros.Usuario, parametros.Senha, parametros.NomeTabela);

            dBConnectMysql.Insert(lista);


        }


    }
}
