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
      this.txtImportar = new System.Windows.Forms.TextBox();
      this.btnSelecionarArquivo = new System.Windows.Forms.Button();
      this.dgvDados = new System.Windows.Forms.DataGridView();
      this.cmbPlanilhas = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtQuery = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnAtualizarGrid = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
      this.SuspendLayout();
      // 
      // ofd
      // 
      this.ofd.FileName = "openFileDialog1";
      // 
      // txtImportar
      // 
      this.txtImportar.Location = new System.Drawing.Point(13, 13);
      this.txtImportar.Name = "txtImportar";
      this.txtImportar.Size = new System.Drawing.Size(438, 20);
      this.txtImportar.TabIndex = 0;
      // 
      // btnSelecionarArquivo
      // 
      this.btnSelecionarArquivo.Location = new System.Drawing.Point(457, 12);
      this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
      this.btnSelecionarArquivo.Size = new System.Drawing.Size(133, 23);
      this.btnSelecionarArquivo.TabIndex = 1;
      this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
      this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
      this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
      // 
      // dgvDados
      // 
      this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDados.Location = new System.Drawing.Point(12, 86);
      this.dgvDados.Name = "dgvDados";
      this.dgvDados.Size = new System.Drawing.Size(1310, 405);
      this.dgvDados.TabIndex = 2;
      // 
      // cmbPlanilhas
      // 
      this.cmbPlanilhas.FormattingEnabled = true;
      this.cmbPlanilhas.Location = new System.Drawing.Point(12, 59);
      this.cmbPlanilhas.Name = "cmbPlanilhas";
      this.cmbPlanilhas.Size = new System.Drawing.Size(296, 21);
      this.cmbPlanilhas.TabIndex = 3;
      this.cmbPlanilhas.SelectedIndexChanged += new System.EventHandler(this.cmbPlanilhas_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 43);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "PLANILHAS:";
      // 
      // txtQuery
      // 
      this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtQuery.Location = new System.Drawing.Point(15, 510);
      this.txtQuery.Multiline = true;
      this.txtQuery.Name = "txtQuery";
      this.txtQuery.Size = new System.Drawing.Size(1307, 118);
      this.txtQuery.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 494);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "QUERY:";
      // 
      // btnAtualizarGrid
      // 
      this.btnAtualizarGrid.Location = new System.Drawing.Point(15, 634);
      this.btnAtualizarGrid.Name = "btnAtualizarGrid";
      this.btnAtualizarGrid.Size = new System.Drawing.Size(270, 33);
      this.btnAtualizarGrid.TabIndex = 7;
      this.btnAtualizarGrid.Text = "ATUALIZAR GRID";
      this.btnAtualizarGrid.UseVisualStyleBackColor = true;
      this.btnAtualizarGrid.Click += new System.EventHandler(this.btnAtualizarGrid_Click);
      // 
      // frmImportar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1349, 725);
      this.Controls.Add(this.btnAtualizarGrid);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtQuery);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbPlanilhas);
      this.Controls.Add(this.dgvDados);
      this.Controls.Add(this.btnSelecionarArquivo);
      this.Controls.Add(this.txtImportar);
      this.MaximizeBox = false;
      this.Name = "frmImportar";
      this.Text = "Importar Arquivo Excel";
      ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog ofd;
    private System.Windows.Forms.TextBox txtImportar;
    private System.Windows.Forms.Button btnSelecionarArquivo;
    private System.Windows.Forms.DataGridView dgvDados;
    private System.Windows.Forms.ComboBox cmbPlanilhas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtQuery;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAtualizarGrid;
  }
}

