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
    public class BLLParcelaVenda
    {
        private DALConexao conexao;
        public BLLParcelaVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelaVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }

            //variavel para verificar a data
            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelaVenda DALObj = new DALParcelaVenda(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloParcelaVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }

            //variavel para verificar a data
            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DALParcelaVenda DALObj = new DALParcelaVenda(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModeloParcelaVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DALParcelaVenda DALObj = new DALParcelaVenda(conexao);
            DALObj.Excluir(modelo);
        }

        public void ExcluirTodasAsParcelas(int vencod)
        {
            if (vencod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DALParcelaVenda DALObj = new DALParcelaVenda(conexao);
            DALObj.ExcluirTodasAsParcelas(vencod);
        }

        public DataTable Localizar(int vencod)
        {
            if (vencod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DALParcelaVenda DALObj = new DALParcelaVenda(conexao);
            return DALObj.Localizar(vencod);
        }

        public ModeloParcelaVenda CarregaModeloParcelaVenda(int PveCod, int VenCod)
        {
            if (PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DALParcelaVenda DALObj = new DALParcelaVenda(conexao);
            return DALObj.CarregaModeloParcelaVenda(PveCod, VenCod);
        }

        public void EfetuaRecebimentoParcela(int venCod, int pveCod, DateTime dtrecebimento)
        {
            if (dtrecebimento != null)
            {
                DALParcelaVenda DALObj = new DALParcelaVenda(conexao);
                DALObj.EfetuaRecebimentoParcela(venCod, pveCod, dtrecebimento);
            }
            else
            {
                throw new Exception("Data de recebimento Obrigatoria");
            }
        }
    }
}
