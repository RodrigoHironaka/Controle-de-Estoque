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
    public class BLLCompra
    {
        private DALConexao conexao;
        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("A data da compra é diferente da data atual");
            //    throw new Exception("O nome da categoria é obrigatório");
            //}

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O numero de parcelas deve ser maior que zero!");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor deve ser informado!");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O totals deve ser maior que zero!");
            }
            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra deve ser maior que zero!");
            }

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O numero de parcelas deve ser maior que zero!");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor deve ser informado!");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O totals deve ser maior que zero!");
            }
            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar()
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar();
        }
        public DataTable LocalizarPorParcelaEmAberto()
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.LocalizarPorParcelasEmAberto();
        }

        public int QuantidadeParcelasNaoPagas(int Codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.QuantidadeParcelasNaoPagas(Codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar(codigo);
        }

        public DataTable Localizar(String nome)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar(nome);
        }

        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar(dtinicial, dtfinal);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.CarregaModeloCompra(codigo);
        }
    }
}
