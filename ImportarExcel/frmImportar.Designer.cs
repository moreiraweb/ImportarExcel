namespace ImportarExcel
{
  partial class frmImportar
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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cmbPlanilhas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizarGrid = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMigrar = new System.Windows.Forms.Button();
            this.pgbMigracao = new System.Windows.Forms.ProgressBar();
            this.btnFechar = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelecionarPasta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImportar = new System.Windows.Forms.Label();
            this.lblQtdArquivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(128, 36);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(133, 23);
            this.btnSelecionarArquivo.TabIndex = 4;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 181);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(1024, 227);
            this.dgvDados.TabIndex = 2;
            // 
            // cmbPlanilhas
            // 
            this.cmbPlanilhas.FormattingEnabled = true;
            this.cmbPlanilhas.Location = new System.Drawing.Point(11, 154);
            this.cmbPlanilhas.Name = "cmbPlanilhas";
            this.cmbPlanilhas.Size = new System.Drawing.Size(296, 21);
            this.cmbPlanilhas.TabIndex = 3;
            this.cmbPlanilhas.SelectedIndexChanged += new System.EventHandler(this.cmbPlanilhas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PLANILHAS:";
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(17, 432);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1019, 84);
            this.txtQuery.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUERY:";
            // 
            // btnAtualizarGrid
            // 
            this.btnAtualizarGrid.Location = new System.Drawing.Point(18, 522);
            this.btnAtualizarGrid.Name = "btnAtualizarGrid";
            this.btnAtualizarGrid.Size = new System.Drawing.Size(270, 33);
            this.btnAtualizarGrid.TabIndex = 7;
            this.btnAtualizarGrid.Text = "ATUALIZAR GRID";
            this.btnAtualizarGrid.UseVisualStyleBackColor = true;
            this.btnAtualizarGrid.Click += new System.EventHandler(this.btnAtualizarGrid_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(12, 39);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(50, 20);
            this.txtAno.TabIndex = 1;
            this.txtAno.Text = "2018";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(79, 39);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(30, 20);
            this.txtMes.TabIndex = 2;
            this.txtMes.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ANO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "MÊS:";
            // 
            // btnMigrar
            // 
            this.btnMigrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnMigrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMigrar.Location = new System.Drawing.Point(903, 83);
            this.btnMigrar.Name = "btnMigrar";
            this.btnMigrar.Size = new System.Drawing.Size(133, 68);
            this.btnMigrar.TabIndex = 12;
            this.btnMigrar.Text = "MIGRAR";
            this.btnMigrar.UseVisualStyleBackColor = false;
            this.btnMigrar.Click += new System.EventHandler(this.btnMigrar_Click);
            // 
            // pgbMigracao
            // 
            this.pgbMigracao.Location = new System.Drawing.Point(0, 582);
            this.pgbMigracao.Name = "pgbMigracao";
            this.pgbMigracao.Size = new System.Drawing.Size(1062, 23);
            this.pgbMigracao.TabIndex = 13;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(961, 527);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSelecionarPasta
            // 
            this.btnSelecionarPasta.Location = new System.Drawing.Point(298, 36);
            this.btnSelecionarPasta.Name = "btnSelecionarPasta";
            this.btnSelecionarPasta.Size = new System.Drawing.Size(133, 23);
            this.btnSelecionarPasta.TabIndex = 15;
            this.btnSelecionarPasta.Text = "Selecionar Pasta";
            this.btnSelecionarPasta.UseVisualStyleBackColor = true;
            this.btnSelecionarPasta.Click += new System.EventHandler(this.btnSelecionarPasta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "OU";
            // 
            // txtImportar
            // 
            this.txtImportar.AutoSize = true;
            this.txtImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportar.ForeColor = System.Drawing.Color.Red;
            this.txtImportar.Location = new System.Drawing.Point(13, 72);
            this.txtImportar.Name = "txtImportar";
            this.txtImportar.Size = new System.Drawing.Size(191, 25);
            this.txtImportar.TabIndex = 17;
            this.txtImportar.Text = "PASTA/ARQUIVO";
            // 
            // lblQtdArquivo
            // 
            this.lblQtdArquivo.AutoSize = true;
            this.lblQtdArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdArquivo.ForeColor = System.Drawing.Color.Red;
            this.lblQtdArquivo.Location = new System.Drawing.Point(41, 98);
            this.lblQtdArquivo.Name = "lblQtdArquivo";
            this.lblQtdArquivo.Size = new System.Drawing.Size(163, 25);
            this.lblQtdArquivo.TabIndex = 18;
            this.lblQtdArquivo.Text = "QTD ARQUIVO";
            // 
            // frmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 604);
            this.Controls.Add(this.lblQtdArquivo);
            this.Controls.Add(this.txtImportar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelecionarPasta);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pgbMigracao);
            this.Controls.Add(this.btnMigrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.btnAtualizarGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlanilhas);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.MaximizeBox = false;
            this.Name = "frmImportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Arquivo Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog ofd;
    private System.Windows.Forms.Button btnSelecionarArquivo;
    private System.Windows.Forms.DataGridView dgvDados;
    private System.Windows.Forms.ComboBox cmbPlanilhas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtQuery;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAtualizarGrid;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMigrar;
        private System.Windows.Forms.ProgressBar pgbMigracao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnSelecionarPasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtImportar;
        private System.Windows.Forms.Label lblQtdArquivo;
    }
}

