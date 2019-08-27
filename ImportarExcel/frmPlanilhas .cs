using ImportarExcel.Domain;
using ImportarExcel.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportarExcel
{
    public partial class frmPlanilhas : Form
    {
        private Planilhas planilha;

        public frmPlanilhas()
        {
            InitializeComponent();

            LoadGrid();
        }


        public void LoadGrid()
        {
            try
            {



                dgDados.SuspendLayout();
                dgDados.DataSource = null;
                dgDados.Rows.Clear();


                foreach (Planilhas parametro in ListaFiltrada())
                {
                    AdicionarItemNaDataGridView(parametro);
                }

                dgDados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                dgDados.ResumeLayout();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AdicionarItemNaDataGridView(Planilhas entity)
        {

            dgDados.Rows.Add(
                    entity.Id,
                    entity.Descricao);
        }

        private IEnumerable<Planilhas> ListaFiltrada()
        {
            var repo = new PlanilhasRepository();


            return repo.Get().ToArray();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Planilhas PreencherObjeto(Planilhas Planilhas)
        {

            Planilhas.Descricao = txtDescricao.Text;

            return Planilhas;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                var repo = new PlanilhasRepository();
                if (lblId.Text == "0" || lblId.Text.Trim() == "")
                {
                    repo.Adicionar(PreencherObjeto(new Planilhas()));
                }
                else
                {
                    repo.Alterar(PreencherObjeto(planilha));
                }

                MessageBox.Show("Gravado Com Sucesso!");

                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw;
            }
        }

        private void DgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var id = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells["colId"].Value);

                var rep = new PlanilhasRepository();
                planilha = rep.Get(id);

                lblId.Text = id.ToString();
                txtDescricao.Text = planilha.Descricao;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (planilha == null)
                {
                    MessageBox.Show("Selecione um Registro.");
                    return;
                }
                var rep = new PlanilhasRepository();
                rep.Remover(planilha);

                MessageBox.Show("Removido Com Sucesso!");

                LoadGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            planilha = null;
            txtDescricao.Text = string.Empty;
            lblId.Text = string.Empty;
            LoadGrid();
        }
    }
}
