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
    public static class Efetivo
    {

        //select [EFETIVO DE PESSOAL - MENSAL], F6, F12, F18, F19, F24, F30, F36, F37, F42, F48, F54, F60, F61, F66, F72, F73, F79, F80, F85, F86, F87, F92, F93, F98, F99, F100  from[Efetivo$] where F6<>''
        //select [EFETIVO DE PESSOAL - MENSAL], F6, F12, F18, F24, F30, F36, F42, F48, F54, F60,  F66, F73, F80, F86, F87, F93, F99  from[Efetivo$] where F6<>''
        //select [EFETIVO DE PESSOAL - MENSAL], F6, F12, F24, F30, F42, F48 from[Efetivo$] where F6<>''
        //string sql = "select [EFETIVO DE PESSOAL - MENSAL], f6,f12, f18, trim(f24) from [Efetivo$] where f24<>'' ";

        public static String Sql()
        {
            string sql = "SELECT [EFETIVO DE PESSOAL - MENSAL],  " +
                                "F6, F12, F18, F24, F30, F36, F42, " +
                                "F48, F54, F60, F66, F73, F80, F87, " +
                                "F93, F99 " +
                         "FROM [Efetivo$] WHERE F6<>''";
            //string sql = "select * from [Efetivo$] where F6<>''";
            return sql;
        }
        public static List<CamposBanco> LerPlanilha(string arquivo, int ano, int mes)
        {
            string planilha = "Efetivo";
            string titleEmpresa = "[EFETIVO DE PESSOAL - MENSAL]";
            string sql = string.Empty;
            DataTable result = null;
            List<CamposBanco> lista = new List<CamposBanco>();
            try
            {

                #region Ordem 1

                sql = Generic.MonteSql("110", 1, "F18", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 2

                sql = Generic.MonteSql("111", 2, "F6", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 3

                sql = Generic.MonteSql("112", 3, "F12", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 4

                sql = Generic.MonteSql("120", 4, "F36", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 5

                sql = Generic.MonteSql("121", 5, "F24", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 6

                sql = Generic.MonteSql("122", 6, "F36", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 7

                sql = Generic.MonteSql("130", 7, "F60", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 8

                sql = Generic.MonteSql("131", 8, "F42", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 9

                sql = Generic.MonteSql("132", 9, "F48", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 10

                sql = Generic.MonteSql("133", 10, "F54", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 24

                sql = Generic.MonteSql("410", 24, "F66", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 25

                sql = Generic.MonteSql("411", 25, "F73", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 26

                sql = Generic.MonteSql("412", 26, "F80", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 27

                sql = Generic.MonteSql("413", 27, "F87", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 28

                sql = Generic.MonteSql("414", 28, "F93", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 29

                sql = Generic.MonteSql("415", 29, "F99", planilha, titleEmpresa);
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
