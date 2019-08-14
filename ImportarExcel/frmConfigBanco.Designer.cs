namespace ImportarExcel
{
  partial class frmConfigBanco
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(45, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nome Banco:";
      // 
      // txtNomeBanco
      // 
      this.txtNomeBanco.Location = new System.Drawing.Point(123, 25);
      this.txtNomeBanco.Name = "txtNomeBanco";
      this.txtNomeBanco.Size = new System.Drawing.Size(100, 20);
      this.txtNomeBanco.TabIndex = 1;
      // 
      // txtStringConexao
      // 
      this.txtStringConexao.Location = new System.Drawing.Point(123, 56);
      this.txtStringConexao.Name = "txtStringConexao";
      this.txtStringConexao.Size = new System.Drawing.Size(402, 20);
      this.txtStringConexao.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(35, 59);
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
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(557, 59);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 5;
      this.btnCancelar.Text = "&Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(38, 109);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(487, 150);
      this.dataGridView1.TabIndex = 6;
      // 
      // frmConfigBanco
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(644, 291);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.txtStringConexao);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtNomeBanco);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.Name = "frmConfigBanco";
      this.Text = "Configuração de Banco de Dados";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}