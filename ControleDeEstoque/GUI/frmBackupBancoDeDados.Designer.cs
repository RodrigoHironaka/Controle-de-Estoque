﻿namespace GUI
{
    partial class frmBackupBancoDeDados
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
            this.btBackup = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBackup
            // 
            this.btBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.Location = new System.Drawing.Point(27, 69);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(249, 82);
            this.btBackup.TabIndex = 0;
            this.btBackup.Text = "Backup Do Banco de Dados";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurar.Location = new System.Drawing.Point(291, 69);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(249, 82);
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.Text = "Restaurar Bando de dados";
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // frmBackupBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 231);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btBackup);
            this.Name = "frmBackupBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do Banco De Dados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btRestaurar;
    }
}