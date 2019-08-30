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
    public static class AbsenteismoQuinzeDias
    {

        //select [AbsenteismoQuinzeDias DE PESSOAL - MENSAL], F6, F12, F18, F19, F24, F30, F36, F37, F42, F48, F54, F60, F61, F66, F72, F73, F79, F80, F85, F86, F87, F92, F93, F98, F99, F100  from[Absenteísmo até 15 dias$] where F6<>''
        //select [AbsenteismoQuinzeDias DE PESSOAL - MENSAL], F6, F12, F18, F24, F30, F36, F42, F48, F54, F60,  F66, F73, F80, F86, F87, F93, F99  from[Absenteísmo até 15 dias$] where F6<>''
        //select [AbsenteismoQuinzeDias DE PESSOAL - MENSAL], F6, F12, F24, F30, F42, F48 from[Absenteísmo até 15 dias$] where F6<>''
        //string sql = "select [AbsenteismoQuinzeDias DE PESSOAL - MENSAL], f6,f12, f18, trim(f24) from [Absenteísmo até 15 dias$] where f24<>'' ";

        public static String Sql()
        {
            string sql = "SELECT [INDICADORES MENSAIS DE ABSENTEÍSMO - MEDICINA DO TRABALHO_ATÉ 15] AS EMPRESA, " +
                                "F6, F12, F18, F24, F31, F37, F44, F50, F57, F63, F70, F76, F83, F88, F95 " +
                         " FROM ['Absenteísmo até 15 dias$'] WHERE F6<>'' ";
            
            return sql;
        }
        public static List<CamposBanco> LerPlanilha(string arquivo, int ano, int mes)
        {
            string planilha = "'Absenteísmo até 15 dias'";
            string titleEmpresa = "[INDICADORES MENSAIS DE ABSENTEÍSMO - MEDICINA DO TRABALHO_ATÉ 15]";
            string sql = string.Empty;
            DataTable result = null;
            List<CamposBanco> lista = new List<CamposBanco>();

            try
            {

                #region Ordem 32

                sql = Generic.MonteSql("510", 32, "F6", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 33

                sql = Generic.MonteSql("511", 33, "F12", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem xxx (Não definida na planilha provavel 34)

                sql = Generic.MonteSql("234", 000, "F18", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 34

                sql = Generic.MonteSql("513", 35, "F24", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 35

                sql = Generic.MonteSql("513", 35, "F31", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 6

                sql = Generic.MonteSql("122", 6, "F42", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 7

                sql = Generic.MonteSql("130", 7, "F73", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 8

                sql = Generic.MonteSql("131", 8, "F54", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 9

                sql = Generic.MonteSql("132", 9, "F60", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 10

                sql = Generic.MonteSql("133", 10, "F66", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion


                
                foreach (var item in lista)
                {
                    
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

       

    


    }
}
