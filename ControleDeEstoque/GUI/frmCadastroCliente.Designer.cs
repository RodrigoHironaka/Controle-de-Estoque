namespace GUI
{
    partial class frmCadastroCliente
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lbCpfcnpj = new System.Windows.Forms.Label();
            this.txtCpfcnpj = new System.Windows.Forms.TextBox();
            this.lbrgie = new System.Windows.Forms.Label();
            this.txtRgie = new System.Windows.Forms.TextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbRua = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbEndnumero = new System.Windows.Forms.Label();
            this.txtEndnumero = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbFone = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.lbCel = new System.Windows.Forms.Label();
            this.lbValorInvalido = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lbValorInvalido);
            this.pnDados.Controls.Add(this.lbCel);
            this.pnDados.Controls.Add(this.txtCel);
            this.pnDados.Controls.Add(this.txtFone);
            this.pnDados.Controls.Add(this.lbFone);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.lbEmail);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.lbBairro);
            this.pnDados.Controls.Add(this.txtEndnumero);
            this.pnDados.Controls.Add(this.lbEndnumero);
            this.pnDados.Controls.Add(this.txtEndereco);
            this.pnDados.Controls.Add(this.lbRua);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.lbCidade);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.lbEstado);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.lbCep);
            this.pnDados.Controls.Add(this.txtRgie);
            this.pnDados.Controls.Add(this.lbrgie);
            this.pnDados.Controls.Add(this.txtCpfcnpj);
            this.pnDados.Controls.Add(this.lbCpfcnpj);
            this.pnDados.Controls.Add(this.txtRSocial);
            this.pnDados.Controls.Add(this.lbRSocial);
            this.pnDados.Controls.Add(this.gbTipo);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.txtCodigo);
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
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(7, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(4, 58);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(728, 20);
            this.txtNome.TabIndex = 3;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbJuridica);
            this.gbTipo.Controls.Add(this.rbFisica);
            this.gbTipo.Location = new System.Drawing.Point(151, 13);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(188, 55);
            this.gbTipo.TabIndex = 4;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo do Cliente";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(97, 19);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(61, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(7, 19);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.Location = new System.Drawing.Point(4, 102);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(70, 13);
            this.lbRSocial.TabIndex = 5;
            this.lbRSocial.Text = "Razão Social";
            this.lbRSocial.Visible = false;
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(7, 118);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(728, 20);
            this.txtRSocial.TabIndex = 6;
            this.txtRSocial.Visible = false;
            // 
            // lbCpfcnpj
            // 
            this.lbCpfcnpj.AutoSize = true;
            this.lbCpfcnpj.Location = new System.Drawing.Point(4, 145);
            this.lbCpfcnpj.Name = "lbCpfcnpj";
            this.lbCpfcnpj.Size = new System.Drawing.Size(27, 13);
            this.lbCpfcnpj.TabIndex = 7;
            this.lbCpfcnpj.Text = "CPF";
            // 
            // txtCpfcnpj
            // 
            this.txtCpfcnpj.Location = new System.Drawing.Point(7, 161);
            this.txtCpfcnpj.Name = "txtCpfcnpj";
            this.txtCpfcnpj.Size = new System.Drawing.Size(164, 20);
            this.txtCpfcnpj.TabIndex = 8;
            this.txtCpfcnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfcnpj_KeyPress);
            this.txtCpfcnpj.Leave += new System.EventHandler(this.txtCpfcnpj_Leave);
            // 
            // lbrgie
            // 
            this.lbrgie.AutoSize = true;
            this.lbrgie.Location = new System.Drawing.Point(189, 145);
            this.lbrgie.Name = "lbrgie";
            this.lbrgie.Size = new System.Drawing.Size(23, 13);
            this.lbrgie.TabIndex = 9;
            this.lbrgie.Text = "RG";
            // 
            // txtRgie
            // 
            this.txtRgie.Location = new System.Drawing.Point(192, 161);
            this.txtRgie.Name = "txtRgie";
            this.txtRgie.Size = new System.Drawing.Size(189, 20);
            this.txtRgie.TabIndex = 10;
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(396, 144);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(28, 13);
            this.lbCep.TabIndex = 11;
            this.lbCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(399, 161);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(139, 20);
            this.txtCep.TabIndex = 12;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(396, 194);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 13;
            this.lbEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(399, 210);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(194, 20);
            this.txtEstado.TabIndex = 14;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(4, 194);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 15;
            this.lbCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(7, 210);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(376, 20);
            this.txtCidade.TabIndex = 16;
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(7, 234);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 17;
            this.lbRua.Text = "Rua";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(7, 251);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(602, 20);
            this.txtEndereco.TabIndex = 18;
            // 
            // lbEndnumero
            // 
            this.lbEndnumero.AutoSize = true;
            this.lbEndnumero.Location = new System.Drawing.Point(612, 234);
            this.lbEndnumero.Name = "lbEndnumero";
            this.lbEndnumero.Size = new System.Drawing.Size(44, 13);
            this.lbEndnumero.TabIndex = 19;
            this.lbEndnumero.Text = "Numero";
            // 
            // txtEndnumero
            // 
            this.txtEndnumero.Location = new System.Drawing.Point(615, 251);
            this.txtEndnumero.Name = "txtEndnumero";
            this.txtEndnumero.Size = new System.Drawing.Size(120, 20);
            this.txtEndnumero.TabIndex = 20;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(4, 282);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 21;
            this.lbBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(7, 299);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(226, 20);
            this.txtBairro.TabIndex = 22;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(245, 283);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(248, 299);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(487, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // lbFone
            // 
            this.lbFone.AutoSize = true;
            this.lbFone.Location = new System.Drawing.Point(4, 326);
            this.lbFone.Name = "lbFone";
            this.lbFone.Size = new System.Drawing.Size(49, 13);
            this.lbFone.TabIndex = 25;
            this.lbFone.Text = "Telefone";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(7, 343);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(199, 20);
            this.txtFone.TabIndex = 26;
            this.txtFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFone_KeyPress);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(248, 343);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(223, 20);
            this.txtCel.TabIndex = 27;
            // 
            // lbCel
            // 
            this.lbCel.AutoSize = true;
            this.lbCel.Location = new System.Drawing.Point(248, 325);
            this.lbCel.Name = "lbCel";
            this.lbCel.Size = new System.Drawing.Size(39, 13);
            this.lbCel.TabIndex = 28;
            this.lbCel.Text = "Celular";
            // 
            // lbValorInvalido
            // 
            this.lbValorInvalido.AutoSize = true;
            this.lbValorInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorInvalido.ForeColor = System.Drawing.Color.Red;
            this.lbValorInvalido.Location = new System.Drawing.Point(86, 145);
            this.lbValorInvalido.Name = "lbValorInvalido";
            this.lbValorInvalido.Size = new System.Drawing.Size(85, 13);
            this.lbValorInvalido.TabIndex = 29;
            this.lbValorInvalido.Text = "Valor Inválido";
            this.lbValorInvalido.Visible = false;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRgie;
        private System.Windows.Forms.Label lbrgie;
        private System.Windows.Forms.TextBox txtCpfcnpj;
        private System.Windows.Forms.Label lbCpfcnpj;
        private System.Windows.Forms.Label lbCel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label lbFone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox txtEndnumero;
        private System.Windows.Forms.Label lbEndnumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbValorInvalido;
    }
}
