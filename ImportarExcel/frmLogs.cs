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
    public partial class frmLogs : Form
    {
        private Logs empresa;

        public frmLogs()
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
           
                foreach (Logs empresa in ListaFiltrada())
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

        private void AdicionarItemNaDataGridView(Logs entity)
        {

            dgDados.Rows.Add(
                    entity.Id,
                    entity.Usuario,
                    entity.DataHoraEnvio,
                    entity.NomeDocumento,
                    entity.Status,
                    entity.MsgErro);
        }

        private IEnumerable<Logs> ListaFiltrada()
        {
            var repo = new LogsRepository();


            if (txtDocumento.Text != "")
                return repo.Get().ToArray().Where(x => x.NomeDocumento.ToLower().Contains(txtDocumento.Text));
            else
                return repo.Get().ToArray();

       }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
