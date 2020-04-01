namespace GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNomeFor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNomePro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodCom = new System.Windows.Forms.TextBox();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.dtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.btlFornecedor = new System.Windows.Forms.Button();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.btlProduto = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.ProCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.cbTPagto = new System.Windows.Forms.ComboBox();
            this.dtIniPgto = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btCancelaParcelas = new System.Windows.Forms.Button();
            this.btSalvarParcelas = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label18);
            this.pnDados.Controls.Add(this.label17);
            this.pnDados.Controls.Add(this.txtTotal);
            this.pnDados.Controls.Add(this.dtIniPgto);
            this.pnDados.Controls.Add(this.cbTPagto);
            this.pnDados.Controls.Add(this.cbNParcelas);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.btAdd);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.btlProduto);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.btlFornecedor);
            this.pnDados.Controls.Add(this.txtForCod);
            this.pnDados.Controls.Add(this.dtDataCompra);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.txtCodCom);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.lbNomePro);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.lbNomeFor);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número da nota Fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data da Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código do fornecedor";
            // 
            // lbNomeFor
            // 
            this.lbNomeFor.AutoSize = true;
            this.lbNomeFor.Location = new System.Drawing.Point(236, 86);
            this.lbNomeFor.Name = "lbNomeFor";
            this.lbNomeFor.Size = new System.Drawing.Size(259, 13);
            this.lbNomeFor.TabIndex = 4;
            this.lbNomeFor.Text = "Informe o código do fornecedor ou clique em localizar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(703, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Código do Produto:";
            // 
            // lbNomePro
            // 
            this.lbNomePro.AutoSize = true;
            this.lbNomePro.Location = new System.Drawing.Point(145, 128);
            this.lbNomePro.Name = "lbNomePro";
            this.lbNomePro.Size = new System.Drawing.Size(244, 13);
            this.lbNomePro.TabIndex = 7;
            this.lbNomePro.Text = "Informe o código do produto ou clique em localizar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(548, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor Unitário";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Itens da Compra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nº de parcelas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tipo de Pagamento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Data Inicio do pagamento";
            // 
            // txtCodCom
            // 
            this.txtCodCom.Enabled = false;
            this.txtCodCom.Location = new System.Drawing.Point(42, 29);
            this.txtCodCom.Name = "txtCodCom";
            this.txtCodCom.Size = new System.Drawing.Size(83, 20);
            this.txtCodCom.TabIndex = 14;
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Location = new System.Drawing.Point(131, 29);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(152, 20);
            this.txtNFiscal.TabIndex = 15;
            this.txtNFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNFiscal_KeyPress);
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataCompra.Location = new System.Drawing.Point(289, 29);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(109, 20);
            this.dtDataCompra.TabIndex = 16;
            // 
            // txtForCod
            // 
            this.txtForCod.Location = new System.Drawing.Point(42, 83);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(106, 20);
            this.txtForCod.TabIndex = 17;
            this.txtForCod.Leave += new System.EventHandler(this.txtForCod_Leave);
            // 
            // btlFornecedor
            // 
            this.btlFornecedor.Location = new System.Drawing.Point(155, 80);
            this.btlFornecedor.Name = "btlFornecedor";
            this.btlFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btlFornecedor.TabIndex = 18;
            this.btlFornecedor.Text = "Localizar";
            this.btlFornecedor.UseVisualStyleBackColor = true;
            this.btlFornecedor.Click += new System.EventHandler(this.btlFornecedor_Click);
            // 
            // txtProCod
            // 
            this.txtProCod.Location = new System.Drawing.Point(44, 145);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(136, 20);
            this.txtProCod.TabIndex = 19;
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // btlProduto
            // 
            this.btlProduto.Location = new System.Drawing.Point(186, 143);
            this.btlProduto.Name = "btlProduto";
            this.btlProduto.Size = new System.Drawing.Size(75, 23);
            this.btlProduto.TabIndex = 20;
            this.btlProduto.Text = "Localizar";
            this.btlProduto.UseVisualStyleBackColor = true;
            this.btlProduto.Click += new System.EventHandler(this.btlProduto_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(399, 144);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(108, 20);
            this.txtQtde.TabIndex = 21;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(551, 144);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(115, 20);
            this.txtValor.TabIndex = 22;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(670, 143);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(38, 23);
            this.btAdd.TabIndex = 23;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProCod,
            this.ProNome,
            this.ProQtde,
            this.ProvUnit,
            this.ProvTotal});
            this.dgvItens.Location = new System.Drawing.Point(42, 194);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(697, 153);
            this.dgvItens.TabIndex = 24;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // ProCod
            // 
            this.ProCod.HeaderText = "Código";
            this.ProCod.Name = "ProCod";
            this.ProCod.ReadOnly = true;
            this.ProCod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProCod.Width = 60;
            // 
            // ProNome
            // 
            this.ProNome.HeaderText = "Nome";
            this.ProNome.Name = "ProNome";
            this.ProNome.ReadOnly = true;
            this.ProNome.Width = 250;
            // 
            // ProQtde
            // 
            this.ProQtde.HeaderText = "Quantidade";
            this.ProQtde.Name = "ProQtde";
            this.ProQtde.ReadOnly = true;
            // 
            // ProvUnit
            // 
            this.ProvUnit.HeaderText = "Valor Unitário";
            this.ProvUnit.Name = "ProvUnit";
            this.ProvUnit.ReadOnly = true;
            // 
            // ProvTotal
            // 
            this.ProvTotal.HeaderText = "Valor Total";
            this.ProvTotal.Name = "ProvTotal";
            this.ProvTotal.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(587, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Total";
            // 
            // cbNParcelas
            // 
            this.cbNParcelas.FormattingEnabled = true;
            this.cbNParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcelas.Location = new System.Drawing.Point(43, 379);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(74, 21);
            this.cbNParcelas.TabIndex = 26;
            // 
            // cbTPagto
            // 
            this.cbTPagto.FormattingEnabled = true;
            this.cbTPagto.Location = new System.Drawing.Point(144, 379);
            this.cbTPagto.Name = "cbTPagto";
            this.cbTPagto.Size = new System.Drawing.Size(155, 21);
            this.cbTPagto.TabIndex = 27;
            // 
            // dtIniPgto
            // 
            this.dtIniPgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIniPgto.Location = new System.Drawing.Point(338, 379);
            this.dtIniPgto.Name = "dtIniPgto";
            this.dtIniPgto.Size = new System.Drawing.Size(120, 20);
            this.dtIniPgto.TabIndex = 28;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(590, 378);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 20);
            this.txtTotal.TabIndex = 29;
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Controls.Add(this.label5);
            this.pnFinalizaCompra.Controls.Add(this.label8);
            this.pnFinalizaCompra.Controls.Add(this.lbTotal);
            this.pnFinalizaCompra.Controls.Add(this.label20);
            this.pnFinalizaCompra.Controls.Add(this.label19);
            this.pnFinalizaCompra.Controls.Add(this.btCancelaParcelas);
            this.pnFinalizaCompra.Controls.Add(this.btSalvarParcelas);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(15, 12);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(760, 535);
            this.pnFinalizaCompra.TabIndex = 2;
            this.pnFinalizaCompra.Visible = false;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvParcelas.Location = new System.Drawing.Point(7, 46);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(746, 349);
            this.dgvParcelas.TabIndex = 8;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da Parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.HeaderText = "Data do Vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Parcelas da Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dados do Pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(655, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "_________________________________________________________________________________" +
    "___________________________";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Blue;
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(731, 399);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(19, 13);
            this.lbTotal.TabIndex = 33;
            this.lbTotal.Text = "00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(714, 401);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "R$";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(623, 401);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Total da Compra";
            // 
            // btCancelaParcelas
            // 
            this.btCancelaParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelaParcelas.Image = global::GUI.Properties.Resources.Cancelar;
            this.btCancelaParcelas.Location = new System.Drawing.Point(663, 436);
            this.btCancelaParcelas.Name = "btCancelaParcelas";
            this.btCancelaParcelas.Size = new System.Drawing.Size(90, 90);
            this.btCancelaParcelas.TabIndex = 10;
            this.btCancelaParcelas.Text = "Cancelar";
            this.btCancelaParcelas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelaParcelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancelaParcelas.UseVisualStyleBackColor = true;
            this.btCancelaParcelas.Click += new System.EventHandler(this.btCancelaParcelas_Click);
            // 
            // btSalvarParcelas
            // 
            this.btSalvarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarParcelas.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btSalvarParcelas.Location = new System.Drawing.Point(565, 436);
            this.btSalvarParcelas.Name = "btSalvarParcelas";
            this.btSalvarParcelas.Size = new System.Drawing.Size(90, 90);
            this.btSalvarParcelas.TabIndex = 9;
            this.btSalvarParcelas.Text = "Salvar";
            this.btSalvarParcelas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvarParcelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSalvarParcelas.UseVisualStyleBackColor = true;
            this.btSalvarParcelas.Click += new System.EventHandler(this.btSalvarParcelas_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(529, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "R$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(563, 382);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "R$";
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Name = "frmMovimentacaoCompra";
            this.Text = "Cadastro de Compra";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pnFinalizaCompra, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDataCompra;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.TextBox txtCodCom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbNomePro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNomeFor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btlFornecedor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btlProduto;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtIniPgto;
        private System.Windows.Forms.ComboBox cbTPagto;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvTotal;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Button btCancelaParcelas;
        protected System.Windows.Forms.Button btSalvarParcelas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
    }
}
