namespace GUI
{
    partial class frmMovimentacaoVenda
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
            this.pnFinalizaVenda = new System.Windows.Forms.Panel();
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
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.dtIniPgto = new System.Windows.Forms.DateTimePicker();
            this.cbTPagto = new System.Windows.Forms.ComboBox();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.ProCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btlProduto = new System.Windows.Forms.Button();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.btLocCli = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.dtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.txtVenCod = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNomePro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNomeCli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAvista = new System.Windows.Forms.CheckBox();
            this.lbMsg = new System.Windows.Forms.Label();
            this.cbValidaQtde = new System.Windows.Forms.CheckBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.pnFinalizaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.cbValidaQtde);
            this.pnDados.Controls.Add(this.lbMsg);
            this.pnDados.Controls.Add(this.cbxAvista);
            this.pnDados.Controls.Add(this.label18);
            this.pnDados.Controls.Add(this.label17);
            this.pnDados.Controls.Add(this.txtTotalVenda);
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
            this.pnDados.Controls.Add(this.btLocCli);
            this.pnDados.Controls.Add(this.txtCliCod);
            this.pnDados.Controls.Add(this.dtDataCompra);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.txtVenCod);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.lbNomePro);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.lbNomeCli);
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
            this.btExcluir.Text = "Cancelar";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Visible = false;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // pnFinalizaVenda
            // 
            this.pnFinalizaVenda.Controls.Add(this.dgvParcelas);
            this.pnFinalizaVenda.Controls.Add(this.label16);
            this.pnFinalizaVenda.Controls.Add(this.label5);
            this.pnFinalizaVenda.Controls.Add(this.label8);
            this.pnFinalizaVenda.Controls.Add(this.lbTotal);
            this.pnFinalizaVenda.Controls.Add(this.label20);
            this.pnFinalizaVenda.Controls.Add(this.label19);
            this.pnFinalizaVenda.Controls.Add(this.btCancelaParcelas);
            this.pnFinalizaVenda.Controls.Add(this.btSalvarParcelas);
            this.pnFinalizaVenda.Location = new System.Drawing.Point(778, 12);
            this.pnFinalizaVenda.Name = "pnFinalizaVenda";
            this.pnFinalizaVenda.Size = new System.Drawing.Size(760, 535);
            this.pnFinalizaVenda.TabIndex = 3;
            this.pnFinalizaVenda.Visible = false;
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
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Parcelas da Venda";
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
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Total da Venda";
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(553, 389);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "R$";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(519, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "R$";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Location = new System.Drawing.Point(580, 385);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(140, 20);
            this.txtTotalVenda.TabIndex = 61;
            // 
            // dtIniPgto
            // 
            this.dtIniPgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIniPgto.Location = new System.Drawing.Point(274, 386);
            this.dtIniPgto.Name = "dtIniPgto";
            this.dtIniPgto.Size = new System.Drawing.Size(131, 20);
            this.dtIniPgto.TabIndex = 60;
            // 
            // cbTPagto
            // 
            this.cbTPagto.FormattingEnabled = true;
            this.cbTPagto.Location = new System.Drawing.Point(113, 386);
            this.cbTPagto.Name = "cbTPagto";
            this.cbTPagto.Size = new System.Drawing.Size(155, 21);
            this.cbTPagto.TabIndex = 59;
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
            this.cbNParcelas.Location = new System.Drawing.Point(33, 386);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(74, 21);
            this.cbNParcelas.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(577, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Total Venda";
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
            this.dgvItens.Location = new System.Drawing.Point(32, 201);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(697, 153);
            this.dgvItens.TabIndex = 56;
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
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(660, 150);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(38, 23);
            this.btAdd.TabIndex = 55;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(541, 151);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(115, 20);
            this.txtValor.TabIndex = 54;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(389, 151);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(108, 20);
            this.txtQtde.TabIndex = 53;
            // 
            // btlProduto
            // 
            this.btlProduto.Location = new System.Drawing.Point(176, 150);
            this.btlProduto.Name = "btlProduto";
            this.btlProduto.Size = new System.Drawing.Size(75, 23);
            this.btlProduto.TabIndex = 52;
            this.btlProduto.Text = "Localizar";
            this.btlProduto.UseVisualStyleBackColor = true;
            this.btlProduto.Click += new System.EventHandler(this.btlProduto_Click);
            // 
            // txtProCod
            // 
            this.txtProCod.Location = new System.Drawing.Point(34, 152);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(136, 20);
            this.txtProCod.TabIndex = 51;
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // btLocCli
            // 
            this.btLocCli.Location = new System.Drawing.Point(145, 87);
            this.btLocCli.Name = "btLocCli";
            this.btLocCli.Size = new System.Drawing.Size(75, 23);
            this.btLocCli.TabIndex = 50;
            this.btLocCli.Text = "Localizar";
            this.btLocCli.UseVisualStyleBackColor = true;
            this.btLocCli.Click += new System.EventHandler(this.btLocCli_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Location = new System.Drawing.Point(32, 90);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(106, 20);
            this.txtCliCod.TabIndex = 49;
            this.txtCliCod.Leave += new System.EventHandler(this.txtCliCod_Leave);
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataCompra.Location = new System.Drawing.Point(279, 36);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(109, 20);
            this.dtDataCompra.TabIndex = 48;
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Location = new System.Drawing.Point(121, 36);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(152, 20);
            this.txtNFiscal.TabIndex = 47;
            // 
            // txtVenCod
            // 
            this.txtVenCod.Enabled = false;
            this.txtVenCod.Location = new System.Drawing.Point(32, 36);
            this.txtVenCod.Name = "txtVenCod";
            this.txtVenCod.Size = new System.Drawing.Size(83, 20);
            this.txtVenCod.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(271, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Data Inicio do pagamento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(110, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Tipo de Pagamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Nº de parcelas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Itens da Compra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Valor Unitário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Quantidade";
            // 
            // lbNomePro
            // 
            this.lbNomePro.AutoSize = true;
            this.lbNomePro.Location = new System.Drawing.Point(135, 135);
            this.lbNomePro.Name = "lbNomePro";
            this.lbNomePro.Size = new System.Drawing.Size(244, 13);
            this.lbNomePro.TabIndex = 39;
            this.lbNomePro.Text = "Informe o código do produto ou clique em localizar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Código do Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(703, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // lbNomeCli
            // 
            this.lbNomeCli.AutoSize = true;
            this.lbNomeCli.Location = new System.Drawing.Point(226, 93);
            this.lbNomeCli.Name = "lbNomeCli";
            this.lbNomeCli.Size = new System.Drawing.Size(239, 13);
            this.lbNomeCli.TabIndex = 36;
            this.lbNomeCli.Text = "Informe o código do cliente ou clique em localizar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Código do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data da Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Número da nota Fiscal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código";
            // 
            // cbxAvista
            // 
            this.cbxAvista.AutoSize = true;
            this.cbxAvista.Location = new System.Drawing.Point(417, 388);
            this.cbxAvista.Name = "cbxAvista";
            this.cbxAvista.Size = new System.Drawing.Size(91, 17);
            this.cbxAvista.TabIndex = 64;
            this.cbxAvista.Text = "Venda a vista";
            this.cbxAvista.UseVisualStyleBackColor = true;
            this.cbxAvista.CheckedChanged += new System.EventHandler(this.cbxAvista_CheckedChanged);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(102, 250);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(572, 63);
            this.lbMsg.TabIndex = 65;
            this.lbMsg.Text = "VENDA CANCELADA";
            this.lbMsg.Visible = false;
            // 
            // cbValidaQtde
            // 
            this.cbValidaQtde.AutoSize = true;
            this.cbValidaQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValidaQtde.Location = new System.Drawing.Point(389, 178);
            this.cbValidaQtde.Name = "cbValidaQtde";
            this.cbValidaQtde.Size = new System.Drawing.Size(123, 17);
            this.cbValidaQtde.TabIndex = 66;
            this.cbValidaQtde.Text = "Verificar Estoque";
            this.cbValidaQtde.UseVisualStyleBackColor = true;
            // 
            // frmMovimentacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1370, 562);
            this.Controls.Add(this.pnFinalizaVenda);
            this.Name = "frmMovimentacaoVenda";
            this.Text = " Movimentação de Venda";
            this.Load += new System.EventHandler(this.frmMovimentacaoVenda_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pnFinalizaVenda, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.pnFinalizaVenda.ResumeLayout(false);
            this.pnFinalizaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFinalizaVenda;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        protected System.Windows.Forms.Button btCancelaParcelas;
        protected System.Windows.Forms.Button btSalvarParcelas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.DateTimePicker dtIniPgto;
        private System.Windows.Forms.ComboBox cbTPagto;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvTotal;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btlProduto;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Button btLocCli;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.DateTimePicker dtDataCompra;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.TextBox txtVenCod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbNomePro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNomeCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxAvista;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.CheckBox cbValidaQtde;
    }
}
