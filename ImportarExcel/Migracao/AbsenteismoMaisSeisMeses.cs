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
    public static class AbsenteismoMaisSeisMeses
    {


        public static String Sql()
        {
            string sql = "SELECT [INDICADORES  MENSAIS DE ABSENTEÍSMO - MEDICINA DO TRABALHO _MAIS] AS EMPRESA, " +
                                "F6, F19, F32, F45" +
                         " FROM ['Absent + de  6 meses$'] WHERE F6<>'' ";
           // sql = "select * from ['Absent + de  6 meses$']";
            return sql;
        }
        public static List<CamposBanco> LerPlanilha(string arquivo)
        {
            string planilha = "'Absent + de  6 meses'";
            string titleEmpresa = "[INDICADORES  MENSAIS DE ABSENTEÍSMO - MEDICINA DO TRABALHO _MAIS]";
            string sql = string.Empty;
            DataTable result = null;
            List<CamposBanco> lista = new List<CamposBanco>();

            var AnoMes = Generic.GetMesAno(arquivo);
            int ano = int.Parse(AnoMes[0]);
            string mes = AnoMes[1];

            try
            {

                #region Ordem 51

                sql = Generic.MonteSql("614", 51, "F6", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 52

                sql = Generic.MonteSql("615", 52, "F19", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 53

                sql = Generic.MonteSql("616", 53, "F32", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 54

                sql = Generic.MonteSql("617", 54, "F45", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

            
                return lista;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

       

    


    }
}
