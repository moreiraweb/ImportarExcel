using ImportarExcel.Domain;
using ImportarExcel.Migracao;
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
            {

                if (planilha == "Efetivo$")
                    sql = Efetivo.Sql();
                else if (planilha == "Gestão$")
                    sql = Gestao.Sql();
                else
                    sql = "select * from [" + planilha + "] ";
            }
            else
            {
                sql = sqlCustom;
            }
            
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

        private void btnMigrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<CamposBanco> listaMigracao = new List<CamposBanco>();
                pgbMigracao.Maximum = 100;
                pgbMigracao.Step = 1;
                pgbMigracao.Value = 0;

                ///
                /// PLANILHA EFETIVO
                ///
                listaMigracao.AddRange(Efetivo.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));
                pgbMigracao.Value += 15;

                ///
                /// PLANILHA GESTÃO
                ///
                listaMigracao.AddRange(Gestao.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));
                pgbMigracao.Value += 15;

                ///
                /// PLANILHA XXX
                ///
                listaMigracao.AddRange(Gestao.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));
                pgbMigracao.Value += 15;

                ///
                /// 444
                ///
                listaMigracao.AddRange(Gestao.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));
                pgbMigracao.Value += 15;


                ///
                /// PLANILHA 555
                ///
                listaMigracao.AddRange(Gestao.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));
                pgbMigracao.Value += 15;


                ///
                /// PLANILHA 6666
                ///
                listaMigracao.AddRange(Gestao.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));
                pgbMigracao.Value += 15;


                ///
                /// PLANILHA 777
                ///
                listaMigracao.AddRange(Gestao.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));
                pgbMigracao.Value += 5;

                ///
                /// MIGRAR PARA O BANCO DE DADOS
                ///
                Generic.MigrarDados(listaMigracao);
                pgbMigracao.Value += 5;

                MessageBox.Show("MIGRAÇÃO CONCLUÍDA COM SUCESSO...");
            }
            catch (Exception ex)
            {

                MessageBox.Show("OCORREU UM ERRO NA MIGRAÇÃO: " + ex.Message);
            }
           
        }

       

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
