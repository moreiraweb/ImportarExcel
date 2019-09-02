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
    public static class AcidenteProprio
    {


        public static String Sql()
        {
            string sql = "SELECT [INDICADORES MENSAIS DE ACIDENTES DO TRABALHO_EFETIVO PRÓPRIO    ] AS EMPRESA, " +
                                "F9, F16, F23, F30, F37, F44, F51, F62, F69, F76, F82, F88, F94 " +
                         " FROM ['Acidentes Próprio$'] WHERE F6<>'' ";
            //sql = "SELECT * FROM ['Acidentes Próprio$'] WHERE F6<>''";
            return sql;
        }
        public static List<CamposBanco> LerPlanilha(string arquivo, int ano, int mes)
        {
            string planilha = "'Acidentes Próprio'";
            string titleEmpresa = "[INDICADORES MENSAIS DE ACIDENTES DO TRABALHO_EFETIVO PRÓPRIO    ]";
            string sql = string.Empty;
            DataTable result = null;
            List<CamposBanco> lista = new List<CamposBanco>();

            try
            {
                #region Ordem 55 formula =SUM(CPT+SPT+FATAIS)

                sql = Generic.MonteSql("710", 55, "F23", planilha, titleEmpresa, "F9,F16,F23");
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes, true, 3);

                #endregion

                #region Ordem 56

                sql = Generic.MonteSql("711", 56, "F9", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 57

                sql = Generic.MonteSql("712", 57, "F16", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 58

                sql = Generic.MonteSql("713", 58, "F23", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 59 formula =SOMA ACIDENTE TRAJETO(CPT+SPT+FATAIS)

                sql = Generic.MonteSql("714", 59, "F44", planilha, titleEmpresa, "F30,F37,F44");
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes, true, 3);

                #endregion

                #region Ordem 60

                sql = Generic.MonteSql("715", 60, "F30", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 61

                sql = Generic.MonteSql("716", 61, "F37", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 62

                sql = Generic.MonteSql("717", 62, "F44", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 64

                sql = Generic.MonteSql("726", 64, "F51", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 65

                sql = Generic.MonteSql("719", 65, "F62", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 66

                sql = Generic.MonteSql("720", 66, "F69", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 67

                sql = Generic.MonteSql("721", 67, "F76", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 68

                sql = Generic.MonteSql("722", 68, "F82", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 69

                sql = Generic.MonteSql("723", 69, "F88", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 71

                sql = Generic.MonteSql("725", 71, "F94", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 70 //Formula  =((HORAS TRABALHADAS)*1000000/NUMERO ACIDENTES) ((F3*1000000)/(F9,F16,F23,F30,F37,F44))

                sql = Generic.MonteSql("724", 70, "F3", planilha, titleEmpresa, "F9,F16,F23,F30,F37,F44");
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes, true, 6, true);

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
