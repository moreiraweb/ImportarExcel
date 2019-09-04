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
    public static class AbsenteismoAteQuinzeDias
    {

        //select [AbsenteismoQuinzeDias DE PESSOAL - MENSAL], F6, F12, F18, F19, F24, F30, F36, F37, F42, F48, F54, F60, F61, F66, F72, F73, F79, F80, F85, F86, F87, F92, F93, F98, F99, F100  from[Absenteísmo até 15 dias$] where F6<>''
        //select [AbsenteismoQuinzeDias DE PESSOAL - MENSAL], F6, F12, F18, F24, F30, F36, F42, F48, F54, F60,  F66, F73, F80, F86, F87, F93, F99  from[Absenteísmo até 15 dias$] where F6<>''
        //select [AbsenteismoQuinzeDias DE PESSOAL - MENSAL], F6, F12, F24, F30, F42, F48 from[Absenteísmo até 15 dias$] where F6<>''
        //string sql = "select [AbsenteismoQuinzeDias DE PESSOAL - MENSAL], f6,f12, f18, trim(f24) from [Absenteísmo até 15 dias$] where f24<>'' ";

        public static String Sql()
        {
            string sql = "SELECT [INDICADORES MENSAIS DE ABSENTEÍSMO - MEDICINA DO TRABALHO_ATÉ 15] AS EMPRESA, " +
                                "F6, F12, F24, F37, F50, F63, F76, F88 " +
                         " FROM ['Absenteísmo até 15 dias$'] WHERE F6<>'' ";
            
            return sql;
        }
        public static List<CamposBanco> LerPlanilha(string arquivo)
        {
            string planilha = "'Absenteísmo até 15 dias'";
            string titleEmpresa = "[INDICADORES MENSAIS DE ABSENTEÍSMO - MEDICINA DO TRABALHO_ATÉ 15]";
            string sql = string.Empty;
            DataTable result = null;
            List<CamposBanco> lista = new List<CamposBanco>();

            var AnoMes = Generic.GetMesAno(arquivo);
            int ano = int.Parse(AnoMes[0]);
            string mes = AnoMes[1];

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

                #region Ordem 35

                sql = Generic.MonteSql("513", 35, "F24", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 36

                sql = Generic.MonteSql("514", 36, "F37", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 38

                sql = Generic.MonteSql("516", 38, "F50", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 39

                sql = Generic.MonteSql("517", 39, "F63", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 41

                sql = Generic.MonteSql("519", 41, "F76", planilha, titleEmpresa);
                result = new DaoGenerico().GetDados(sql, arquivo);
                Generic.PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 42

                sql = Generic.MonteSql("520", 42, "F88", planilha, titleEmpresa);
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
