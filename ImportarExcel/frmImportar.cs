using ImportarExcel.Domain;
using ImportarExcel.Repository;
using ImportarExcel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportarExcel
{
    public partial class frmImportar : Form
    {

        public frmImportar()
        {
            InitializeComponent();

        }



        private void LerExcel(string arquivo, string planilha, string sqlCustom = "")
        {


            string sql;
            if (sqlCustom == "")
                sql = "select * from [" + planilha + "] ";
            else
                sql = sqlCustom;
            //select [EFETIVO DE PESSOAL - MENSAL], F6, F12, F18, F19, F24, F30, F36, F37, F42, F48, F54, F60, F61, F66, F72, F73, F79, F80, F85, F86, F87, F92, F93, F98, F99, F100  from[Efetivo$] where F6<>''
            //select [EFETIVO DE PESSOAL - MENSAL], F6, F12, F18, F24, F30, F36, F42, F48, F54, F60,  F66, F73, F80, F86, F87, F93, F99  from[Efetivo$] where F6<>''
            //select [EFETIVO DE PESSOAL - MENSAL], F6, F12, F24, F30, F42, F48 from[Efetivo$] where F6<>''
            //string sql = "select [EFETIVO DE PESSOAL - MENSAL], f6,f12, f18, trim(f24) from [Efetivo$] where f24<>'' ";
            LerPlanilhaEfetivo(arquivo, 2018, 1);
            try
            {

                var result = new DaoGenerico().GetDados(sql, arquivo);

                dgvDados.DataSource = null;
                dgvDados.DataSource = result;

                /////Para preencher o objto e migrar para o banco
                //foreach (DataRow linha in ds.Tables[0].Rows)
                //{
                //  var linha1 = linha;
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao acessar os dados: " + ex.Message);
            }


        }

        private void LerPlanilhaEfetivo(string arquivo, int ano, int mes)
        {
            string planilha = "Efetivo";
            string sql = string.Empty;
            DataTable result = null;
            List<CamposBanco> lista = new List<CamposBanco>();
            try
            {

                #region Ordem 1

                sql = MonteSql("110", 1, "F24", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 2

                sql = MonteSql("111", 2, "F6", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 3

                sql = MonteSql("112", 3, "F12", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 4

                sql = MonteSql("120", 4, "F48", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 5

                sql = MonteSql("121", 5, "F30", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 6

                sql = MonteSql("122", 6, "F42", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 7

                sql = MonteSql("130", 7, "F73", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 8

                sql = MonteSql("131", 8, "F54", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 9

                sql = MonteSql("132", 9, "F60", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

                #region Ordem 10

                sql = MonteSql("133", 10, "F66", planilha);
                result = new DaoGenerico().GetDados(sql, arquivo);
                PreencherObjeto(lista, result, ano, mes);

                #endregion

             

                foreach (var item in lista)
                {
                    //FAZER A IMPORTACAO
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public string MonteSql(string classificacao, int ordem, string campoExcel, string planilha)
        {
            return "SELECT " + classificacao + " as CODDISCRI, " +
                    "[EFETIVO DE PESSOAL - MENSAL] as EMPRESA, " +
                    ordem + " as Ordem, " +
                    campoExcel + " as QTD " +
                   "FROM["+ planilha + "$] where " + campoExcel + "<>''";
        }

        public List<CamposBanco> PreencherObjeto(List<CamposBanco> listaCampo, DataTable result, int ano, int mes)
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


        private String[] GetExcelSheetNames(string arquivo)
        {


            try
            {
                var dt = new DaoGenerico().GetPlanilhas(arquivo);

                if (dt == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                // Adiciona os nomes na array
                foreach (DataRow row in dt.Rows)
                {
                    if (!row["TABLE_NAME"].ToString().Contains("Print_Titles") &&
                        !row["TABLE_NAME"].ToString().Contains("Print_Area"))
                    {
                        excelSheets[i] = row["TABLE_NAME"].ToString();
                        i++;
                    }
                }

                // Loop através de todas as folhas se você quiser também..
                //for (int j = 0; j < excelSheets.Length; j++)
                //{
                //  // Consultar cada folha de excel
                //}

                return excelSheets;
            }
            catch (Exception ex)
            {
                return null;
            }

        }



        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {

            txtImportar.Text = "";
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd.Multiselect = true;
            this.ofd.Title = "Selecionar Arquivo";
            ofd.InitialDirectory = @"C:\";
            //filtra para exibir somente arquivos de imagens
            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            DialogResult dr = this.ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd.FileNames)
                {
                    txtImportar.Text += arquivo;

                    try
                    {
                        cmbPlanilhas.Items.Clear();

                        var planilhas = GetExcelSheetNames(arquivo);

                        int i = 0;
                        foreach (var item in planilhas)
                        {
                            if (item != null)
                            {
                                cmbPlanilhas.Items.Insert(i, item.ToString());
                                i++;
                            }
                        }


                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                    "Mensagem : " + ex.Message + "\n\n" +
                                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível abrir o arquivo : " + arquivo
                                                   + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                   " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            }
        }

        private void cmbPlanilhas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LerExcel(txtImportar.Text, cmbPlanilhas.Text);
        }

        private void btnAtualizarGrid_Click(object sender, EventArgs e)
        {
            LerExcel(txtImportar.Text, cmbPlanilhas.Text, txtQuery.Text);
        }
    }
}
