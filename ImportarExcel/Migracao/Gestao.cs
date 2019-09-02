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
    public static class Gestao
    {
        //SELECT [INDICADORES MENSAIS DE GESTÃO DE PESSOAL], F6, F12, F19, F26, F32, F39, F46, F55, F64, F73, F80, F89 FROM [Gestão$]
        //SELECT [INDICADORES MENSAIS DE GESTÃO DE PESSOAL] AS EMPRESA, F6, F12, F19, F26, F32, F39, F46, F55, F64, F73, F80, F89 FROM [Gestão$] WHERE F6<>''
        public static String Sql()
        {
            string sql = "SELECT [INDICADORES MENSAIS DE GESTÃO DE PESSOAL] AS EMPRESA, " +
                                 "11 as ORDEM11, F6, " +
                                 "13 as ORDEM13, F12, " +
                                 "14 AS ORDEM14, F19, " +
                                 "12 AS ORDEM12, F26, " +
                                 "16 AS ORDEM16, F32, " +
                                 "17 AS ORDEM17, F39, " +
                                 "18 AS ORDEM18, F46, " +
                                 "20 AS ORDEM20, F55, " +
                                 "21 AS ORDEM21, F64, " +
                                 "22 AS ORDEM22, F73, " +
                                 "22_2 AS ORDEM22_2, F80, " +
                                 "23 AS ORDEM23, F89 " +
                         " FROM [Gestão$] WHERE F6<>''";
            //sql = "select * FROM [Gestão$] WHERE F6<>''";
            return sql;
        }
        public static List<CamposBanco> LerPlanilha(string arquivo, int ano, int mes)
        {
            string planilha = "Gestão";
            string titleEmpresa = "[INDICADORES MENSAIS DE GESTÃO DE PESSOAL]";
            string sql = string.Empty;
            DataTable result = null;
            List<CamposBanco> lista = new List<CamposBanco>();
            try
            {

                #region Ordem 11

                sql = Generic.MonteSql("206", 11, "F6", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 13

                sql = Generic.MonteSql("215", 13, "F12", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 14

                sql = Generic.MonteSql("209", 14, "F19", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 12

                sql = Generic.MonteSql("207", 12, "F26", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 16

                sql = Generic.MonteSql("211", 16, "F32", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 17

                sql = Generic.MonteSql("212", 17, "F39", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 18

                sql = Generic.MonteSql("326", 18, "F46", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 20

                sql = Generic.MonteSql("328", 20, "F55", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 21

                sql = Generic.MonteSql("329", 21, "F64", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 22

                sql = Generic.MonteSql("330", 22, "F73", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 22_2

                sql = Generic.MonteSql("330", 22, "F80", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 23

                sql = Generic.MonteSql("331", 23, "F89", planilha, titleEmpresa);
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
