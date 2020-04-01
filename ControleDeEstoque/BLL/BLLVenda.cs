using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVenda
    {
        private DALConexao conexao;
        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo)
        {
            if (modelo.VenNparcelas <= 0)
            {
                throw new Exception("O numero de parcelas deve ser maior que zero!");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do cliente deve ser informado!");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O total deve ser maior que zero!");
            }

            if (modelo.VenNfiscal <= 0)
            {
                throw new Exception("O numero da nota fiscal deve ser maior que zero!");
            }
            DALVenda DALObj = new DALVenda(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda deve ser maior que zero!");
            }

            if (modelo.VenNparcelas <= 0)
            {
                throw new Exception("O numero de parcelas deve ser maior que zero!");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do cliente deve ser informado!");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O totals deve ser maior que zero!");
            }

            if (modelo.VenNfiscal <= 0)
            {
                throw new Exception("O numero da nota fiscal deve ser maior que zero!");
            }
            DALVenda DALObj = new DALVenda(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código da venda deve ser maior que zero!");
            }
            DALVenda DALObj = new DALVenda(conexao);
            DALObj.Excluir(codigo);
        }

        public Boolean CancelarVenda(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código da venda deve ser maior que zero!");
            }
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.CancelarVenda(codigo);
        }

        public DataTable Localizar(String nome)
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.Localizar(nome);
        }

        public DataTable Localizar(int codigo)
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.Localizar(codigo);
        }

        public DataTable Localizar()
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.Localizar();
        }

        public DataTable LocalizarPorParcelaEmAberto()
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.LocalizarPorParcelasEmAberto();
        }

        public int QuantidadeParcelasNaoPagas(int Codigo)
        {
            if (Codigo <= 0)
            {
                throw new Exception("O código da venda deve ser maior que zero!");
            }
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.QuantidadeParcelasNaoPagas(Codigo);
        }

        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.Localizar(dtinicial, dtfinal);
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código da venda deve ser maior que zero!");
            }
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.CarregaModeloVenda(codigo);
        }
    }
}
