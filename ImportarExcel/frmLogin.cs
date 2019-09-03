using ImportarExcel.Domain;
using ImportarExcel.Repository;
using ImportarExcel.Util;
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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Helper.usuarios = VerificarLogin(txtUsuario.Text, txtSenha.Text);
            if (Helper.usuarios != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário/Senha Não encontrado.");
            }
        }

        private Usuarios VerificarLogin(string usr, string senha)
        {
            try
            {
                UsuariosRepository rep = new UsuariosRepository();
                var usuario = rep.Get(usr);

                if (usuario == null || usuario.Senha != senha)
                    return null;


                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
