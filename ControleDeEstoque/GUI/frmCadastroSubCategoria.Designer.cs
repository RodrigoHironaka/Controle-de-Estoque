namespace GUI
{
    partial class frmCadastroSubCategoria
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
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbCatCod = new System.Windows.Forms.Label();
            this.txtScatCod = new System.Windows.Forms.TextBox();
            this.txtScatNome = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btAdd);
            this.pnDados.Controls.Add(this.txtScatNome);
            this.pnDados.Controls.Add(this.txtScatCod);
            this.pnDados.Controls.Add(this.cbCatCod);
            this.pnDados.Controls.Add(this.cbCat);
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
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da SubCategoria";
            // 
            // cbCat
            // 
            this.cbCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(30, 145);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(358, 21);
            this.cbCat.TabIndex = 2;
            // 
            // cbCatCod
            // 
            this.cbCatCod.AutoSize = true;
            this.cbCatCod.Location = new System.Drawing.Point(27, 129);
            this.cbCatCod.Name = "cbCatCod";
            this.cbCatCod.Size = new System.Drawing.Size(98, 13);
            this.cbCatCod.TabIndex = 3;
            this.cbCatCod.Text = "Nome da Categoria";
            // 
            // txtScatCod
            // 
            this.txtScatCod.Enabled = false;
            this.txtScatCod.Location = new System.Drawing.Point(27, 31);
            this.txtScatCod.Name = "txtScatCod";
            this.txtScatCod.Size = new System.Drawing.Size(100, 20);
            this.txtScatCod.TabIndex = 4;
            // 
            // txtScatNome
            // 
            this.txtScatNome.Location = new System.Drawing.Point(30, 92);
            this.txtScatNome.Name = "txtScatNome";
            this.txtScatNome.Size = new System.Drawing.Size(690, 20);
            this.txtScatNome.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(408, 142);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(37, 24);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmCadastroSubCategoria";
            this.Text = "Cadastro de SubCategoria";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtScatNome;
        private System.Windows.Forms.TextBox txtScatCod;
        private System.Windows.Forms.Label cbCatCod;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
    }
}
