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
    public static class AbsenteismoMaisQuinzeDiasAteSeisMeses
    {


        public static String Sql()
        {
            string sql = "SELECT [INDICADORES MENSAIS DE ABSENTEÍSMO - MEDICINA DO TRABALHO _MAIS] AS EMPRESA, " +
                                "F6, F19, F32, F45 " +
                         " FROM ['Absenteísmo até 15 dias$'] WHERE F6<>'' ";
            //sql = "select * from ['Absent + 15 dias e até 6 meses $']";
            return sql;
        }
        public static List<CamposBanco> LerPlanilha(string arquivo, int ano, int mes)
        {
            string planilha = "'Absent + 15 dias e até 6 meses '";
            string titleEmpresa = "[INDICADORES MENSAIS DE ABSENTEÍSMO - MEDICINA DO TRABALHO _MAIS]";
            string sql = string.Empty;
            DataTable result = null;
            List<CamposBanco> lista = new List<CamposBanco>();

            try
            {

                #region Ordem 45

                sql = Generic.MonteSql("610", 45, "F6", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 46

                sql = Generic.MonteSql("611", 46, "F19", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 47

                sql = Generic.MonteSql("612", 47, "F32", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 48

                sql = Generic.MonteSql("613", 48, "F45", planilha, titleEmpresa);
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
