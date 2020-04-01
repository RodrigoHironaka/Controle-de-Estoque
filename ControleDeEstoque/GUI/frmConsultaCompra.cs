using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCompra : Form
    {
        public int codigo = 0;
        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }
        public void ExecutarConsulta(int op)
        {
            //op = 1 todas as compras
            //op = 2 por fornecedor
            //op = 3 data da compra
            //op = 4 parcelas em aberto   
        }

        public void AtualizaCabecalhoCompra()
        {
            dgvDados.Columns[0].HeaderText = "Código Compra";
            dgvDados.Columns[1].HeaderText = "Data da Compra";
            dgvDados.Columns[2].HeaderText = "Fornecedor";
            dgvDados.Columns[3].HeaderText = "Nº NFE";
            dgvDados.Columns[4].HeaderText = "Nº Parcelas";
            dgvDados.Columns[5].HeaderText = "Status da Compra";
            dgvDados.Columns[6].HeaderText = "Total";
            dgvDados.Columns[5].Visible = false;


        }
        private void btLocFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                lbForNome.Text = "Nome do fornecedor: " + modelo.ForNome;
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoCompra();
            }
            else
            {
                txtForCod.Text = "";
                lbForNome.Text = "Nome do fornecedor: ";
            }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar paines
            pFornecedor.Visible = false;
            pData.Visible = false;

            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar();
                this.AtualizaCabecalhoCompra();
            }
            if (rbDataCompra.Checked == true)
            {
                pData.Visible = true;
            }
            if (rbFornecedor.Checked == true)
            {
                pFornecedor.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.LocalizarPorParcelaEmAberto();
                this.AtualizaCabecalhoCompra();
            }
        }

        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dtpIni.Value;
            DateTime dtfim = dtpFim.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllcompra = new BLLCompra(cx);
            dgvDados.DataSource = bllcompra.Localizar(dtini, dtfim);
            this.AtualizaCabecalhoCompra();
        }

        public void AtualizaCabecalhoItens()
        {
            dgvItens.Columns[0].HeaderText = "Código da compra";
            dgvItens.Columns[1].HeaderText = "Código do Item";
            dgvItens.Columns[2].HeaderText = "Código do produto";
            dgvItens.Columns[3].HeaderText = "Nome do Produto";
            dgvItens.Columns[4].HeaderText = "Quantidade";
            dgvItens.Columns[5].HeaderText = "Valor";
            dgvItens.Columns[0].Visible = false;

            try
            {
                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor";
                dgvParcelas.Columns[2].HeaderText = "Data de Pagamento";
                dgvParcelas.Columns[3].HeaderText = "Data de vencimento";
                dgvParcelas.Columns[4].HeaderText = "Código da compra";
                dgvParcelas.Columns[4].Visible = false; //dgvParcelas.Columns[4].Visible = false "pode ser direto"
            }
            catch { }
            
        }
        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                //itens da compra
                BLLItensCompra bllitens = new BLLItensCompra(cx);
                dgvItens.DataSource = bllitens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                //parcelas da compra
                BLLParcelaCompra bllparcelas = new BLLParcelaCompra(cx);
                dgvParcelas.DataSource = bllparcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                AtualizaCabecalhoItens();
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
