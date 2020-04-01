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
    public partial class frmMovimentacaoVenda : GUI.frmModeloDeFormularioDeCadastro
    {
        public double totalVenda = 0;
        public frmMovimentacaoVenda()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtVenCod.Clear();
            txtNFiscal.Clear();
            txtCliCod.Clear();
            lbNomeCli.Text = "Informe o código do cliente ou clique em localizar";
            txtProCod.Clear();
            lbNomePro.Text = "Informe o código do produto ou clique em localizar";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotalVenda.Text = "0,00";
            dgvItens.Rows.Clear();// limpa o datagrid
            cbNParcelas.SelectedIndex = 0;
            cbTPagto.SelectedIndex = 0;
            lbMsg.Visible = false;
        }

        private Double VerificaQtdeProdutos(int ProCod)
        {
            Double QtdEmEstoque = 0;
            try
            {
                //O que tem no banco de dados ( no caso a qtd em estoque)
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(ProCod);
                QtdEmEstoque = modelo.ProQtde; //aqui ja sabe quanto tem no banco

                //verifica produtos que ja estao no grid
                for(int i = 0; i < dgvItens.RowCount; i++) //percorrendo o grid
                { 
                    if(Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value) == ProCod)
                    {
                        //aqui a variavel qndo verifica no grid pega o valor do banco subtrai pelo valor da qtd q encontrou no grid
                        QtdEmEstoque = QtdEmEstoque - Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                    }
                }
            }
            catch { }
            return QtdEmEstoque;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalVenda = 0;
            this.alteraBotoes(2);
            cbNParcelas.SelectedIndex = 0;
            cbxAvista.Checked = false;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txtVenCod.Text = modelo.VenCod.ToString();
                txtNFiscal.Text = modelo.VenNfiscal.ToString();
                dtDataCompra.Value = modelo.VenData;
                txtCliCod.Text = modelo.CliCod.ToString();
                txtCliCod_Leave(sender, e);// para escrever o nome do cliente na tela
                txtTotalVenda.Text = modelo.VenTotal.ToString();
                this.totalVenda = modelo.VenTotal; //armazena o valor total da venda
                cbTPagto.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.VenNparcelas.ToString();
                cbxAvista.Checked = false;
                if (modelo.VenAvista == 1)
                {
                    cbxAvista.Checked = true;
                }

                //itens da venda
                BLLItensVenda bllitens = new BLLItensVenda(cx);
                DataTable tabela = bllitens.Localizar(modelo.VenCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itv_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itv_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itv_valor"]);
                    String[] it = new String[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }

                alteraBotoes(3);
                lbMsg.Visible = false;
                if (modelo.VenStatus != "ativo")
                {
                    lbMsg.Visible = true;
                    btExcluir.Enabled = false;
                }
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btLocCli_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                txtCliCod_Leave(sender, e);
            }
        }

        private void txtCliCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txtCliCod.Text));
                if (modelo.CliCod <= 0)
                {
                    txtCliCod.Clear();
                    lbNomeCli.Text = "Informe o código do cliente ou clique em localizar";
                }
                else
                {
                    lbNomeCli.Text = modelo.CliNome;
                }

            }
            catch
            {
                txtCliCod.Clear();
                lbNomeCli.Text = "Informe o código do cliente ou clique em localizar";
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
                txtValor.Text = modelo.ProValorVenda.ToString();
            }
            catch
            {
                txtProCod.Clear();
                lbNomePro.Text = "Informe o código do produto ou clique em localizar";
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Double Qtde = 0;
            try
            {
                if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    if(cbValidaQtde.Checked == true)
                    {
                        Qtde = VerificaQtdeProdutos(Convert.ToInt32(txtProCod.Text));
                        if(Convert.ToDouble(txtQtde.Text) > Qtde)
                        {
                            MessageBox.Show("Quantidade de produtos indisponivel. \n Vicê possui " + Qtde + " unidades em seu estoque");
                            return;
                        }
                    }
                    Double totalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalVenda = this.totalVenda + totalLocal;
                    String[] i = new String[] { txtProCod.Text, lbNomePro.Text, txtQtde.Text, txtValor.Text, totalLocal.ToString() };
                    this.dgvItens.Rows.Add(i);

                    txtProCod.Clear();
                    lbNomePro.Text = "Informe o código do produto ou clique em localizar";
                    txtQtde.Clear();
                    txtValor.Clear();

                    txtTotalVenda.Text = this.totalVenda.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes ao valor e quantidade do produto");
            }
        }

        private void frmMovimentacaoVenda_Load(object sender, EventArgs e)
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

        private void cbxAvista_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAvista.Checked == true)
            {
                cbNParcelas.SelectedIndex = 0;
                cbNParcelas.Enabled = false;
            }
            else
            {
                cbNParcelas.Enabled = true;
            }
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
                this.totalVenda = this.totalVenda - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalVenda.Text = this.totalVenda.ToString();

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtCliCod.Text) < 0)
                {
                    MessageBox.Show("Informe um código válido para o cliente");
                    return;
                }

                if (Convert.ToInt32(txtNFiscal.Text) < 0)
                {
                    MessageBox.Show("Informe um Número válido para a nota fiscal");
                    return;
                }

                //verificando se o valor total esta zerado
                if (Convert.ToInt32(txtTotalVenda.Text) < 0)
                {
                    MessageBox.Show("Sua venda não pode ser gerada com o valor total da venda = 0");
                    return;
                }

                dgvParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(cbNParcelas.Text);
                Double totalLocal = this.totalVenda;
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
                    pnFinalizaVenda.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Verifique os campos da tela de venda");
            }


        }

        private void btCancelaParcelas_Click(object sender, EventArgs e)
        {
            pnFinalizaVenda.Visible = false;
        }

        private void btSalvarParcelas_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                ModeloVenda modeloVenda = new ModeloVenda();
                modeloVenda.VenData = dtDataCompra.Value;
                modeloVenda.VenNfiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloVenda.VenNparcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloVenda.VenStatus = "ativo";
                modeloVenda.VenTotal = this.totalVenda;
                modeloVenda.CliCod = Convert.ToInt32(txtCliCod.Text);
                modeloVenda.TpaCod = Convert.ToInt32(cbTPagto.SelectedValue);
                if (cbxAvista.Checked == true)
                {
                    modeloVenda.VenAvista = 1;
                }
                else
                {
                    modeloVenda.VenAvista = 0;
                }

                BLLVenda bll = new BLLVenda(cx);

                ModeloItensVenda mitens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

                ModeloParcelaVenda mparcelas = new ModeloParcelaVenda();
                BLLParcelaVenda bparcelas = new BLLParcelaVenda(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar venda
                    bll.Incluir(modeloVenda);

                    //cadastrar itens da venda
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItvCod = i + 1;
                        mitens.VenCod = modeloVenda.VenCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItvQtde = Convert.ToInt32(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItvValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //trigger para alterar estoque foi feito no sqlserver
                    }

                    //inserir os itens na tabela parcelasvenda
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.VenCod = modeloVenda.VenCod;
                        mparcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    MessageBox.Show("Compra efetuada: Código " + modeloVenda.VenCod.ToString());
                }
                else
                {
                  //Nao utilizamos o editar na venda
                }
                this.LimpaTela();
                pnFinalizaVenda.Visible = false;
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
            this.totalVenda = 0;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //implementar o cancelamento da venda
            //temos que alterar o campo status da tabela de venda
            //retornar os ietns para o estoque
            //devolver o dinheiro para o comprador, neste trabalho nao vamos trabalhar com caixa.

            DialogResult d = MessageBox.Show("Deseja realmente cancelar esta venda? ", "Aviso", MessageBoxButtons.YesNo);
            if(d.ToString() == "Yes")
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                if (bll.CancelarVenda(Convert.ToInt32(txtVenCod.Text)) == true)
                {
                    MessageBox.Show("Venda cancelada com sucesso");
                    LimpaTela();
                    this.alteraBotoes(1);
                }
                else
                {
                    MessageBox.Show("nao foi possivel cancelar a venda. \nConsulte o suporte tecnico.");
                    LimpaTela();
                    this.alteraBotoes(1);
                }
            }
        }
    }
}
