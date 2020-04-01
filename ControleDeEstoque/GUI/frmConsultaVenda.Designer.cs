namespace GUI
{
    partial class frmConsultaVenda
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
            this.rbDataVenda = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.pCliente = new System.Windows.Forms.Panel();
            this.lbCliNome = new System.Windows.Forms.Label();
            this.btLocCliente = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpVenda = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tpParcelas = new System.Windows.Forms.TabPage();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pData = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.btLocData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFiltro.SuspendLayout();
            this.pCliente.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.pData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.rbGeral);
            this.gbFiltro.Controls.Add(this.rbParcelas);
            this.gbFiltro.Controls.Add(this.rbDataVenda);
            this.gbFiltro.Controls.Add(this.rbCliente);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(757, 55);
            this.gbFiltro.TabIndex = 14;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(20, 19);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(107, 17);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as vendas";
            this.rbGeral.UseVisualStyleBackColor = true;
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
            // rbDataVenda
            // 
            this.rbDataVenda.AutoSize = true;
            this.rbDataVenda.Location = new System.Drawing.Point(443, 19);
            this.rbDataVenda.Name = "rbDataVenda";
            this.rbDataVenda.Size = new System.Drawing.Size(97, 17);
            this.rbDataVenda.TabIndex = 1;
            this.rbDataVenda.Text = "Data da Venda";
            this.rbDataVenda.UseVisualStyleBackColor = true;
            this.rbDataVenda.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(249, 19);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // pCliente
            // 
            this.pCliente.Controls.Add(this.lbCliNome);
            this.pCliente.Controls.Add(this.btLocCliente);
            this.pCliente.Controls.Add(this.txtCliCod);
            this.pCliente.Controls.Add(this.label1);
            this.pCliente.Location = new System.Drawing.Point(15, 73);
            this.pCliente.Name = "pCliente";
            this.pCliente.Size = new System.Drawing.Size(757, 72);
            this.pCliente.TabIndex = 15;
            this.pCliente.Visible = false;
            // 
            // lbCliNome
            // 
            this.lbCliNome.AutoSize = true;
            this.lbCliNome.Location = new System.Drawing.Point(17, 44);
            this.lbCliNome.Name = "lbCliNome";
            this.lbCliNome.Size = new System.Drawing.Size(88, 13);
            this.lbCliNome.TabIndex = 12;
            this.lbCliNome.Text = "Nome do Cliente:";
            // 
            // btLocCliente
            // 
            this.btLocCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocCliente.Location = new System.Drawing.Point(135, 8);
            this.btLocCliente.Name = "btLocCliente";
            this.btLocCliente.Size = new System.Drawing.Size(105, 33);
            this.btLocCliente.TabIndex = 11;
            this.btLocCliente.Text = "Localizar";
            this.btLocCliente.UseVisualStyleBackColor = true;
            this.btLocCliente.Click += new System.EventHandler(this.btLocCliente_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Enabled = false;
            this.txtCliCod.Location = new System.Drawing.Point(17, 21);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(116, 20);
            this.txtCliCod.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código do Cliente";
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpVenda);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tpParcelas);
            this.tbcDados.Location = new System.Drawing.Point(15, 151);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(757, 398);
            this.tbcDados.TabIndex = 17;
            // 
            // tpVenda
            // 
            this.tpVenda.Controls.Add(this.dgvDados);
            this.tpVenda.Location = new System.Drawing.Point(4, 22);
            this.tpVenda.Name = "tpVenda";
            this.tpVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tpVenda.Size = new System.Drawing.Size(749, 372);
            this.tpVenda.TabIndex = 0;
            this.tpVenda.Text = "Vendas";
            this.tpVenda.UseVisualStyleBackColor = true;
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
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick_1);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick_1);
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 22);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tpItens.Size = new System.Drawing.Size(749, 372);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens da Venda";
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
            this.tpParcelas.Text = "Parcelas da Venda Selecionada";
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
            // pData
            // 
            this.pData.Controls.Add(this.label3);
            this.pData.Controls.Add(this.dtpFim);
            this.pData.Controls.Add(this.dtpIni);
            this.pData.Controls.Add(this.btLocData);
            this.pData.Controls.Add(this.label4);
            this.pData.Location = new System.Drawing.Point(12, 73);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(756, 69);
            this.pData.TabIndex = 19;
            this.pData.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data Final";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Inicial";
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pCliente);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.gbFiltro);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.pCliente.ResumeLayout(false);
            this.pCliente.PerformLayout();
            this.tbcDados.ResumeLayout(false);
            this.tpVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.RadioButton rbDataVenda;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Panel pCliente;
        private System.Windows.Forms.Label lbCliNome;
        private System.Windows.Forms.Button btLocCliente;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpVenda;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TabPage tpParcelas;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Button btLocData;
        private System.Windows.Forms.Label label4;
    }
}