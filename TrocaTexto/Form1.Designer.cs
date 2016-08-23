namespace TrocaTexto
{
    partial class frmTroca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTroca));
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("<<Listagem de Arquivos>>");
            this.mnuSup = new System.Windows.Forms.ToolStrip();
            this.cmbTipo = new System.Windows.Forms.ToolStripComboBox();
            this.btnCrit = new System.Windows.Forms.ToolStripButton();
            this.txtExt = new System.Windows.Forms.ToolStripTextBox();
            this.btnDir = new System.Windows.Forms.ToolStripButton();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.fdCrit = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdvTexto = new System.Windows.Forms.DataGridView();
            this.foDir = new System.Windows.Forms.FolderBrowserDialog();
            this.treeVw = new System.Windows.Forms.TreeView();
            this.lblMsg = new System.Windows.Forms.Label();
            this.mnuSup.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuSup
            // 
            this.mnuSup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbTipo,
            this.btnCrit,
            this.txtExt,
            this.btnDir,
            this.btnGo});
            this.mnuSup.Location = new System.Drawing.Point(0, 0);
            this.mnuSup.Name = "mnuSup";
            this.mnuSup.Size = new System.Drawing.Size(715, 25);
            this.mnuSup.TabIndex = 0;
            this.mnuSup.Text = "toolStrip1";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "De-para",
            "De-para com * "});
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.Items.AddRange(new object[] {
            "De-para",
            "De-para com * "});
            this.cmbTipo.MaxDropDownItems = 2;
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(125, 25);
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            this.cmbTipo.Click += new System.EventHandler(this.cmbTipo_Click);
            // 
            // btnCrit
            // 
            this.btnCrit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCrit.Enabled = false;
            this.btnCrit.Image = ((System.Drawing.Image)(resources.GetObject("btnCrit.Image")));
            this.btnCrit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrit.Name = "btnCrit";
            this.btnCrit.Size = new System.Drawing.Size(51, 22);
            this.btnCrit.Text = "Critérios";
            this.btnCrit.Click += new System.EventHandler(this.btnCrit_Click);
            // 
            // txtExt
            // 
            this.txtExt.Enabled = false;
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(100, 25);
            this.txtExt.Text = "txt";
            this.txtExt.Click += new System.EventHandler(this.txtExt_Click);
            // 
            // btnDir
            // 
            this.btnDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDir.Enabled = false;
            this.btnDir.Image = ((System.Drawing.Image)(resources.GetObject("btnDir.Image")));
            this.btnDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(52, 22);
            this.btnDir.Text = "Diretório";
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnGo
            // 
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGo.Enabled = false;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(42, 22);
            this.btnGo.Text = "Trocar";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // fdCrit
            // 
            this.fdCrit.FileName = "fdCrit";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdvTexto);
            this.panel2.Location = new System.Drawing.Point(237, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 268);
            this.panel2.TabIndex = 2;
            // 
            // gdvTexto
            // 
            this.gdvTexto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvTexto.Location = new System.Drawing.Point(0, 0);
            this.gdvTexto.Name = "gdvTexto";
            this.gdvTexto.Size = new System.Drawing.Size(478, 268);
            this.gdvTexto.TabIndex = 0;
            // 
            // foDir
            // 
            this.foDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.foDir.ShowNewFolderButton = false;
            // 
            // treeVw
            // 
            this.treeVw.Location = new System.Drawing.Point(0, 29);
            this.treeVw.Name = "treeVw";
            treeNode4.Name = "Node0";
            treeNode4.Text = "<<Listagem de Arquivos>>";
            this.treeVw.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeVw.Size = new System.Drawing.Size(231, 267);
            this.treeVw.TabIndex = 3;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(13, 303);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(65, 13);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "Mensagem: ";
            // 
            // frmTroca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 379);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.treeVw);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mnuSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTroca";
            this.Text = "Troca Texto";
            this.Load += new System.EventHandler(this.frmTroca_Load);
            this.mnuSup.ResumeLayout(false);
            this.mnuSup.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnuSup;
        private System.Windows.Forms.ToolStripButton btnCrit;
        private System.Windows.Forms.ToolStripTextBox txtExt;
        private System.Windows.Forms.ToolStripButton btnDir;
        private System.Windows.Forms.ToolStripComboBox cmbTipo;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.OpenFileDialog fdCrit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog foDir;
        private System.Windows.Forms.TreeView treeVw;
        private System.Windows.Forms.DataGridView gdvTexto;
        private System.Windows.Forms.Label lblMsg;
    }
}

