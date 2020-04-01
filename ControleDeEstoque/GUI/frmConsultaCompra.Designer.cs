namespace GUI
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
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.rbDataCompra = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btLocFornecedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.pFornecedor = new System.Windows.Forms.Panel();
            this.lbForNome = new System.Windows.Forms.Label();
            this.pData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.btLocData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpCompra = new System.Windows.Forms.TabPage();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tpParcelas = new System.Windows.Forms.TabPage();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pFornecedor.SuspendLayout();
            this.pData.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpCompra.SuspendLayout();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.rbGeral);
            this.gbFiltro.Controls.Add(this.rbParcelas);
            this.gbFiltro.Controls.Add(this.rbDataCompra);
            this.gbFiltro.Controls.Add(this.rbFornecedor);
            this.gbFiltro.Location = new System.Drawing.Point(14, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(757, 55);
            this.gbFiltro.TabIndex = 13;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(20, 19);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(112, 17);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as compras";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Location = new System.Drawing.Point(635, 19);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(116, 17);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas em aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbDataCompra
            // 
            this.rbDataCompra.AutoSize = true;
            this.rbDataCompra.Location = new System.Drawing.Point(443, 19);
            this.rbDataCompra.Name = "rbDataCompra";
            this.rbDataCompra.Size = new System.Drawing.Size(102, 17);
            this.rbDataCompra.TabIndex = 1;
            this.rbDataCompra.Text = "Data da Compra";
            this.rbDataCompra.UseVisualStyleBackColor = true;
            this.rbDataCompra.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Location = new System.Drawing.Point(249, 19);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(76, 17);
            this.rbFornecedor.TabIndex = 0;
            this.rbFornecedor.Text = "Fonecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(740, 363);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // btLocFornecedor
            // 
            this.btLocFornecedor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocFornecedor.Location = new System.Drawing.Point(135, 8);
            this.btLocFornecedor.Name = "btLocFornecedor";
            this.btLocFornecedor.Size = new System.Drawing.Size(105, 33);
            this.btLocFornecedor.TabIndex = 11;
            this.btLocFornecedor.Text = "Localizar";
            this.btLocFornecedor.UseVisualStyleBackColor = true;
            this.btLocFornecedor.Click += new System.EventHandler(this.btLocFornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código do Fornecedor";
            // 
            // txtForCod
            // 
            this.txtForCod.Enabled = false;
            this.txtForCod.Location = new System.Drawing.Point(17, 21);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(116, 20);
            this.txtForCod.TabIndex = 10;
            // 
            // pFornecedor
            // 
            this.pFornecedor.Controls.Add(this.lbForNome);
            this.pFornecedor.Controls.Add(this.btLocFornecedor);
            this.pFornecedor.Controls.Add(this.txtForCod);
            this.pFornecedor.Controls.Add(this.label1);
            this.pFornecedor.Location = new System.Drawing.Point(14, 73);
            this.pFornecedor.Name = "pFornecedor";
            this.pFornecedor.Size = new System.Drawing.Size(757, 72);
            this.pFornecedor.TabIndex = 14;
            this.pFornecedor.Visible = false;
            // 
            // lbForNome
            // 
            this.lbForNome.AutoSize = true;
            this.lbForNome.Location = new System.Drawing.Point(17, 44);
            this.lbForNome.Name = "lbForNome";
            this.lbForNome.Size = new System.Drawing.Size(110, 13);
            this.lbForNome.TabIndex = 12;
            this.lbForNome.Text = "Nome do Fornecedor:";
            // 
            // pData
            // 
            this.pData.Controls.Add(this.label2);
            this.pData.Controls.Add(this.dtpFim);
            this.pData.Controls.Add(this.dtpIni);
            this.pData.Controls.Add(this.btLocData);
            this.pData.Controls.Add(this.label3);
            this.pData.Location = new System.Drawing.Point(14, 76);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(757, 69);
            this.pData.TabIndex = 15;
            this.pData.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data Final";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(142, 27);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(96, 20);
            this.dtpFim.TabIndex = 13;
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(20, 27);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(99, 20);
            this.dtpIni.TabIndex = 12;
            // 
            // btLocData
            // 
            this.btLocData.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocData.Location = new System.Drawing.Point(250, 18);
            this.btLocData.Name = "btLocData";
            this.btLocData.Size = new System.Drawing.Size(105, 33);
            this.btLocData.TabIndex = 11;
            this.btLocData.Text = "Localizar";
            this.btLocData.UseVisualStyleBackColor = true;
            this.btLocData.Click += new System.EventHandler(this.btLocData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Inicial";
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpCompra);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tpParcelas);
            this.tbcDados.Location = new System.Drawing.Point(14, 151);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(757, 398);
            this.tbcDados.TabIndex = 16;
            // 
            // tpCompra
            // 
            this.tpCompra.Controls.Add(this.dgvDados);
            this.tpCompra.Location = new System.Drawing.Point(4, 22);
            this.tpCompra.Name = "tpCompra";
            this.tpCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompra.Size = new System.Drawing.Size(749, 372);
            this.tpCompra.TabIndex = 0;
            this.tpCompra.Text = "Compras";
            this.tpCompra.UseVisualStyleBackColor = true;
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 22);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tpItens.Size = new System.Drawing.Size(749, 372);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens da Compra";
            this.tpItens.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(4, 5);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(740, 363);
            this.dgvItens.TabIndex = 13;
            // 
            // tpParcelas
            // 
            this.tpParcelas.Controls.Add(this.dgvParcelas);
            this.tpParcelas.Location = new System.Drawing.Point(4, 22);
            this.tpParcelas.Name = "tpParcelas";
            this.tpParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tpParcelas.Size = new System.Drawing.Size(749, 372);
            this.tpParcelas.TabIndex = 2;
            this.tpParcelas.Text = "Parcelas da Compra Selecionada";
            this.tpParcelas.UseVisualStyleBackColor = true;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(4, 5);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(740, 363);
            this.dgvParcelas.TabIndex = 13;
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.pFornecedor);
            this.Controls.Add(this.pData);
            this.Name = "frmConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Compras";
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pFornecedor.ResumeLayout(false);
            this.pFornecedor.PerformLayout();
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            this.tbcDados.ResumeLayout(false);
            this.tpCompra.ResumeLayout(false);
            this.tpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.RadioButton rbDataCompra;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.Button btLocFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Panel pFornecedor;
        private System.Windows.Forms.Label lbForNome;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Button btLocData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpCompra;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.TabPage tpParcelas;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridView dgvParcelas;
    }
}