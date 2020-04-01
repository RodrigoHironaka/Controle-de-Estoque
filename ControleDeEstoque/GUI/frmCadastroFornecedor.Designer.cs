namespace GUI
{
    partial class frmCadastroFornecedor
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
            this.lbValorInvalido = new System.Windows.Forms.Label();
            this.lbCel = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.lbFone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtEndnumero = new System.Windows.Forms.TextBox();
            this.lbEndnumero = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbRua = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.lbIe = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
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
            this.pnDados.Controls.Add(this.txtIe);
            this.pnDados.Controls.Add(this.lbIe);
            this.pnDados.Controls.Add(this.txtCnpj);
            this.pnDados.Controls.Add(this.lbCnpj);
            this.pnDados.Controls.Add(this.txtRSocial);
            this.pnDados.Controls.Add(this.lbRSocial);
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
            // lbValorInvalido
            // 
            this.lbValorInvalido.AutoSize = true;
            this.lbValorInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorInvalido.ForeColor = System.Drawing.Color.Red;
            this.lbValorInvalido.Location = new System.Drawing.Point(92, 144);
            this.lbValorInvalido.Name = "lbValorInvalido";
            this.lbValorInvalido.Size = new System.Drawing.Size(85, 13);
            this.lbValorInvalido.TabIndex = 58;
            this.lbValorInvalido.Text = "Valor Inválido";
            this.lbValorInvalido.Visible = false;
            // 
            // lbCel
            // 
            this.lbCel.AutoSize = true;
            this.lbCel.Location = new System.Drawing.Point(254, 324);
            this.lbCel.Name = "lbCel";
            this.lbCel.Size = new System.Drawing.Size(39, 13);
            this.lbCel.TabIndex = 57;
            this.lbCel.Text = "Celular";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(254, 342);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(223, 20);
            this.txtCel.TabIndex = 56;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(13, 342);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(199, 20);
            this.txtFone.TabIndex = 55;
            this.txtFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFone_KeyPress);
            // 
            // lbFone
            // 
            this.lbFone.AutoSize = true;
            this.lbFone.Location = new System.Drawing.Point(10, 325);
            this.lbFone.Name = "lbFone";
            this.lbFone.Size = new System.Drawing.Size(49, 13);
            this.lbFone.TabIndex = 54;
            this.lbFone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(254, 298);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(487, 20);
            this.txtEmail.TabIndex = 53;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(251, 282);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 52;
            this.lbEmail.Text = "Email";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(13, 298);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(226, 20);
            this.txtBairro.TabIndex = 51;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(10, 281);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 50;
            this.lbBairro.Text = "Bairro";
            // 
            // txtEndnumero
            // 
            this.txtEndnumero.Location = new System.Drawing.Point(621, 250);
            this.txtEndnumero.Name = "txtEndnumero";
            this.txtEndnumero.Size = new System.Drawing.Size(120, 20);
            this.txtEndnumero.TabIndex = 49;
            // 
            // lbEndnumero
            // 
            this.lbEndnumero.AutoSize = true;
            this.lbEndnumero.Location = new System.Drawing.Point(618, 233);
            this.lbEndnumero.Name = "lbEndnumero";
            this.lbEndnumero.Size = new System.Drawing.Size(44, 13);
            this.lbEndnumero.TabIndex = 48;
            this.lbEndnumero.Text = "Numero";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(13, 250);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(602, 20);
            this.txtEndereco.TabIndex = 47;
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(13, 233);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 46;
            this.lbRua.Text = "Rua";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(13, 209);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(376, 20);
            this.txtCidade.TabIndex = 45;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(10, 193);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 44;
            this.lbCidade.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(405, 209);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(194, 20);
            this.txtEstado.TabIndex = 43;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(402, 193);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 42;
            this.lbEstado.Text = "Estado";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(405, 160);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(139, 20);
            this.txtCep.TabIndex = 41;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(402, 143);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(28, 13);
            this.lbCep.TabIndex = 40;
            this.lbCep.Text = "CEP";
            // 
            // txtIe
            // 
            this.txtIe.Location = new System.Drawing.Point(198, 160);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(189, 20);
            this.txtIe.TabIndex = 39;
            // 
            // lbIe
            // 
            this.lbIe.AutoSize = true;
            this.lbIe.Location = new System.Drawing.Point(195, 144);
            this.lbIe.Name = "lbIe";
            this.lbIe.Size = new System.Drawing.Size(17, 13);
            this.lbIe.TabIndex = 38;
            this.lbIe.Text = "IE";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(13, 160);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(164, 20);
            this.txtCnpj.TabIndex = 37;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Location = new System.Drawing.Point(10, 144);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(34, 13);
            this.lbCnpj.TabIndex = 36;
            this.lbCnpj.Text = "CNPJ";
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(13, 117);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(728, 20);
            this.txtRSocial.TabIndex = 35;
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.Location = new System.Drawing.Point(10, 101);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(70, 13);
            this.lbRSocial.TabIndex = 34;
            this.lbRSocial.Text = "Razão Social";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(728, 20);
            this.txtNome.TabIndex = 33;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(10, 57);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 32;
            this.lbNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(13, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código";
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedores";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbValorInvalido;
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
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.Label lbIe;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}
