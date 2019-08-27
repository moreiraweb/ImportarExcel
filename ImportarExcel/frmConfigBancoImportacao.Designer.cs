namespace ImportarExcel
{
  partial class frmConfigBancoImportacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.txtStringConexao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStringConexao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Banco:";
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(123, 32);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(100, 20);
            this.txtNomeBanco.TabIndex = 1;
            // 
            // txtStringConexao
            // 
            this.txtStringConexao.Location = new System.Drawing.Point(123, 63);
            this.txtStringConexao.Name = "txtStringConexao";
            this.txtStringConexao.Size = new System.Drawing.Size(402, 20);
            this.txtStringConexao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "String Conexão:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(557, 17);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(557, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNomeBanco,
            this.colStringConexao});
            this.dgDados.Location = new System.Drawing.Point(12, 109);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.Size = new System.Drawing.Size(620, 150);
            this.dgDados.TabIndex = 6;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDados_CellContentClick);
            this.dgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDados_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colNomeBanco
            // 
            this.colNomeBanco.DataPropertyName = "NomeBancoMigracao";
            this.colNomeBanco.HeaderText = "Nome Banco";
            this.colNomeBanco.Name = "colNomeBanco";
            this.colNomeBanco.ReadOnly = true;
            this.colNomeBanco.Width = 150;
            // 
            // colStringConexao
            // 
            this.colStringConexao.DataPropertyName = "StringConexaoBancoMigracao";
            this.colStringConexao.HeaderText = "String Conexão";
            this.colStringConexao.Name = "colStringConexao";
            this.colStringConexao.ReadOnly = true;
            this.colStringConexao.Width = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(122, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(14, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "0";
            // 
            // frmConfigBancoImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 291);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtStringConexao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeBanco);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmConfigBancoImportacao";
            this.Text = "Configuração de Banco de Dados Importação";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNomeBanco;
    private System.Windows.Forms.TextBox txtStringConexao;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStringConexao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
    }
}