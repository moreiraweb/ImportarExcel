namespace ImportarExcel
{
  partial class frmPrincipal
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.frmImportaroolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.menuStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.configurarToolStripMenuItem,
            this.windowsMenu,
            this.helpMenu});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.MdiWindowListItem = this.windowsMenu;
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(632, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "MenuStrip";
      // 
      // fileMenu
      // 
      this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmImportaroolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
      this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
      this.fileMenu.Name = "fileMenu";
      this.fileMenu.Size = new System.Drawing.Size(61, 20);
      this.fileMenu.Text = "A&rquivo";
      // 
      // frmImportaroolStripMenuItem
      // 
      this.frmImportaroolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("frmImportaroolStripMenuItem.Image")));
      this.frmImportaroolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
      this.frmImportaroolStripMenuItem.Name = "frmImportaroolStripMenuItem";
      this.frmImportaroolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
      this.frmImportaroolStripMenuItem.Size = new System.Drawing.Size(157, 22);
      this.frmImportaroolStripMenuItem.Text = "&Importar";
      this.frmImportaroolStripMenuItem.Click += new System.EventHandler(this.frmImportaroolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
      // 
      // configurarToolStripMenuItem
      // 
      this.configurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoToolStripMenuItem});
      this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
      this.configurarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
      this.configurarToolStripMenuItem.Text = "&Configurar";
      // 
      // bancoToolStripMenuItem
      // 
      this.bancoToolStripMenuItem.Name = "bancoToolStripMenuItem";
      this.bancoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.bancoToolStripMenuItem.Text = "&Banco";
      this.bancoToolStripMenuItem.Click += new System.EventHandler(this.bancoToolStripMenuItem_Click);
      // 
      // windowsMenu
      // 
      this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
      this.windowsMenu.Name = "windowsMenu";
      this.windowsMenu.Size = new System.Drawing.Size(68, 20);
      this.windowsMenu.Text = "&Windows";
      // 
      // cascadeToolStripMenuItem
      // 
      this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
      this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.cascadeToolStripMenuItem.Text = "&Cascata";
      this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
      // 
      // tileVerticalToolStripMenuItem
      // 
      this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
      this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.tileVerticalToolStripMenuItem.Text = "&Vertical";
      this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
      // 
      // tileHorizontalToolStripMenuItem
      // 
      this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
      this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.tileHorizontalToolStripMenuItem.Text = "&Horizontal";
      this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
      // 
      // closeAllToolStripMenuItem
      // 
      this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
      this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.closeAllToolStripMenuItem.Text = "&Fechar Todas";
      this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
      // 
      // helpMenu
      // 
      this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
      this.helpMenu.Name = "helpMenu";
      this.helpMenu.Size = new System.Drawing.Size(50, 20);
      this.helpMenu.Text = "&Ajuda";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
      this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.indexToolStripMenuItem.Text = "&Documentação";
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.aboutToolStripMenuItem.Text = "&Sobre ... ...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.helpToolStripButton});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(632, 25);
      this.toolStrip.TabIndex = 1;
      this.toolStrip.Text = "ToolStrip";
      // 
      // openToolStripButton
      // 
      this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
      this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.openToolStripButton.Text = "Open";
      this.openToolStripButton.Click += new System.EventHandler(this.frmImportaroolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // helpToolStripButton
      // 
      this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
      this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
      this.helpToolStripButton.Name = "helpToolStripButton";
      this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.helpToolStripButton.Text = "Help";
      this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 431);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(632, 22);
      this.statusStrip.TabIndex = 2;
      this.statusStrip.Text = "StatusStrip";
      // 
      // toolStripStatusLabel
      // 
      this.toolStripStatusLabel.Name = "toolStripStatusLabel";
      this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
      this.toolStripStatusLabel.Text = "Status";
      // 
      // frmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 453);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.menuStrip);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip;
      this.Name = "frmPrincipal";
      this.Text = "Importar Arquivo Excel";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion


    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileMenu;
    private System.Windows.Forms.ToolStripMenuItem frmImportaroolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpMenu;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripButton helpToolStripButton;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.ToolStripMenuItem windowsMenu;
    private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bancoToolStripMenuItem;
  }
}



