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
    public partial class frmMovimentacaoCompra : GUI.frmModeloDeFormularioDeCadastro
    {
        public double totalCompra = 0;
        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodCom.Clear();
            txtNFiscal.Clear();
            txtForCod.Clear();
            lbNomeFor.Text = "Informe o código do fornecedor ou clique em localizar";
            txtProCod.Clear();
            lbNomePro.Text = "Informe o código do produto ou clique em localizar";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotal.Clear();
            dgvItens.Rows.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txtCodCom.Text = modelo.ComCod.ToString();
                txtNFiscal.Text = modelo.ComNFiscal.ToString();
                dtDataCompra.Value = modelo.ComData;
                txtForCod.Text = modelo.ForCod.ToString();
                txtForCod_Leave(sender, e);// para escrever o nome do fornecedor na tela
                txtTotal.Text = modelo.ComTotal.ToString();
                this.totalCompra = modelo.ComTotal; //armazena o valor total da compra
                cbTPagto.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.ComNParcelas.ToString();

                //itens da compra
                BLLItensCompra bllitens = new BLLItensCompra(cx);
                DataTable tabela = bllitens.Localizar(modelo.ComCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itc_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itc_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itc_valor"]);
                    String[] it = new String[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }

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
            int codigo = Convert.ToInt32(txtCodCom.Text);
            int qtde = Convert.ToInt32(cbNParcelas.Text);

            //conexao e bll da compra
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllc = new BLLCompra(cx);
            qtde -= bllc.QuantidadeParcelasNaoPagas(codigo);
            if (qtde == 0)//nao paguei nenhuma parcela
            {
                this.operacao = "alterar";
                this.alteraBotoes(2);
            }
            else
            {
                MessageBox.Show("Impossivel alterar o registro. \n O registro possui parcelas pagas");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o Registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    int codigo = Convert.ToInt32(txtCodCom.Text);
                    int qtde = Convert.ToInt32(cbNParcelas.Text);

                    //conexao e bll da compra
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bllc = new BLLCompra(cx);
                    qtde -= bllc.QuantidadeParcelasNaoPagas(codigo);
                    if (qtde == 0)//nao paguei nenhuma parcela
                    {
                        cx.Conectar();
                        cx.IniciarTransacao();
                        try
                        {
                            //excluir as parcelas da compra
                            BLLParcelaCompra bllp = new BLLParcelaCompra(cx);
                            bllp.ExcluirTodasAsParcelas(codigo);

                            //excluir os itens da compra
                            BLLItensCompra blli = new BLLItensCompra(cx);
                            blli.ExcluirTodosOsItens(codigo);

                            //excluir a compra
                            bllc.Excluir(codigo);
                            cx.TerminarTransacao();
                            cx.Desconectar();

                            this.LimpaTela();
                            this.alteraBotoes(1);

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                            cx.CancelaTransacao();
                            cx.Desconectar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossivel excluir o registro. \n O registro possui parcelas pagas");
                    }

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
            if (txtForCod.Text == "") //validacao de fornecedor na compra
            {
                MessageBox.Show("Informe o fornecedor dessa compra");
                return;
            }
            if (this.totalCompra <= 0) //validacao dos itens na compra
            {
                MessageBox.Show("Informe os produtos dessa compra");
                return;
            }
          

            dgvParcelas.Rows.Clear();
            int parcelas = Convert.ToInt32(cbNParcelas.Text);
            Double totalLocal = this.totalCompra;
            double valor = totalLocal / parcelas;
            DateTime dt = new DateTime();
            dt = dtIniPgto.Value;
            lbTotal.Text = totalLocal.ToString();
            for (int i = 1; i <= parcelas; i++)
            {
                String[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                this.dgvParcelas.Rows.Add(k);
                if (dt.Month != 12)
                {
                    dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year + 1, 1, dt.Day);
                }
                pnFinalizaCompra.Visible = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
            this.totalCompra = 0;
        }

        private void btlFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                txtForCod_Leave(sender, e);
            }
        }

        private void txtForCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));
                if (modelo.ForCod <= 0)
                {
                    txtForCod.Clear();
                    lbNomeFor.Text = "Informe o código do fornecedor ou clique em localizar";
                }
                else
                {
                    lbNomeFor.Text = modelo.ForNome;
                }
            }
            catch
            {
                txtForCod.Clear();
                lbNomeFor.Text = "Informe o código do fornecedor ou clique em localizar";
            }
        }

        private void btlProduto_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();
                txtProCod_Leave(sender, e);
            }
        }

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lbNomePro.Text = modelo.ProNome;
                txtQtde.Text = "1";
                txtValor.Text = modelo.ProValorPago.ToString();
            }
            catch
            {
                txtProCod.Clear();
                lbNomePro.Text = "Informe o código do produto ou clique em localizar";
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    Double totalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalCompra = this.totalCompra + totalLocal;
                    String[] i = new String[] { txtProCod.Text, lbNomePro.Text, txtQtde.Text, txtValor.Text, totalLocal.ToString() };
                    this.dgvItens.Rows.Add(i);

                    txtProCod.Clear();
                    lbNomePro.Text = "Informe o código do produto ou clique em localizar";
                    txtQtde.Clear();
                    txtValor.Clear();

                    txtTotal.Text = this.totalCompra.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes ao valor e quantidade do produto");
            }
        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            //combo Tipo de Pagamento
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTPagto.DataSource = bll.Localizar("");
            cbTPagto.DisplayMember = "tpa_nome";
            cbTPagto.ValueMember = "tpa_cod";
            cbNParcelas.SelectedIndex = 0;
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //exclui itend do datagridview e retorna os dados para os textBoxs, o valor total é armazenado em uma variavel apenas. 
            if (e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbNomePro.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotal.Text = this.totalCompra.ToString();

            }
        }

        private void btCancelaParcelas_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
        }

        private void btSalvarParcelas_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.ComData = dtDataCompra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloCompra.ComStatus = "ativo";
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCod.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTPagto.SelectedValue);

                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                ModeloParcelaCompra mparcelas = new ModeloParcelaCompra();
                BLLParcelaCompra bparcelas = new BLLParcelaCompra(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar compra
                    bll.Incluir(modeloCompra);

                    //cadastrar itens das compras
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToInt32(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //trigger para alterar estoque foi feito no sqlserver
                    }

                    //inserir os itens na tabela parcelascompra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    //cadastrar parcelas da compra
                    MessageBox.Show("Compra efetuada: Código " + modeloCompra.ComCod.ToString());
                }
                else
                {
                    //alterar 
                    modeloCompra.ComCod = Convert.ToInt32(txtCodCom.Text);
                    bll.Alterar(modeloCompra);

                    bitens.ExcluirTodosOsItens(modeloCompra.ComCod);
                    //cadastrar itens das compras
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }

                    bparcelas.ExcluirTodasAsParcelas(modeloCompra.ComCod);
                    //inserir os itens na tabela parcelascompra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    MessageBox.Show("Cadastro alterado! ");
                }
                this.LimpaTela();
                pnFinalizaCompra.Visible = false;
                this.alteraBotoes(1);
                cx.TerminarTransacao();
                cx.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelaTransacao();
                cx.Desconectar();
            }
        }

        private void txtNFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacao para permitir apenas numeros
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
