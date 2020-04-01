using BLL;
using DAL;
using Ferramentas;
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
    public partial class frmCadastroFornecedor : GUI.frmModeloDeFormularioDeCadastro
    {
        //--------------------------------------------------------------------------------
        public enum CampoT
        {
            Telefone = 1,
        }

        public void FormatarTelefone(CampoT Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case CampoT.Telefone:
                    txtTexto.MaxLength = 13;
                    if (txtTexto.Text.Length == 0)
                    {
                        txtTexto.Text = txtTexto.Text + "(";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ")";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 8)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }

        //--------------------------------------------------------------------------------
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
        }
        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                case Campo.CEP:
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }
        //------------------------------------------------------------------------------------------------
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCnpj.Clear();
            txtIe.Clear();
            txtRSocial.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtFone.Clear();
            txtCel.Clear();
            txtEmail.Clear();
            txtEndnumero.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            lbValorInvalido.Visible = false;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtCodigo.Text = modelo.ForCod.ToString();
                txtNome.Text = modelo.ForNome;
                txtCnpj.Text = modelo.ForCnpj;
                txtIe.Text = modelo.ForIe;
                txtRSocial.Text = modelo.ForRSocial;
                txtCep.Text = modelo.ForCep;
                txtEndereco.Text = modelo.ForEndereco;
                txtBairro.Text = modelo.ForBairro;
                txtFone.Text = modelo.ForFone;
                txtCel.Text = modelo.ForCelular;
                txtEmail.Text = modelo.ForEmail;
                txtEndnumero.Text = modelo.ForEndNumero;
                txtCidade.Text = modelo.ForCidade;
                txtEstado.Text = modelo.ForEstado;

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o Registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txtNome.Text;
                modelo.ForRSocial = txtRSocial.Text;
                modelo.ForCnpj = txtCnpj.Text;
                modelo.ForIe = txtIe.Text;
                modelo.ForCep = txtCep.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForEstado = txtEstado.Text;
                modelo.ForEndereco = txtEndereco.Text;
                modelo.ForEndNumero = txtEndnumero.Text;
                modelo.ForBairro = txtBairro.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForFone = txtFone.Text;
                modelo.ForCelular = txtCel.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ForCod.ToString());
                }
                else
                {
                    modelo.ForCod = Convert.ToInt32(txtCodigo.Text);
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            lbValorInvalido.Visible = false;
            if (Validacao.IsCnpj(txtCnpj.Text) == false)
            {
                lbValorInvalido.Visible = true;
            }
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CNPJ;
                Formatar(edit, txtCnpj);
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (Validacao.ValidaCep(txtCep.Text) == false)
            {
                MessageBox.Show("O CEP é inválido");
                txtBairro.Clear();
                txtEstado.Clear();
                txtCidade.Clear();
                txtEndereco.Clear();
                txtCep.Clear();
            }
            else
            {
                if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
                {
                    txtBairro.Text = BuscaEndereco.bairro;
                    txtEstado.Text = BuscaEndereco.estado;
                    txtCidade.Text = BuscaEndereco.cidade;
                    txtEndereco.Text = BuscaEndereco.endereco;
                }
                else
                {
                    //limpa os campos do endereço
                }
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CEP;
                Formatar(edit, txtCep);
            }
        }

        private void txtFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)//compara se é numero e habilita o backspace//8 valor da backspace na tabela ask
                e.Handled = true;//volta verdadeiro e não faz nada ou seja não é numero
            if (e.KeyChar != (char)8)
            {
                CampoT edit = CampoT.Telefone;
                edit = CampoT.Telefone;
                FormatarTelefone(edit, txtFone);
            }
        }
    }
}
