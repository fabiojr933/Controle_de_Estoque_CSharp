namespace ControleEstoque
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBCATEGORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNIDADEDEMEDIDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONDIÇÃODEPAGAMENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORNECEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBCATEGORIAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uNIDADEDEMEDIDAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPODEPAGAMENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORNECEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATORIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fERRAMENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALCULADORAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLOCODENOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPLORERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cOMPRAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 422);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.cONSULTAToolStripMenuItem,
            this.mOVIMENTOSToolStripMenuItem,
            this.rELATORIOSToolStripMenuItem,
            this.fERRAMENTASToolStripMenuItem,
            this.sOBREToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cATEGORIAToolStripMenuItem,
            this.sUBCATEGORIAToolStripMenuItem,
            this.uNIDADEDEMEDIDAToolStripMenuItem,
            this.pRODUTOToolStripMenuItem,
            this.cONDIÇÃODEPAGAMENTOToolStripMenuItem,
            this.cLIENTESToolStripMenuItem,
            this.fORNECEDORESToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // cATEGORIAToolStripMenuItem
            // 
            this.cATEGORIAToolStripMenuItem.Name = "cATEGORIAToolStripMenuItem";
            this.cATEGORIAToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cATEGORIAToolStripMenuItem.Text = "CATEGORIA";
            this.cATEGORIAToolStripMenuItem.Click += new System.EventHandler(this.cATEGORIAToolStripMenuItem_Click);
            // 
            // sUBCATEGORIAToolStripMenuItem
            // 
            this.sUBCATEGORIAToolStripMenuItem.Name = "sUBCATEGORIAToolStripMenuItem";
            this.sUBCATEGORIAToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.sUBCATEGORIAToolStripMenuItem.Text = "SUB CATEGORIA";
            this.sUBCATEGORIAToolStripMenuItem.Click += new System.EventHandler(this.sUBCATEGORIAToolStripMenuItem_Click);
            // 
            // uNIDADEDEMEDIDAToolStripMenuItem
            // 
            this.uNIDADEDEMEDIDAToolStripMenuItem.Name = "uNIDADEDEMEDIDAToolStripMenuItem";
            this.uNIDADEDEMEDIDAToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.uNIDADEDEMEDIDAToolStripMenuItem.Text = "UNIDADE DE MEDIDA";
            this.uNIDADEDEMEDIDAToolStripMenuItem.Click += new System.EventHandler(this.uNIDADEDEMEDIDAToolStripMenuItem_Click);
            // 
            // pRODUTOToolStripMenuItem
            // 
            this.pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
            this.pRODUTOToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.pRODUTOToolStripMenuItem.Text = "PRODUTO";
            this.pRODUTOToolStripMenuItem.Click += new System.EventHandler(this.pRODUTOToolStripMenuItem_Click);
            // 
            // cONDIÇÃODEPAGAMENTOToolStripMenuItem
            // 
            this.cONDIÇÃODEPAGAMENTOToolStripMenuItem.Name = "cONDIÇÃODEPAGAMENTOToolStripMenuItem";
            this.cONDIÇÃODEPAGAMENTOToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cONDIÇÃODEPAGAMENTOToolStripMenuItem.Text = "CONDIÇÃO DE PAGAMENTO";
            this.cONDIÇÃODEPAGAMENTOToolStripMenuItem.Click += new System.EventHandler(this.cONDIÇÃODEPAGAMENTOToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // fORNECEDORESToolStripMenuItem
            // 
            this.fORNECEDORESToolStripMenuItem.Name = "fORNECEDORESToolStripMenuItem";
            this.fORNECEDORESToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.fORNECEDORESToolStripMenuItem.Text = "FORNECEDORES";
            this.fORNECEDORESToolStripMenuItem.Click += new System.EventHandler(this.fORNECEDORESToolStripMenuItem_Click);
            // 
            // cONSULTAToolStripMenuItem
            // 
            this.cONSULTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cATEGORIAToolStripMenuItem1,
            this.sUBCATEGORIAToolStripMenuItem1,
            this.uNIDADEDEMEDIDAToolStripMenuItem1,
            this.pRODUTOToolStripMenuItem1,
            this.tIPODEPAGAMENTOToolStripMenuItem,
            this.cLIENTEToolStripMenuItem,
            this.fORNECEDORToolStripMenuItem,
            this.cOMPRAToolStripMenuItem1});
            this.cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            this.cONSULTAToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.cONSULTAToolStripMenuItem.Text = "CONSULTA";
            // 
            // cATEGORIAToolStripMenuItem1
            // 
            this.cATEGORIAToolStripMenuItem1.Name = "cATEGORIAToolStripMenuItem1";
            this.cATEGORIAToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.cATEGORIAToolStripMenuItem1.Text = "CATEGORIA";
            this.cATEGORIAToolStripMenuItem1.Click += new System.EventHandler(this.cATEGORIAToolStripMenuItem1_Click);
            // 
            // sUBCATEGORIAToolStripMenuItem1
            // 
            this.sUBCATEGORIAToolStripMenuItem1.Name = "sUBCATEGORIAToolStripMenuItem1";
            this.sUBCATEGORIAToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.sUBCATEGORIAToolStripMenuItem1.Text = "SUB CATEGORIA";
            this.sUBCATEGORIAToolStripMenuItem1.Click += new System.EventHandler(this.sUBCATEGORIAToolStripMenuItem1_Click);
            // 
            // uNIDADEDEMEDIDAToolStripMenuItem1
            // 
            this.uNIDADEDEMEDIDAToolStripMenuItem1.Name = "uNIDADEDEMEDIDAToolStripMenuItem1";
            this.uNIDADEDEMEDIDAToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.uNIDADEDEMEDIDAToolStripMenuItem1.Text = "UNIDADE DE MEDIDA";
            this.uNIDADEDEMEDIDAToolStripMenuItem1.Click += new System.EventHandler(this.uNIDADEDEMEDIDAToolStripMenuItem1_Click);
            // 
            // pRODUTOToolStripMenuItem1
            // 
            this.pRODUTOToolStripMenuItem1.Name = "pRODUTOToolStripMenuItem1";
            this.pRODUTOToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.pRODUTOToolStripMenuItem1.Text = "PRODUTO";
            this.pRODUTOToolStripMenuItem1.Click += new System.EventHandler(this.pRODUTOToolStripMenuItem1_Click);
            // 
            // tIPODEPAGAMENTOToolStripMenuItem
            // 
            this.tIPODEPAGAMENTOToolStripMenuItem.Name = "tIPODEPAGAMENTOToolStripMenuItem";
            this.tIPODEPAGAMENTOToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.tIPODEPAGAMENTOToolStripMenuItem.Text = "TIPO DE PAGAMENTO";
            this.tIPODEPAGAMENTOToolStripMenuItem.Click += new System.EventHandler(this.tIPODEPAGAMENTOToolStripMenuItem_Click);
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // fORNECEDORToolStripMenuItem
            // 
            this.fORNECEDORToolStripMenuItem.Name = "fORNECEDORToolStripMenuItem";
            this.fORNECEDORToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.fORNECEDORToolStripMenuItem.Text = "FORNECEDOR";
            this.fORNECEDORToolStripMenuItem.Click += new System.EventHandler(this.fORNECEDORToolStripMenuItem_Click);
            // 
            // mOVIMENTOSToolStripMenuItem
            // 
            this.mOVIMENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRAToolStripMenuItem,
            this.vENDAToolStripMenuItem});
            this.mOVIMENTOSToolStripMenuItem.Name = "mOVIMENTOSToolStripMenuItem";
            this.mOVIMENTOSToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mOVIMENTOSToolStripMenuItem.Text = "MOVIMENTOS";
            // 
            // cOMPRAToolStripMenuItem
            // 
            this.cOMPRAToolStripMenuItem.Name = "cOMPRAToolStripMenuItem";
            this.cOMPRAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cOMPRAToolStripMenuItem.Text = "COMPRA";
            this.cOMPRAToolStripMenuItem.Click += new System.EventHandler(this.cOMPRAToolStripMenuItem_Click);
            // 
            // vENDAToolStripMenuItem
            // 
            this.vENDAToolStripMenuItem.Name = "vENDAToolStripMenuItem";
            this.vENDAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vENDAToolStripMenuItem.Text = "VENDA";
            // 
            // rELATORIOSToolStripMenuItem
            // 
            this.rELATORIOSToolStripMenuItem.Name = "rELATORIOSToolStripMenuItem";
            this.rELATORIOSToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.rELATORIOSToolStripMenuItem.Text = "RELATORIOS";
            // 
            // fERRAMENTASToolStripMenuItem
            // 
            this.fERRAMENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem,
            this.bACKUPToolStripMenuItem,
            this.cALCULADORAToolStripMenuItem,
            this.bLOCODENOTASToolStripMenuItem,
            this.eXPLORERToolStripMenuItem});
            this.fERRAMENTASToolStripMenuItem.Name = "fERRAMENTASToolStripMenuItem";
            this.fERRAMENTASToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.fERRAMENTASToolStripMenuItem.Text = "FERRAMENTAS";
            // 
            // cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem
            // 
            this.cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem.Name = "cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem";
            this.cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem.Text = "CONFIGURAÇÃO DO BANCO DE DADOS";
            this.cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem.Click += new System.EventHandler(this.cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem_Click);
            // 
            // bACKUPToolStripMenuItem
            // 
            this.bACKUPToolStripMenuItem.Name = "bACKUPToolStripMenuItem";
            this.bACKUPToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.bACKUPToolStripMenuItem.Text = "BACKUP";
            this.bACKUPToolStripMenuItem.Click += new System.EventHandler(this.bACKUPToolStripMenuItem_Click);
            // 
            // cALCULADORAToolStripMenuItem
            // 
            this.cALCULADORAToolStripMenuItem.Name = "cALCULADORAToolStripMenuItem";
            this.cALCULADORAToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.cALCULADORAToolStripMenuItem.Text = "CALCULADORA";
            // 
            // bLOCODENOTASToolStripMenuItem
            // 
            this.bLOCODENOTASToolStripMenuItem.Name = "bLOCODENOTASToolStripMenuItem";
            this.bLOCODENOTASToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.bLOCODENOTASToolStripMenuItem.Text = "BLOCO DE NOTAS";
            // 
            // eXPLORERToolStripMenuItem
            // 
            this.eXPLORERToolStripMenuItem.Name = "eXPLORERToolStripMenuItem";
            this.eXPLORERToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.eXPLORERToolStripMenuItem.Text = "EXPLORER";
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sOBREToolStripMenuItem.Text = "SOBRE";
            this.sOBREToolStripMenuItem.Click += new System.EventHandler(this.sOBREToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sairToolStripMenuItem.Text = "SAIR";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jr Sistemas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Supervisor";
            // 
            // cOMPRAToolStripMenuItem1
            // 
            this.cOMPRAToolStripMenuItem1.Name = "cOMPRAToolStripMenuItem1";
            this.cOMPRAToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.cOMPRAToolStripMenuItem1.Text = "COMPRA";
            this.cOMPRAToolStripMenuItem1.Click += new System.EventHandler(this.cOMPRAToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBCATEGORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNIDADEDEMEDIDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONDIÇÃODEPAGAMENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORNECEDORESToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sUBCATEGORIAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uNIDADEDEMEDIDAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tIPODEPAGAMENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORNECEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATORIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fERRAMENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALCULADORAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLOCODENOTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXPLORERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRAToolStripMenuItem1;
    }
}

