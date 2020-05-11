namespace View
{
    partial class frmMovimentacaoCompra
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.txtInserir = new MetroFramework.Controls.MetroButton();
            this.txtQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.btnLocalizarProd = new MetroFramework.Controls.MetroButton();
            this.txtCodProduto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnLocalizaFor = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.GridItens = new System.Windows.Forms.DataGridView();
            this.forCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorUnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbPagamento = new MetroFramework.Controls.MetroComboBox();
            this.cbParcelas = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblPagamento = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.dateCompra = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNotaFiscal = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelParcelas = new System.Windows.Forms.Panel();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblParcelaCompras = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDadosPagamentos = new System.Windows.Forms.Label();
            this.GridParcelas = new System.Windows.Forms.DataGridView();
            this.pcoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcoDataVcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).BeginInit();
            this.panelParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnLocalizar);
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Location = new System.Drawing.Point(11, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 101);
            this.panel2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cancelar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salvar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Excluir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Editar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Localizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Novo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::View.Properties.Resources.cancelar22;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(521, 41);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 50);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::View.Properties.Resources.salvar22;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(460, 41);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(55, 50);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::View.Properties.Resources.excluir22;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(399, 41);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(55, 50);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::View.Properties.Resources.editar22;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(338, 41);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(55, 50);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackgroundImage = global::View.Properties.Resources.lupa22;
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.Location = new System.Drawing.Point(277, 41);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(55, 50);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::View.Properties.Resources.novo22;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.Location = new System.Drawing.Point(216, 41);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(55, 50);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Controls.Add(this.lblFornecedor);
            this.panel1.Controls.Add(this.metroLabel13);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtInserir);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.btnLocalizarProd);
            this.panel1.Controls.Add(this.txtCodProduto);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.btnLocalizaFor);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.GridItens);
            this.panel1.Controls.Add(this.dataPagamento);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.cbPagamento);
            this.panel1.Controls.Add(this.cbParcelas);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.lblPagamento);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.dateCompra);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.txtNotaFiscal);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(11, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 435);
            this.panel1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 39;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(436, 178);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(714, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quantidade";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(21, 128);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(295, 17);
            this.lblProduto.TabIndex = 33;
            this.lblProduto.Text = "Clique em Localizar para Vincular um produto";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(262, 86);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(315, 17);
            this.lblFornecedor.TabIndex = 32;
            this.lblFornecedor.Text = "Clique em Localizar para Vincular um fornecedor";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(12, 200);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(107, 19);
            this.metroLabel13.TabIndex = 31;
            this.metroLabel13.Text = "Itens da Compra";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(463, 174);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(110, 23);
            this.txtValor.TabIndex = 30;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInserir
            // 
            this.txtInserir.Location = new System.Drawing.Point(573, 174);
            this.txtInserir.Name = "txtInserir";
            this.txtInserir.Size = new System.Drawing.Size(35, 23);
            this.txtInserir.TabIndex = 28;
            this.txtInserir.Text = "+";
            this.txtInserir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtInserir.UseSelectable = true;
            this.txtInserir.Click += new System.EventHandler(this.txtInserir_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtQuantidade.CustomButton.Image = null;
            this.txtQuantidade.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtQuantidade.CustomButton.Name = "";
            this.txtQuantidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantidade.CustomButton.TabIndex = 1;
            this.txtQuantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantidade.CustomButton.UseSelectable = true;
            this.txtQuantidade.CustomButton.Visible = false;
            this.txtQuantidade.Lines = new string[0];
            this.txtQuantidade.Location = new System.Drawing.Point(325, 174);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.ShortcutsEnabled = true;
            this.txtQuantidade.Size = new System.Drawing.Size(105, 23);
            this.txtQuantidade.TabIndex = 27;
            this.txtQuantidade.UseSelectable = true;
            this.txtQuantidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLocalizarProd
            // 
            this.btnLocalizarProd.Location = new System.Drawing.Point(139, 174);
            this.btnLocalizarProd.Name = "btnLocalizarProd";
            this.btnLocalizarProd.Size = new System.Drawing.Size(110, 23);
            this.btnLocalizarProd.TabIndex = 24;
            this.btnLocalizarProd.Text = "Localizar";
            this.btnLocalizarProd.UseSelectable = true;
            this.btnLocalizarProd.Click += new System.EventHandler(this.btnLocalizarProd_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCodProduto.CustomButton.Image = null;
            this.txtCodProduto.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtCodProduto.CustomButton.Name = "";
            this.txtCodProduto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodProduto.CustomButton.TabIndex = 1;
            this.txtCodProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodProduto.CustomButton.UseSelectable = true;
            this.txtCodProduto.CustomButton.Visible = false;
            this.txtCodProduto.Lines = new string[0];
            this.txtCodProduto.Location = new System.Drawing.Point(24, 174);
            this.txtCodProduto.MaxLength = 32767;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.PasswordChar = '\0';
            this.txtCodProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodProduto.SelectedText = "";
            this.txtCodProduto.SelectionLength = 0;
            this.txtCodProduto.SelectionStart = 0;
            this.txtCodProduto.ShortcutsEnabled = true;
            this.txtCodProduto.Size = new System.Drawing.Size(105, 23);
            this.txtCodProduto.TabIndex = 23;
            this.txtCodProduto.UseSelectable = true;
            this.txtCodProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 152);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Cod Produto";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(12, 109);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(825, 19);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------";
            // 
            // btnLocalizaFor
            // 
            this.btnLocalizaFor.Location = new System.Drawing.Point(139, 83);
            this.btnLocalizaFor.Name = "btnLocalizaFor";
            this.btnLocalizaFor.Size = new System.Drawing.Size(105, 23);
            this.btnLocalizaFor.TabIndex = 19;
            this.btnLocalizaFor.Text = "Localizar";
            this.btnLocalizaFor.UseSelectable = true;
            this.btnLocalizaFor.Click += new System.EventHandler(this.btnLocalizaFor_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(24, 63);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Fornecedor";
            // 
            // GridItens
            // 
            this.GridItens.AllowUserToAddRows = false;
            this.GridItens.AllowUserToDeleteRows = false;
            this.GridItens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forCodigo,
            this.forNome,
            this.forQTD,
            this.proValorUnid,
            this.proValorTotal});
            this.GridItens.Location = new System.Drawing.Point(12, 222);
            this.GridItens.Name = "GridItens";
            this.GridItens.ReadOnly = true;
            this.GridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItens.Size = new System.Drawing.Size(816, 135);
            this.GridItens.TabIndex = 16;
            this.GridItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItens_CellDoubleClick);
            // 
            // forCodigo
            // 
            this.forCodigo.HeaderText = "Codigo";
            this.forCodigo.Name = "forCodigo";
            this.forCodigo.ReadOnly = true;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome Produto";
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 300;
            // 
            // forQTD
            // 
            this.forQTD.HeaderText = "Quantidade";
            this.forQTD.Name = "forQTD";
            this.forQTD.ReadOnly = true;
            this.forQTD.Width = 120;
            // 
            // proValorUnid
            // 
            this.proValorUnid.HeaderText = "Valor Unitario";
            this.proValorUnid.Name = "proValorUnid";
            this.proValorUnid.ReadOnly = true;
            this.proValorUnid.Width = 120;
            // 
            // proValorTotal
            // 
            this.proValorTotal.HeaderText = "Valor Total";
            this.proValorTotal.Name = "proValorTotal";
            this.proValorTotal.ReadOnly = true;
            this.proValorTotal.Width = 120;
            // 
            // dataPagamento
            // 
            this.dataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPagamento.Location = new System.Drawing.Point(424, 395);
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.Size = new System.Drawing.Size(143, 20);
            this.dataPagamento.TabIndex = 15;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(424, 364);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(143, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Data Inicial Pagamento";
            // 
            // cbPagamento
            // 
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.ItemHeight = 23;
            this.cbPagamento.Location = new System.Drawing.Point(219, 392);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(174, 29);
            this.cbPagamento.TabIndex = 13;
            this.cbPagamento.UseSelectable = true;
            // 
            // cbParcelas
            // 
            this.cbParcelas.FormattingEnabled = true;
            this.cbParcelas.ItemHeight = 23;
            this.cbParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbParcelas.Location = new System.Drawing.Point(18, 392);
            this.cbParcelas.Name = "cbParcelas";
            this.cbParcelas.Size = new System.Drawing.Size(157, 29);
            this.cbParcelas.TabIndex = 12;
            this.cbParcelas.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 370);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "N° Parcelas";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(213, 370);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(106, 19);
            this.lblPagamento.TabIndex = 9;
            this.lblPagamento.Text = "Tipo Pagamento";
            // 
            // txtTotal
            // 
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(717, 392);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(105, 23);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateCompra
            // 
            this.dateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompra.Location = new System.Drawing.Point(265, 35);
            this.dateCompra.Name = "dateCompra";
            this.dateCompra.Size = new System.Drawing.Size(107, 20);
            this.dateCompra.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(265, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Data";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNotaFiscal.CustomButton.Image = null;
            this.txtNotaFiscal.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtNotaFiscal.CustomButton.Name = "";
            this.txtNotaFiscal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNotaFiscal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotaFiscal.CustomButton.TabIndex = 1;
            this.txtNotaFiscal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotaFiscal.CustomButton.UseSelectable = true;
            this.txtNotaFiscal.CustomButton.Visible = false;
            this.txtNotaFiscal.Lines = new string[0];
            this.txtNotaFiscal.Location = new System.Drawing.Point(144, 34);
            this.txtNotaFiscal.MaxLength = 32767;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.PasswordChar = '\0';
            this.txtNotaFiscal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotaFiscal.SelectedText = "";
            this.txtNotaFiscal.SelectionLength = 0;
            this.txtNotaFiscal.SelectionStart = 0;
            this.txtNotaFiscal.ShortcutsEnabled = true;
            this.txtNotaFiscal.Size = new System.Drawing.Size(105, 23);
            this.txtNotaFiscal.TabIndex = 4;
            this.txtNotaFiscal.UseSelectable = true;
            this.txtNotaFiscal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotaFiscal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(24, 34);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(105, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(144, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "N° Nota Fiscal";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Codigo";
            // 
            // panelParcelas
            // 
            this.panelParcelas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelParcelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParcelas.Controls.Add(this.lblTotalCompra);
            this.panelParcelas.Controls.Add(this.label10);
            this.panelParcelas.Controls.Add(this.label13);
            this.panelParcelas.Controls.Add(this.label14);
            this.panelParcelas.Controls.Add(this.button1);
            this.panelParcelas.Controls.Add(this.button2);
            this.panelParcelas.Controls.Add(this.lblParcelaCompras);
            this.panelParcelas.Controls.Add(this.label11);
            this.panelParcelas.Controls.Add(this.lblDadosPagamentos);
            this.panelParcelas.Controls.Add(this.GridParcelas);
            this.panelParcelas.Location = new System.Drawing.Point(698, 27);
            this.panelParcelas.Name = "panelParcelas";
            this.panelParcelas.Size = new System.Drawing.Size(484, 555);
            this.panelParcelas.TabIndex = 32;
            this.panelParcelas.Visible = false;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.BackColor = System.Drawing.Color.Red;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(314, 459);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(152, 20);
            this.lblTotalCompra.TabIndex = 17;
            this.lblTotalCompra.Text = "Parcelas da Compra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "TOTAL COMPRA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(74, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Cancelar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Salvar";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::View.Properties.Resources.cancelar22;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(77, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 50);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::View.Properties.Resources.salvar22;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(16, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 50);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblParcelaCompras
            // 
            this.lblParcelaCompras.AutoSize = true;
            this.lblParcelaCompras.Location = new System.Drawing.Point(13, 67);
            this.lblParcelaCompras.Name = "lblParcelaCompras";
            this.lblParcelaCompras.Size = new System.Drawing.Size(102, 13);
            this.lblParcelaCompras.TabIndex = 3;
            this.lblParcelaCompras.Text = "Parcelas da Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(439, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------";
            // 
            // lblDadosPagamentos
            // 
            this.lblDadosPagamentos.AutoSize = true;
            this.lblDadosPagamentos.Location = new System.Drawing.Point(13, 18);
            this.lblDadosPagamentos.Name = "lblDadosPagamentos";
            this.lblDadosPagamentos.Size = new System.Drawing.Size(110, 13);
            this.lblDadosPagamentos.TabIndex = 1;
            this.lblDadosPagamentos.Text = "Dados do Pagamento";
            // 
            // GridParcelas
            // 
            this.GridParcelas.AllowUserToAddRows = false;
            this.GridParcelas.AllowUserToDeleteRows = false;
            this.GridParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pcoCodigo,
            this.pcoValor,
            this.pcoDataVcto});
            this.GridParcelas.Location = new System.Drawing.Point(16, 109);
            this.GridParcelas.Name = "GridParcelas";
            this.GridParcelas.ReadOnly = true;
            this.GridParcelas.Size = new System.Drawing.Size(446, 326);
            this.GridParcelas.TabIndex = 0;
            // 
            // pcoCodigo
            // 
            this.pcoCodigo.HeaderText = "Parcela";
            this.pcoCodigo.Name = "pcoCodigo";
            this.pcoCodigo.ReadOnly = true;
            // 
            // pcoValor
            // 
            this.pcoValor.HeaderText = "Valor da Parcela";
            this.pcoValor.Name = "pcoValor";
            this.pcoValor.ReadOnly = true;
            this.pcoValor.Width = 150;
            // 
            // pcoDataVcto
            // 
            this.pcoDataVcto.HeaderText = "Data do Vencimento";
            this.pcoDataVcto.Name = "pcoDataVcto";
            this.pcoDataVcto.ReadOnly = true;
            this.pcoDataVcto.Width = 150;
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 651);
            this.Controls.Add(this.panelParcelas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentacaoCompra";
            this.Text = "Movimentação Compra";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItens)).EndInit();
            this.panelParcelas.ResumeLayout(false);
            this.panelParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dataPagamento;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbPagamento;
        private MetroFramework.Controls.MetroComboBox cbParcelas;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblPagamento;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dateCompra;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNotaFiscal;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnLocalizaFor;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridView GridItens;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton txtInserir;
        private MetroFramework.Controls.MetroTextBox txtQuantidade;
        private MetroFramework.Controls.MetroButton btnLocalizarProd;
        private MetroFramework.Controls.MetroTextBox txtCodProduto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.Label lblFornecedor;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn forCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorUnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorTotal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Panel panelParcelas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblParcelaCompras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDadosPagamentos;
        private System.Windows.Forms.DataGridView GridParcelas;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcoDataVcto;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private System.Windows.Forms.TextBox textBox2;
    }
}