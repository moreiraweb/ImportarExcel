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
    public partial class frmConfigBancoImportacao : Form
    {
        private Parametros parametro;

        public frmConfigBancoImportacao()
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


                foreach (Parametros parametro in ListaFiltrada())
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

        private void AdicionarItemNaDataGridView(Parametros entity)
        {

            dgDados.Rows.Add(
                    entity.Id,
                    entity.Server,
                    entity.DataBase,
                    entity.Usuario);
        }

        private IEnumerable<Parametros> ListaFiltrada()
        {
            var repo = new ParametrosRepository();


            return repo.Get().ToArray();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Parametros PreencherObjeto(Parametros parametros)
        {

            parametros.Server = txtServer.Text;
            parametros.DataBase = txtDataBase.Text;
            parametros.Usuario = txtUsuario.Text;
            parametros.Senha = txtSenha.Text;

            return parametros;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                var repo = new ParametrosRepository();
                if (lblId.Text == "0" || lblId.Text.Trim() == "")
                {
                    repo.Adicionar(PreencherObjeto(new Parametros()));
                }
                else
                {
                    repo.Alterar(PreencherObjeto(parametro));
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

                var rep = new ParametrosRepository();
                parametro = rep.Get(id);

                lblId.Text = id.ToString();
                txtServer.Text = parametro.Server;
                txtDataBase.Text = parametro.DataBase;
                txtUsuario.Text = parametro.Usuario;
                txtSenha.Text = parametro.Senha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw;
            }
        }
    }
}
