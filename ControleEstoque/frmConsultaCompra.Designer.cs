namespace View
{
    partial class frmConsultaCompra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.lblCodigoFornecedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGeral = new MetroFramework.Controls.MetroRadioButton();
            this.radioParcelasAbertas = new MetroFramework.Controls.MetroRadioButton();
            this.radioDataCompra = new MetroFramework.Controls.MetroRadioButton();
            this.radioNome = new MetroFramework.Controls.MetroRadioButton();
            this.GridCompra = new System.Windows.Forms.DataGridView();
            this.panelData = new System.Windows.Forms.Panel();
            this.dateIncial = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabDados = new System.Windows.Forms.TabControl();
            this.tabCompra = new System.Windows.Forms.TabPage();
            this.tabParcelas = new System.Windows.Forms.TabPage();
            this.tabItens = new System.Windows.Forms.TabPage();
            this.GridCompra2 = new System.Windows.Forms.DataGridView();
            this.GridItens = new System.Windows.Forms.DataGridView();
            this.GridParcela2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelFornecedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompra)).BeginInit();
            this.panelData.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabCompra.SuspendLayout();
            this.tabParcelas.SuspendLayout();
            this.tabItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridParcela2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabDados);
            this.panel1.Controls.Add(this.panelData);
            this.panel1.Controls.Add(this.panelFornecedor);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 484);
            this.panel1.TabIndex = 2;
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Controls.Add(this.lblNomeFornecedor);
            this.panelFornecedor.Controls.Add(this.btnLocalizar);
            this.panelFornecedor.Controls.Add(this.txtCodigoFornecedor);
            this.panelFornecedor.Controls.Add(this.lblCodigoFornecedor);
            this.panelFornecedor.Location = new System.Drawing.Point(17, 67);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(575, 100);
            this.panelFornecedor.TabIndex = 9;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(204, 51);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(0, 13);
            this.lblNomeFornecedor.TabIndex = 3;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(113, 42);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.Enabled = false;
            this.txtCodigoFornecedor.Location = new System.Drawing.Point(7, 44);
            this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
            this.txtCodigoFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFornecedor.TabIndex = 1;
            // 
            // lblCodigoFornecedor
            // 
            this.lblCodigoFornecedor.AutoSize = true;
            this.lblCodigoFornecedor.Location = new System.Drawing.Point(4, 15);
            this.lblCodigoFornecedor.Name = "lblCodigoFornecedor";
            this.lblCodigoFornecedor.Size = new System.Drawing.Size(97, 13);
            this.lblCodigoFornecedor.TabIndex = 0;
            this.lblCodigoFornecedor.Text = "Codigo Fornecedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGeral);
            this.groupBox1.Controls.Add(this.radioParcelasAbertas);
            this.groupBox1.Controls.Add(this.radioDataCompra);
            this.groupBox1.Controls.Add(this.radioNome);
            this.groupBox1.Location = new System.Drawing.Point(17, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Consulta";
            // 
            // radioGeral
            // 
            this.radioGeral.AutoSize = true;
            this.radioGeral.Location = new System.Drawing.Point(7, 30);
            this.radioGeral.Name = "radioGeral";
            this.radioGeral.Size = new System.Drawing.Size(118, 15);
            this.radioGeral.TabIndex = 3;
            this.radioGeral.Text = "Todas as Compras";
            this.radioGeral.UseSelectable = true;
            this.radioGeral.CheckedChanged += new System.EventHandler(this.radioGeral_CheckedChanged);
            // 
            // radioParcelasAbertas
            // 
            this.radioParcelasAbertas.AutoSize = true;
            this.radioParcelasAbertas.Location = new System.Drawing.Point(430, 30);
            this.radioParcelasAbertas.Name = "radioParcelasAbertas";
            this.radioParcelasAbertas.Size = new System.Drawing.Size(109, 15);
            this.radioParcelasAbertas.TabIndex = 2;
            this.radioParcelasAbertas.Text = "Parcelas Abertas";
            this.radioParcelasAbertas.UseSelectable = true;
            this.radioParcelasAbertas.CheckedChanged += new System.EventHandler(this.radioGeral_CheckedChanged);
            // 
            // radioDataCompra
            // 
            this.radioDataCompra.AutoSize = true;
            this.radioDataCompra.Location = new System.Drawing.Point(324, 30);
            this.radioDataCompra.Name = "radioDataCompra";
            this.radioDataCompra.Size = new System.Drawing.Size(47, 15);
            this.radioDataCompra.TabIndex = 1;
            this.radioDataCompra.Text = "Data";
            this.radioDataCompra.UseSelectable = true;
            this.radioDataCompra.CheckedChanged += new System.EventHandler(this.radioGeral_CheckedChanged);
            // 
            // radioNome
            // 
            this.radioNome.AutoSize = true;
            this.radioNome.Location = new System.Drawing.Point(162, 30);
            this.radioNome.Name = "radioNome";
            this.radioNome.Size = new System.Drawing.Size(119, 15);
            this.radioNome.TabIndex = 0;
            this.radioNome.Text = "Nome Fornecedor";
            this.radioNome.UseSelectable = true;
            this.radioNome.CheckedChanged += new System.EventHandler(this.radioGeral_CheckedChanged);
            // 
            // GridCompra
            // 
            this.GridCompra.AllowUserToAddRows = false;
            this.GridCompra.AllowUserToDeleteRows = false;
            this.GridCompra.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCompra.Location = new System.Drawing.Point(6, 6);
            this.GridCompra.Name = "GridCompra";
            this.GridCompra.ReadOnly = true;
            this.GridCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCompra.Size = new System.Drawing.Size(531, 223);
            this.GridCompra.TabIndex = 5;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.btnBuscar);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.dateFinal);
            this.panelData.Controls.Add(this.dateIncial);
            this.panelData.Location = new System.Drawing.Point(17, 67);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(575, 100);
            this.panelData.TabIndex = 4;
            this.panelData.Visible = false;
            // 
            // dateIncial
            // 
            this.dateIncial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIncial.Location = new System.Drawing.Point(33, 51);
            this.dateIncial.Name = "dateIncial";
            this.dateIncial.Size = new System.Drawing.Size(92, 20);
            this.dateIncial.TabIndex = 0;
            this.dateIncial.Value = new System.DateTime(2020, 5, 10, 0, 0, 0, 0);
            // 
            // dateFinal
            // 
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.Location = new System.Drawing.Point(162, 51);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(92, 20);
            this.dateFinal.TabIndex = 1;
            this.dateFinal.Value = new System.DateTime(2020, 5, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(292, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.tabCompra);
            this.tabDados.Controls.Add(this.tabParcelas);
            this.tabDados.Controls.Add(this.tabItens);
            this.tabDados.Location = new System.Drawing.Point(24, 204);
            this.tabDados.Name = "tabDados";
            this.tabDados.SelectedIndex = 0;
            this.tabDados.Size = new System.Drawing.Size(551, 261);
            this.tabDados.TabIndex = 10;
            // 
            // tabCompra
            // 
            this.tabCompra.Controls.Add(this.GridCompra2);
            this.tabCompra.Controls.Add(this.GridCompra);
            this.tabCompra.Location = new System.Drawing.Point(4, 22);
            this.tabCompra.Name = "tabCompra";
            this.tabCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompra.Size = new System.Drawing.Size(543, 235);
            this.tabCompra.TabIndex = 0;
            this.tabCompra.Text = "Compra";
            this.tabCompra.UseVisualStyleBackColor = true;
            // 
            // tabParcelas
            // 
            this.tabParcelas.Controls.Add(this.GridParcela2);
            this.tabParcelas.Location = new System.Drawing.Point(4, 22);
            this.tabParcelas.Name = "tabParcelas";
            this.tabParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tabParcelas.Size = new System.Drawing.Size(543, 235);
            this.tabParcelas.TabIndex = 1;
            this.tabParcelas.Text = "Parcelas";
            this.tabParcelas.UseVisualStyleBackColor = true;
            // 
            // tabItens
            // 
            this.tabItens.Controls.Add(this.GridItens);
            this.tabItens.Location = new System.Drawing.Point(4, 22);
            this.tabItens.Name = "tabItens";
            this.tabItens.Padding = new System.Windows.Forms.Padding(3);
            this.tabItens.Size = new System.Drawing.Size(543, 235);
            this.tabItens.TabIndex = 2;
            this.tabItens.Text = "Itens Compra";
            this.tabItens.UseVisualStyleBackColor = true;
            // 
            // GridCompra2
            // 
            this.GridCompra2.AllowUserToAddRows = false;
            this.GridCompra2.AllowUserToDeleteRows = false;
            this.GridCompra2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridCompra2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCompra2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCompra2.Location = new System.Drawing.Point(6, 6);
            this.GridCompra2.Name = "GridCompra2";
            this.GridCompra2.ReadOnly = true;
            this.GridCompra2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCompra2.Size = new System.Drawing.Size(531, 223);
            this.GridCompra2.TabIndex = 6;
            this.GridCompra2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCompra2_CellClick);
            this.GridCompra2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCompra2_CellDoubleClick);
            // 
            // GridItens
            // 
            this.GridItens.AllowUserToAddRows = false;
            this.GridItens.AllowUserToDeleteRows = false;
            this.GridItens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItens.Location = new System.Drawing.Point(6, 6);
            this.GridItens.Name = "GridItens";
            this.GridItens.ReadOnly = true;
            this.GridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItens.Size = new System.Drawing.Size(531, 223);
            this.GridItens.TabIndex = 6;
            // 
            // GridParcela2
            // 
            this.GridParcela2.AllowUserToAddRows = false;
            this.GridParcela2.AllowUserToDeleteRows = false;
            this.GridParcela2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridParcela2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridParcela2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridParcela2.Location = new System.Drawing.Point(6, 6);
            this.GridParcela2.Name = "GridParcela2";
            this.GridParcela2.ReadOnly = true;
            this.GridParcela2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridParcela2.Size = new System.Drawing.Size(531, 223);
            this.GridParcela2.TabIndex = 7;
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 570);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCompra";
            this.Text = "Consulta Compra";
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompra)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.tabDados.ResumeLayout(false);
            this.tabCompra.ResumeLayout(false);
            this.tabParcelas.ResumeLayout(false);
            this.tabItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCompra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridParcela2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton radioGeral;
        private MetroFramework.Controls.MetroRadioButton radioParcelasAbertas;
        private MetroFramework.Controls.MetroRadioButton radioDataCompra;
        private MetroFramework.Controls.MetroRadioButton radioNome;
        private System.Windows.Forms.DataGridView GridCompra;
        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtCodigoFornecedor;
        private System.Windows.Forms.Label lblCodigoFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.DateTimePicker dateIncial;
        private System.Windows.Forms.TabControl tabDados;
        private System.Windows.Forms.TabPage tabCompra;
        private System.Windows.Forms.TabPage tabParcelas;
        private System.Windows.Forms.TabPage tabItens;
        private System.Windows.Forms.DataGridView GridCompra2;
        private System.Windows.Forms.DataGridView GridItens;
        private System.Windows.Forms.DataGridView GridParcela2;
    }
}