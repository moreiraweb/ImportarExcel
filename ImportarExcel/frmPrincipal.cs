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
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();

           

        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmImportaroolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmImportar frmImportar = new frmImportar();
            frmImportar.MdiParent = this;
            frmImportar.Show();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigBancoImportacao frmConfigBanco = new frmConfigBancoImportacao();
            frmConfigBanco.MdiParent = this;
            frmConfigBanco.Show();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PlanilhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanilhas frm = new frmPlanilhas();
            frm.MdiParent = this;
            frm.Show();

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
