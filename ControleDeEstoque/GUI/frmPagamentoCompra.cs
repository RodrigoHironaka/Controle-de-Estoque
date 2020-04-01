﻿using BLL;
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
    public partial class frmPagamentoCompra : Form
    {
        public int pcoCod = 0;
        public frmPagamentoCompra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            btPagar.Enabled = false;
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txtCodigo.Text = modelo.ComCod.ToString();
                dtData.Value = modelo.ComData; 
                BLLFornecedor bllf = new BLLFornecedor(cx);
                ModeloFornecedor modelof = bllf.CarregaModeloFornecedor(modelo.ForCod);
                txtFornecedor.Text = modelof.ForNome;
                txtValor.Text = modelo.ComTotal.ToString();

                BLLParcelaCompra bllp = new BLLParcelaCompra(cx);
                dgvParcelas.DataSource = bllp.Localizar(modelo.ComCod);
                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
                dgvParcelas.Columns[2].HeaderText = "Pago em:";
                dgvParcelas.Columns[3].HeaderText = "Vencimento";
                dgvParcelas.Columns[4].Visible = false;
            }
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLParcelaCompra bllp = new BLLParcelaCompra(cx);
            int comCod = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtpPagto.Value;
            bllp.EfetuaPagamentoParcela(comCod,this.pcoCod, data);

            BLLParcelaCompra bllp2 = new BLLParcelaCompra(cx);
            dgvParcelas.DataSource = bllp2.Localizar(comCod);
            dgvParcelas.Columns[0].HeaderText = "Parcela";
            dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
            dgvParcelas.Columns[2].HeaderText = "Pago em:";
            dgvParcelas.Columns[3].HeaderText = "Vencimento";
            dgvParcelas.Columns[4].Visible = false;
            btPagar.Enabled = false;
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btPagar.Enabled = false;
            this.pcoCod = 0;
            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString()=="")
            {
                btPagar.Enabled = true;
                this.pcoCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
