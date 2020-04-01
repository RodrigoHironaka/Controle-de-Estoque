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
    public partial class frmRecebimentoVenda : Form
    {
        public int pveCod = 0;
        public frmRecebimentoVenda()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            btReceber.Enabled = false;
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            btReceber.Enabled = false;
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txtCodigo.Text = modelo.VenCod.ToString();
                dtData.Value = modelo.VenData;
                BLLCliente bllc = new BLLCliente(cx);
                ModeloCliente modeloc = bllc.CarregaModeloCliente(modelo.CliCod);
                txtCliente.Text = modeloc.CliNome;
                txtValor.Text = modelo.VenTotal.ToString();

                BLLParcelaVenda bllp = new BLLParcelaVenda(cx);
                dgvParcelas.DataSource = bllp.Localizar(modelo.VenCod);
                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
                dgvParcelas.Columns[2].HeaderText = "Recebido em:";
                dgvParcelas.Columns[3].HeaderText = "Vencimento";
                dgvParcelas.Columns[4].Visible = false;
            }
        }

        private void btReceber_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLParcelaVenda bllp = new BLLParcelaVenda(cx);
            int venCod = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtpRecebimento.Value;
            bllp.EfetuaRecebimentoParcela(venCod, this.pveCod, data);

            BLLParcelaVenda bllp2 = new BLLParcelaVenda(cx);
            dgvParcelas.DataSource = bllp2.Localizar(venCod);
            dgvParcelas.Columns[0].HeaderText = "Parcela";
            dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
            dgvParcelas.Columns[2].HeaderText = "Recebido em:";
            dgvParcelas.Columns[3].HeaderText = "Vencimento";
            dgvParcelas.Columns[4].Visible = false;
            btReceber.Enabled = false;
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btReceber.Enabled = false;
            this.pveCod = 0;
            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btReceber.Enabled = true;
                this.pveCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
