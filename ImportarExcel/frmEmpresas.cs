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
    public partial class frmEmpresas : Form
    {
        private Empresas empresa;

        public frmEmpresas()
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


                foreach (Empresas empresa in ListaFiltrada())
                {
                    AdicionarItemNaDataGridView(empresa);
                }

                dgDados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                dgDados.ResumeLayout();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AdicionarItemNaDataGridView(Empresas entity)
        {

            dgDados.Rows.Add(
                    entity.Codigo,
                    entity.Nome);
        }

        private IEnumerable<Empresas> ListaFiltrada()
        {
            var repo = new EmpresasRepository();


            return repo.Get().ToArray();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Empresas PreencherObjeto(Empresas Empresas)
        {

            Empresas.Nome = txtNome.Text;

            return Empresas;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                var repo = new EmpresasRepository();
                if (lblId.Text == "0" || lblId.Text.Trim() == "")
                {
                    repo.Adicionar(PreencherObjeto(new Empresas()));
                }
                else
                {
                    repo.Alterar(PreencherObjeto(empresa));
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

                var id = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells["colCodigo"].Value);

                var rep = new EmpresasRepository();
                empresa = rep.Get(id);

                lblId.Text = id.ToString();
                txtNome.Text = empresa.Nome;

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
                if (empresa == null)
                {
                    MessageBox.Show("Selecione um Registro.");
                    return;
                }

                var confirmResult = MessageBox.Show("Deseja Excluir??",
                                     "Confirma Exclusão!!",
                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    var rep = new EmpresasRepository();
                    rep.Remover(empresa);

                    MessageBox.Show("Removido Com Sucesso!");

                    LoadGrid();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            empresa = null;
            txtNome.Text = string.Empty;
            lblId.Text = string.Empty;
            LoadGrid();
        }
    }
}
