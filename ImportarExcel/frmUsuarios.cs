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
    public partial class frmUsuarios : Form
    {
        private Usuarios usuario;

        public frmUsuarios()
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


                foreach (Usuarios parametro in ListaFiltrada())
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

        private void AdicionarItemNaDataGridView(Usuarios entity)
        {

            dgDados.Rows.Add(
                    entity.Usuario);
        }

        private IEnumerable<Usuarios> ListaFiltrada()
        {
            var repo = new UsuariosRepository();


            return repo.Get().ToArray();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Usuarios PreencherObjeto(Usuarios Usuarios)
        {

            Usuarios.Usuario = txtUsuario.Text;
            Usuarios.Senha = txtSenha.Text;

            return Usuarios;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                var repo = new UsuariosRepository();
                if (usuario == null)
                {
                    repo.Adicionar(PreencherObjeto(new Usuarios()));
                }
                else
                {
                    repo.Alterar(PreencherObjeto(usuario));
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

                var usuario = dgDados.Rows[e.RowIndex].Cells["colUsuario"].Value.ToString();

                var rep = new UsuariosRepository();
                this.usuario = rep.Get(usuario);


                txtUsuario.Text = this.usuario.Usuario;
                txtSenha.Text = this.usuario.Senha;

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
                if (usuario == null)
                {
                    MessageBox.Show("Selecione um Registro.");
                    return;
                }
                var rep = new UsuariosRepository();
                rep.Remover(usuario);

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
            usuario = null;
            txtSenha.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            LoadGrid();
        }

    }
}
