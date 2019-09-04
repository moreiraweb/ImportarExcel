using ImportarExcel.Domain;
using ImportarExcel.Migracao;
using ImportarExcel.Repository;
using ImportarExcel.Repository.Interfaces;
using ImportarExcel.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportarExcel
{
    public partial class frmImportar : Form
    {
        private bool ehPasta = false;

        public frmImportar()
        {
            InitializeComponent();
            txtImportar.Text = String.Empty;
            lblQtdArquivo.Text = string.Empty;


        }


        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            lblQtdArquivo.Text = "";
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

                    try
                    {

                        txtImportar.Text += arquivo;
                        break;

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
                lblQtdArquivo.Text = string.Empty;
                ehPasta = false;
            }
        }



        private void btnMigrar_Click(object sender, EventArgs e)
        {
            if (txtImportar.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma pasta ou arquivo.");
                return;
            }

            var confirmResult = MessageBox.Show("Confirma a importação?",
                                     "ATENÇÃO!!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
                return;

            MostraAguarde(true);
            //INICIA A TASK
            //var task = Task.Factory.StartNew(() =>
            //{
                if (ehPasta)
                    MigrarPorPasta();
                else
                    MigrarPorArquivo();
           // });
            //TERMINA A TASK
           // task.ContinueWith(
           // t =>
           // {
                MostraAguarde(false);

            //}, TaskScheduler.FromCurrentSynchronizationContext());
           

            lblQtdArquivo.Text = string.Empty;
            txtImportar.Text = string.Empty;

            MessageBox.Show("DADOS MIGRADO COM SUCESSO!");

            pgbMigracao.Value = 0;
        }

        private void MigrarPorPasta()
        {

            try
            {
                pgbMigracao.Maximum = 100;
                pgbMigracao.Step = 1;
                pgbMigracao.Value = 0;


                List<CamposBanco> listaMigracao = new List<CamposBanco>();
                DirectoryInfo dir = new DirectoryInfo("" + txtImportar.Text + "");

                string s = @"" + dir + "";
                System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(s);

                var addProgess = 100 / (d.GetFiles("*.xls").Length);

                foreach (FileInfo filesnames in dir.GetFiles("*.xls"))
                {
                    string nomePlanilha = string.Empty;

                    try
                    {

                        var mes = int.Parse(filesnames.Name.Substring(0, 2));
                        var ano = int.Parse(filesnames.Name.Substring(2, 4));

                        listaMigracao.AddRange(Efetivo.LerPlanilha(filesnames.FullName));
                        nomePlanilha = "Efetivo";
                        Util.Util.GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha " + nomePlanilha + " OK", "");

                        listaMigracao.AddRange(Gestao.LerPlanilha(filesnames.FullName));
                        nomePlanilha = "Gestao";
                        Util.Util.GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha " + nomePlanilha + " OK", "");

                        listaMigracao.AddRange(AbsenteismoAteQuinzeDias.LerPlanilha(filesnames.FullName));
                        nomePlanilha = "AbsenteismoQuinzeDias";
                        Util.Util.GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha " + nomePlanilha + " OK", "");

                        listaMigracao.AddRange(AbsenteismoMaisQuinzeDiasAteSeisMeses.LerPlanilha(filesnames.FullName));
                        nomePlanilha = "AbsenteismoMaisQuinzeDiasAteSeisMeses";
                        Util.Util.GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha " + nomePlanilha + " OK", "");

                        listaMigracao.AddRange(AbsenteismoMaisSeisMeses.LerPlanilha(filesnames.FullName));
                        nomePlanilha = "AbsenteismoMaisSeisMeses";
                        Util.Util.GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha " + nomePlanilha + " OK", "");

                        listaMigracao.AddRange(AcidenteProprio.LerPlanilha(filesnames.FullName));
                        nomePlanilha = "AcidenteProprio";
                        Util.Util.GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha " + nomePlanilha + " OK", "");

                        listaMigracao.AddRange(AcidenteTerceiro.LerPlanilha(filesnames.FullName));
                        nomePlanilha = "AcidenteTerceiro";
                        Util.Util.GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha " + nomePlanilha + " OK", "");


                        pgbMigracao.Value += addProgess;

                    }
                    catch (Exception ex)
                    {
                        Util.Util.GravarLog(filesnames.Name, nomePlanilha, "Erro ao ler o arquivo " + filesnames.Name, ex.Message + " - StackTrace:" + ex.StackTrace);
                        continue;
                    }

                }

                Generic.MigrarDados(listaMigracao);

            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO NA MIGRAÇÃO: " + ex.Message);
            }
        }


        private void MigrarPorArquivo()
        {
            string nomePlanilha = string.Empty;
            try
            {


                List<CamposBanco> listaMigracao = new List<CamposBanco>();
                pgbMigracao.Maximum = 100;
                pgbMigracao.Step = 1;
                pgbMigracao.Value = 0;

                ///
                /// PLANILHA EFETIVO
                ///
                listaMigracao.AddRange(Efetivo.LerPlanilha(txtImportar.Text));

                nomePlanilha = "Efetivo";
                Util.Util.GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha Efetivo OK", "");

                pgbMigracao.Value += 15;

                ///
                /// PLANILHA GESTÃO
                ///
                listaMigracao.AddRange(Gestao.LerPlanilha(txtImportar.Text));

                nomePlanilha = "Gestao";
                Util.Util.GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha Efetivo OK", "");

                pgbMigracao.Value += 15;

                ///
                /// PLANILHA Absenteismo até Quinze Dias
                ///
                listaMigracao.AddRange(AbsenteismoAteQuinzeDias.LerPlanilha(txtImportar.Text));

                nomePlanilha = "AbsenteismoQuinzeDias";
                Util.Util.GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AbsenteismoAteQuinzeDias OK", "");

                pgbMigracao.Value += 15;

                /////
                ///// PLANILHA Absenteismo Mais Quinze Dias Ate Seis Meses
                /////
                listaMigracao.AddRange(AbsenteismoMaisQuinzeDiasAteSeisMeses.LerPlanilha(txtImportar.Text));

                nomePlanilha = "AbsenteismoAteQuinzeDias";
                Util.Util.GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AbsenteismoMaisQuinzeDiasAteSeisMeses OK", "");

                pgbMigracao.Value += 15;

                /////
                ///// PLANILHA AbsenteismoMaisSeisMeses
                /////
                listaMigracao.AddRange(AbsenteismoMaisSeisMeses.LerPlanilha(txtImportar.Text));

                nomePlanilha = "AbsenteismoMaisSeisMeses";
                Util.Util.GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AbsenteismoMaisSeisMeses OK", "");

                pgbMigracao.Value += 15;


                /////
                ///// PLANILHA AcidenteProprio
                /////
                listaMigracao.AddRange(AcidenteProprio.LerPlanilha(txtImportar.Text));

                nomePlanilha = "AcidenteProprio";
                Util.Util.GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AcidenteProprio OK", "");

                pgbMigracao.Value += 15;


                /////
                ///// PLANILHA 777
                /////
                listaMigracao.AddRange(AcidenteTerceiro.LerPlanilha(txtImportar.Text));

                nomePlanilha = "AcidenteTerceiro";
                Util.Util.GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AcidenteTerceiro OK", "");

                pgbMigracao.Value += 5;

                ///
                /// MIGRAR PARA O BANCO DE DADOS
                ///
                Generic.MigrarDados(listaMigracao);
                pgbMigracao.Value += 5;



            }
            catch (Exception ex)
            {
                Util.Util.GravarLog(txtImportar.Text, nomePlanilha, "Erro ao ler a Planilha", ex.Message + " - StackTrace:" + ex.StackTrace);

                MessageBox.Show("OCORREU UM ERRO NA MIGRAÇÃO: " + ex.Message);
            }
        }



        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {
            lblQtdArquivo.Text = "";
            txtImportar.Text = "";

            if (fbd.ShowDialog() == DialogResult.OK)
            {

                DirectoryInfo dir = new DirectoryInfo("" + fbd.SelectedPath + "");

                FileInfo[] arquivos = dir.GetFiles(".xls");
                {
                    if (Directory.GetFiles(dir.ToString(), "*.xls").Length < 1)
                    {
                        MessageBox.Show("Por favor, verifique se o diretório escolhido possui arquivos no formato válido");
                        return;
                    }
                    else
                    {
                        #region : Verifica Quantidade de Arquivos .xls no diretório :

                        int files;
                        string s = @"" + dir + "";
                        System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(s);

                        files = d.GetFiles("*.xls").Length;
                        //MessageBox.Show("O diretorio selecionado possui " + files + " arquivos .xls");

                        txtImportar.Text = fbd.SelectedPath;

                        lblQtdArquivo.Text = files.ToString() + " Arquivo(s) selecionado(s).";

                        #endregion

                        ehPasta = true;
                    }



                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();





        }

        private void MostraAguarde(bool v)
        {

            if (v)
            {
                btnMigrar.Enabled = false;
                lblAguarde.Visible = true;
            }
            else
            {
                btnMigrar.Enabled = true;
                lblAguarde.Visible = false;
            }
            
        }
    }
}
