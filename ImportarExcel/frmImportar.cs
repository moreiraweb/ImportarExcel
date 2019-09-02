﻿using ImportarExcel.Domain;
using ImportarExcel.Migracao;
using ImportarExcel.Repository;
using ImportarExcel.Repository.Interfaces;
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



        private void LerExcel(string arquivo, string planilha, string sqlCustom = "")
        {


            string sql = string.Empty;
            if (sqlCustom == "")
            {

                if (planilha == "Efetivo$")
                    sql = Efetivo.Sql();
                else if (planilha == "Gestão$")
                    sql = Gestao.Sql();
                else if (planilha == "'Absenteísmo até 15 dias$'")
                    sql = AbsenteismoAteQuinzeDias.Sql();
                else if (planilha == "'Absent + 15 dias e até 6 meses $'")
                    sql = AbsenteismoMaisQuinzeDiasAteSeisMeses.Sql(); 
                else if (planilha == "'Absent + de  6 meses$'")
                    sql = AbsenteismoMaisSeisMeses.Sql();
                else if (planilha == "'Acidentes Próprio$'")
                    sql = AcidenteProprio.Sql();
                else if (planilha == "'Acidentes Terceiros$'")
                    sql = AcidenteTerceiro.Sql();
                else if (planilha != "")
                    sql = "select * from [" + planilha + "] ";
                else
                    return;


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
                lblQtdArquivo.Text = string.Empty;
                ehPasta = false;
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

            if (ehPasta)
                MigrarPorPasta();
            else
                MigrarPorArquivo();

            lblQtdArquivo.Text = string.Empty;
            txtImportar.Text = string.Empty;

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

                        listaMigracao.AddRange(Efetivo.LerPlanilha(filesnames.FullName, ano, mes));
                        nomePlanilha = "Efetivo";
                        GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha Efetivo OK", "");

                        listaMigracao.AddRange(Gestao.LerPlanilha(filesnames.FullName, ano, mes));
                        nomePlanilha = "Gestao";
                        GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha Gestao OK", "");

                        listaMigracao.AddRange(AbsenteismoAteQuinzeDias.LerPlanilha(filesnames.FullName, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));
                        nomePlanilha = "AbsenteismoQuinzeDias";
                        GravarLog(filesnames.Name, nomePlanilha, "Leitura Planilha AbsenteismoQuinzeDias OK", "");


                        pgbMigracao.Value += addProgess;

                    }
                    catch (Exception ex)
                    {
                        GravarLog(filesnames.Name, nomePlanilha, "Erro ao ler a Planilha", ex.Message + " - StackTrace:" + ex.StackTrace);
                        continue;
                    }

                }

                Generic.MigrarDados(listaMigracao);

                MessageBox.Show("MIGRAÇÃO CONCLUÍDA COM SUCESSO...");
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
                listaMigracao.AddRange(Efetivo.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));

                nomePlanilha = "Efetivo";
                GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha Efetivo OK", "");

                pgbMigracao.Value += 15;

                ///
                /// PLANILHA GESTÃO
                ///
                listaMigracao.AddRange(Gestao.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));

                nomePlanilha = "Gestao";
                GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha Efetivo OK", "");

                pgbMigracao.Value += 15;

                ///
                /// PLANILHA Absenteismo até Quinze Dias
                ///
                listaMigracao.AddRange(AbsenteismoAteQuinzeDias.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));

                nomePlanilha = "AbsenteismoQuinzeDias";
                GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AbsenteismoAteQuinzeDias OK", "");

                pgbMigracao.Value += 15;

                /////
                ///// PLANILHA Absenteismo Mais Quinze Dias Ate Seis Meses
                /////
                listaMigracao.AddRange(AbsenteismoMaisQuinzeDiasAteSeisMeses.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));

                nomePlanilha = "AbsenteismoAteQuinzeDias";
                GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AbsenteismoMaisQuinzeDiasAteSeisMeses OK", "");

                pgbMigracao.Value += 15;

                /////
                ///// PLANILHA AbsenteismoMaisSeisMeses
                /////
                listaMigracao.AddRange(AbsenteismoMaisSeisMeses.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));

                nomePlanilha = "AbsenteismoMaisSeisMeses";
                GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AbsenteismoMaisSeisMeses OK", "");

                pgbMigracao.Value += 15;


                /////
                ///// PLANILHA AcidenteProprio
                /////
                listaMigracao.AddRange(AcidenteProprio.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));

                nomePlanilha = "AcidenteProprio";
                GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AcidenteProprio OK", "");

                pgbMigracao.Value += 15;


                /////
                ///// PLANILHA 777
                /////
                listaMigracao.AddRange(AcidenteTerceiro.LerPlanilha(txtImportar.Text, int.Parse(txtAno.Text), int.Parse(txtMes.Text)));

                nomePlanilha = "AcidenteTerceiro";
                GravarLog(txtImportar.Text, nomePlanilha, "Leitura Planilha AcidenteTerceiro OK", "");

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
                GravarLog(txtImportar.Text, nomePlanilha, "Erro ao ler a Planilha", ex.Message + " - StackTrace:" + ex.StackTrace);

                MessageBox.Show("OCORREU UM ERRO NA MIGRAÇÃO: " + ex.Message);
            }
        }

        private void GravarLog(string nomeArquivo, string planilha, string status, string msgErro)
        {
            var log = new Logs() { DataHoraEnvio = DateTime.Now, Usuario = "adm", NomeDocumento = planilha, Status = status, MsgErro = msgErro };
            new LogsRepository().Adicionar(log);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {

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
    }
}
