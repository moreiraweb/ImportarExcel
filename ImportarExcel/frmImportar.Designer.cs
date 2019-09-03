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
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMigrar = new System.Windows.Forms.Button();
            this.pgbMigracao = new System.Windows.Forms.ProgressBar();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelecionarPasta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImportar = new System.Windows.Forms.Label();
            this.lblQtdArquivo = new System.Windows.Forms.Label();
            this.lblAguarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(128, 50);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(133, 23);
            this.btnSelecionarArquivo.TabIndex = 4;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(12, 53);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(50, 20);
            this.txtAno.TabIndex = 1;
            this.txtAno.Text = "2018";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(79, 53);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(30, 20);
            this.txtMes.TabIndex = 2;
            this.txtMes.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ANO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 37);
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
            this.btnMigrar.Location = new System.Drawing.Point(661, 31);
            this.btnMigrar.Name = "btnMigrar";
            this.btnMigrar.Size = new System.Drawing.Size(150, 68);
            this.btnMigrar.TabIndex = 12;
            this.btnMigrar.Text = "MIGRAR";
            this.btnMigrar.UseVisualStyleBackColor = false;
            this.btnMigrar.Click += new System.EventHandler(this.btnMigrar_Click);
            // 
            // pgbMigracao
            // 
            this.pgbMigracao.Location = new System.Drawing.Point(2, 2);
            this.pgbMigracao.Name = "pgbMigracao";
            this.pgbMigracao.Size = new System.Drawing.Size(809, 23);
            this.pgbMigracao.TabIndex = 13;
            // 
            // btnSelecionarPasta
            // 
            this.btnSelecionarPasta.Location = new System.Drawing.Point(298, 50);
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
            this.label5.Location = new System.Drawing.Point(267, 56);
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
            this.txtImportar.Location = new System.Drawing.Point(13, 86);
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
            this.lblQtdArquivo.Location = new System.Drawing.Point(41, 112);
            this.lblQtdArquivo.Name = "lblQtdArquivo";
            this.lblQtdArquivo.Size = new System.Drawing.Size(163, 25);
            this.lblQtdArquivo.TabIndex = 18;
            this.lblQtdArquivo.Text = "QTD ARQUIVO";
            // 
            // lblAguarde
            // 
            this.lblAguarde.AutoSize = true;
            this.lblAguarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAguarde.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAguarde.Location = new System.Drawing.Point(624, 131);
            this.lblAguarde.Name = "lblAguarde";
            this.lblAguarde.Size = new System.Drawing.Size(0, 25);
            this.lblAguarde.TabIndex = 20;
            // 
            // frmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 165);
            this.Controls.Add(this.lblAguarde);
            this.Controls.Add(this.lblQtdArquivo);
            this.Controls.Add(this.txtImportar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelecionarPasta);
            this.Controls.Add(this.pgbMigracao);
            this.Controls.Add(this.btnMigrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.MaximizeBox = false;
            this.Name = "frmImportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Arquivo Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog ofd;
    private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMigrar;
        private System.Windows.Forms.ProgressBar pgbMigracao;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnSelecionarPasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtImportar;
        private System.Windows.Forms.Label lblQtdArquivo;
        private System.Windows.Forms.Label lblAguarde;
    }
}

