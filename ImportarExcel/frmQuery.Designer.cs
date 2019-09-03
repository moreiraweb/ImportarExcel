namespace ImportarExcel
{
    partial class frmQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtualizarGrid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlanilhas = new System.Windows.Forms.ComboBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.txtImportar = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizarGrid
            // 
            this.btnAtualizarGrid.Location = new System.Drawing.Point(24, 431);
            this.btnAtualizarGrid.Name = "btnAtualizarGrid";
            this.btnAtualizarGrid.Size = new System.Drawing.Size(1076, 33);
            this.btnAtualizarGrid.TabIndex = 13;
            this.btnAtualizarGrid.Text = "ATUALIZAR GRID";
            this.btnAtualizarGrid.UseVisualStyleBackColor = true;
            this.btnAtualizarGrid.Click += new System.EventHandler(this.btnAtualizarGrid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "QUERY:";
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(23, 341);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1077, 84);
            this.txtQuery.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "PLANILHAS:";
            // 
            // cmbPlanilhas
            // 
            this.cmbPlanilhas.FormattingEnabled = true;
            this.cmbPlanilhas.Location = new System.Drawing.Point(17, 63);
            this.cmbPlanilhas.Name = "cmbPlanilhas";
            this.cmbPlanilhas.Size = new System.Drawing.Size(296, 21);
            this.cmbPlanilhas.TabIndex = 9;
            this.cmbPlanilhas.SelectedIndexChanged += new System.EventHandler(this.cmbPlanilhas_SelectedIndexChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(17, 90);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(1083, 227);
            this.dgvDados.TabIndex = 8;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(24, 12);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(133, 23);
            this.btnSelecionarArquivo.TabIndex = 14;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // txtImportar
            // 
            this.txtImportar.AutoSize = true;
            this.txtImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportar.ForeColor = System.Drawing.Color.Red;
            this.txtImportar.Location = new System.Drawing.Point(163, 10);
            this.txtImportar.Name = "txtImportar";
            this.txtImportar.Size = new System.Drawing.Size(191, 25);
            this.txtImportar.TabIndex = 18;
            this.txtImportar.Text = "PASTA/ARQUIVO";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // frmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 480);
            this.Controls.Add(this.txtImportar);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.btnAtualizarGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlanilhas);
            this.Controls.Add(this.dgvDados);
            this.Name = "frmQuery";
            this.Text = "frmQuery";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlanilhas;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.Label txtImportar;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}