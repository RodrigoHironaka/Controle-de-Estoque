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
    public partial class frmConsultaVenda : Form
    {
        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        public int codigo = 0;

        public void AtualizaCabecalhoVenda()
        {
            dgvDados.Columns[0].HeaderText = "Código Venda";
            dgvDados.Columns[1].HeaderText = "Data da Venda";
            dgvDados.Columns[2].HeaderText = "Cliente";
            dgvDados.Columns[3].HeaderText = "Nº NFE";
            dgvDados.Columns[4].HeaderText = "Venda a vista";
            dgvDados.Columns[5].HeaderText = "Nº Parcelas";
            dgvDados.Columns[6].HeaderText = "Status da Venda";
            dgvDados.Columns[7].HeaderText = "Total";
            dgvDados.Columns[4].Visible = false;
            dgvDados.Columns[6].Visible = false;
        }

        public void AtualizaCabecalhoItens()
        {
            dgvItens.Columns[0].HeaderText = "Código da Venda";
            dgvItens.Columns[1].HeaderText = "Código do Item";
            dgvItens.Columns[2].HeaderText = "Código do produto";
            dgvItens.Columns[3].HeaderText = "Nome do Produto";
            dgvItens.Columns[4].HeaderText = "Quantidade";
            dgvItens.Columns[5].HeaderText = "Valor";
            dgvItens.Columns[0].Visible = false;

            try
            {
                dgvParcelas.Columns[0].HeaderText = "Código da Venda";
                dgvParcelas.Columns[1].HeaderText = "Parcelas";
                dgvParcelas.Columns[2].HeaderText = "Valor";
                dgvParcelas.Columns[3].HeaderText = "Data de Pagamento";
                dgvParcelas.Columns[4].HeaderText = "Data de Vencimento";
                dgvParcelas.Columns[0].Visible = false; //dgvParcelas.Columns[4].Visible = false "pode ser direto"
            }
            catch { }

        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar paines
            pCliente.Visible = false;
            pData.Visible = false;

            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar();
                this.AtualizaCabecalhoVenda();
            }
            if (rbDataVenda.Checked == true)
            {
                pData.Visible = true;
            }
            if (rbCliente.Checked == true)
            {
                pCliente.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarPorParcelaEmAberto();
                this.AtualizaCabecalhoVenda();
            }
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }

        private void btLocCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                lbCliNome.Text = "Nome do Cliente: " + modelo.CliNome;
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoVenda();
            }
            else
            {
                txtCliCod.Text = "";
                lbCliNome.Text = "Nome do Cliente: ";
            }
        }

        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dtpIni.Value;
            DateTime dtfim = dtpFim.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.Localizar(dtini, dtfim);
            this.AtualizaCabecalhoVenda();
        }

        private void dgvDados_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void dgvDados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                //itens da venda
                BLLItensVenda bllitens = new BLLItensVenda(cx);
                dgvItens.DataSource = bllitens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                //parcelas da compra
                BLLParcelaVenda bllparcelas = new BLLParcelaVenda(cx);
                dgvParcelas.DataSource = bllparcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                AtualizaCabecalhoItens();
            }
        }
    }
}
