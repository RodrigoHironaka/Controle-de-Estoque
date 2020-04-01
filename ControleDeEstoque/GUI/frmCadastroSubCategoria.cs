using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroSubCategoria : GUI.frmModeloDeFormularioDeCadastro
    {
      

        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtScatNome.Clear();
            txtScatCod.Clear();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCat.DataSource = bll.Localizar("");
            cbCat.DisplayMember = "cat_nome";
            cbCat.ValueMember = "cat_cod";
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "alterar";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.SCatNome = txtScatNome.Text;
                modelo.CatCod = Convert.ToInt32(cbCat.SelectedValue);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.SCatCod.ToString());
                }
                else
                {
                    modelo.SCatCod = Convert.ToInt32(txtScatCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado! ");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o Registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtScatCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro esta sendo usado em outro local");
                this.alteraBotoes(3);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtScatCod.Text = modelo.SCatCod.ToString();
                txtScatNome.Text = modelo.SCatNome;
                cbCat.SelectedValue = modelo.CatCod;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCat.DataSource = bll.Localizar("");
            cbCat.DisplayMember = "cat_nome";
            cbCat.ValueMember = "cat_cod";
        }
    }
}
