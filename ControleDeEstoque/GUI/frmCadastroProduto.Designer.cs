namespace GUI
{
    partial class frmCadastroProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUnd = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btLoFoto = new System.Windows.Forms.Button();
            this.btRmFoto = new System.Windows.Forms.Button();
            this.brAddUn = new System.Windows.Forms.Button();
            this.btAddScat = new System.Windows.Forms.Button();
            this.btAddCat = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btAddCat);
            this.pnDados.Controls.Add(this.btAddScat);
            this.pnDados.Controls.Add(this.brAddUn);
            this.pnDados.Controls.Add(this.btRmFoto);
            this.pnDados.Controls.Add(this.btLoFoto);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.cbSubCategoria);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.cbUnd);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
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
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(19, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(19, 111);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(372, 102);
            this.txtDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor Pago";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(22, 304);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(150, 20);
            this.txtQtde.TabIndex = 5;
            this.txtQtde.Text = "0,00";
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(22, 246);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(150, 20);
            this.txtValorPago.TabIndex = 3;
            this.txtValorPago.Text = "0,00";
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor de Venda";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(227, 245);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(130, 20);
            this.txtValorVenda.TabIndex = 4;
            this.txtValorVenda.Text = "0,00";
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Unidade de Medida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "SubCategoria";
            // 
            // cbUnd
            // 
            this.cbUnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnd.FormattingEnabled = true;
            this.cbUnd.Location = new System.Drawing.Point(227, 304);
            this.cbUnd.Name = "cbUnd";
            this.cbUnd.Size = new System.Drawing.Size(130, 21);
            this.cbUnd.TabIndex = 6;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(22, 354);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(150, 21);
            this.cbCategoria.TabIndex = 7;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(227, 354);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(130, 21);
            this.cbSubCategoria.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(419, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 273);
            this.panel1.TabIndex = 18;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(323, 271);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Foto";
            // 
            // btLoFoto
            // 
            this.btLoFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoFoto.Image = global::GUI.Properties.Resources.carrega_imagem;
            this.btLoFoto.Location = new System.Drawing.Point(419, 304);
            this.btLoFoto.Name = "btLoFoto";
            this.btLoFoto.Size = new System.Drawing.Size(153, 79);
            this.btLoFoto.TabIndex = 9;
            this.btLoFoto.Text = "Carregar Foto";
            this.btLoFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLoFoto.UseVisualStyleBackColor = true;
            this.btLoFoto.Click += new System.EventHandler(this.btLoFoto_Click);
            // 
            // btRmFoto
            // 
            this.btRmFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRmFoto.Image = global::GUI.Properties.Resources.remove_imagem_48x48;
            this.btRmFoto.Location = new System.Drawing.Point(590, 304);
            this.btRmFoto.Name = "btRmFoto";
            this.btRmFoto.Size = new System.Drawing.Size(151, 79);
            this.btRmFoto.TabIndex = 10;
            this.btRmFoto.Text = "Remover Foto";
            this.btRmFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRmFoto.UseVisualStyleBackColor = true;
            this.btRmFoto.Click += new System.EventHandler(this.btRmFoto_Click);
            // 
            // brAddUn
            // 
            this.brAddUn.Location = new System.Drawing.Point(363, 302);
            this.brAddUn.Name = "brAddUn";
            this.brAddUn.Size = new System.Drawing.Size(27, 23);
            this.brAddUn.TabIndex = 20;
            this.brAddUn.Text = "+";
            this.brAddUn.UseVisualStyleBackColor = true;
            this.brAddUn.Click += new System.EventHandler(this.brAddUn_Click);
            // 
            // btAddScat
            // 
            this.btAddScat.Location = new System.Drawing.Point(363, 352);
            this.btAddScat.Name = "btAddScat";
            this.btAddScat.Size = new System.Drawing.Size(27, 23);
            this.btAddScat.TabIndex = 21;
            this.btAddScat.Text = "+";
            this.btAddScat.UseVisualStyleBackColor = true;
            this.btAddScat.Click += new System.EventHandler(this.btAddScat_Click);
            // 
            // btAddCat
            // 
            this.btAddCat.Location = new System.Drawing.Point(178, 352);
            this.btAddCat.Name = "btAddCat";
            this.btAddCat.Size = new System.Drawing.Size(27, 23);
            this.btAddCat.TabIndex = 22;
            this.btAddCat.Text = "+";
            this.btAddCat.UseVisualStyleBackColor = true;
            this.btAddCat.Click += new System.EventHandler(this.btAddCat_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRmFoto;
        private System.Windows.Forms.Button btLoFoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbUnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btAddCat;
        private System.Windows.Forms.Button btAddScat;
        private System.Windows.Forms.Button brAddUn;
    }
}
