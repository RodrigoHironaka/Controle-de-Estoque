using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLParcelaCompra
    {
        private DALConexao conexao;
        public BLLParcelaCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelaCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }

            //variavel para verificar a data
            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelaCompra DALObj = new DALParcelaCompra(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloParcelaCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }

            //variavel para verificar a data
            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DALParcelaCompra DALObj = new DALParcelaCompra(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModeloParcelaCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DALParcelaCompra DALObj = new DALParcelaCompra(conexao);
            DALObj.Excluir(modelo);
        }

        public void ExcluirTodasAsParcelas(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DALParcelaCompra DALObj = new DALParcelaCompra(conexao);
            DALObj.ExcluirTodasAsParcelas(comcod);
        }

        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DALParcelaCompra DALObj = new DALParcelaCompra(conexao);
            return DALObj.Localizar(comcod);
        }

        public ModeloParcelaCompra CarregaModeloParcelaCompra(int PcoCod, int ComCod)
        {
            if (PcoCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DALParcelaCompra DALObj = new DALParcelaCompra(conexao);
            return DALObj.CarregaModeloParcelaCompra(PcoCod, ComCod);
        }

        public void EfetuaPagamentoParcela(int comCod, int pcoCod, DateTime dtpagto)
        {
            if(dtpagto != null)
            {
                DALParcelaCompra DALObj = new DALParcelaCompra(conexao);
                DALObj.EfetuaPagamentoParcela(comCod, pcoCod, dtpagto);
            }
            else
            {
                throw new Exception("Data de pagamento Obrigatoria");
            }
        }
    }
}
