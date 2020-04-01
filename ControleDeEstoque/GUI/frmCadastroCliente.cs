using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ferramentas;
using Modelo;

namespace GUI
{

    public partial class frmCadastroCliente : GUI.frmModeloDeFormularioDeCadastro
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
            CEP =3,
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
        //--------------------------------------------------------------------------------
        public frmCadastroCliente()
        {
            InitializeComponent();
        }
      
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCpfcnpj.Clear();
            txtRgie.Clear();
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
            rbFisica.Checked = true;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
           
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();
                txtNome.Text = modelo.CliNome;
                txtCpfcnpj.Text = modelo.CliCpfCnpj;
                txtRgie.Text = modelo.CliRgIe;
                txtRSocial.Text = modelo.CliRSocial;
                if (modelo.CliTipo == "Física")
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbJuridica.Checked = true;
                }
                txtCep.Text = modelo.CliCep;
                txtEndereco.Text = modelo.CliEndereco;
                txtBairro.Text = modelo.CliBairro;
                txtFone.Text = modelo.CliFone;
                txtCel.Text = modelo.CliCelular;
                txtEmail.Text = modelo.CliEmail;
                txtEndnumero.Text = modelo.CliEndNumero;
                txtCidade.Text = modelo.CliCidade;
                txtEstado.Text = modelo.CliEstado;

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
                    BLLCliente bll = new BLLCliente(cx);
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliRSocial = txtRSocial.Text;
                modelo.CliCpfCnpj = txtCpfcnpj.Text;
                modelo.CliRgIe = txtRgie.Text;
                modelo.CliCep = txtCep.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliEndereco = txtEndereco.Text;
                modelo.CliEndNumero = txtEndnumero.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliFone = txtFone.Text;
                modelo.CliCelular = txtCel.Text;
                if(rbFisica.Checked == true)
                {
                    modelo.CliTipo = "Física"; //Fisica
                    modelo.CliRSocial = "";
                }
                else
                {
                    modelo.CliTipo = "Jurídica"; // Juridica
                }
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CliCod.ToString());
                }
                else
                {
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
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

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
            {
                lbRSocial.Visible = false;
                txtRSocial.Visible = false;
                lbCpfcnpj.Text = "CPF";
                lbrgie.Text = "RG";
            }
            else
            {
                lbRSocial.Visible = true;
                txtRSocial.Visible = true;
                lbCpfcnpj.Text = "CNPJ";
                lbrgie.Text = "IE";
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

        private void txtCpfcnpj_Leave(object sender, EventArgs e)
        {
            lbValorInvalido.Visible = false;
            if(rbFisica.Checked == true)
            {
                //cpf
                if (Validacao.IsCpf(txtCpfcnpj.Text) == false)
                {
                    lbValorInvalido.Visible = true;
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(txtCpfcnpj.Text) == false)
                {
                    lbValorInvalido.Visible = true;
                }
            }
        }

        private void txtCpfcnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CPF;
                if (rbFisica.Checked == false) edit = Campo.CNPJ;
                Formatar(edit, txtCpfcnpj);
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
