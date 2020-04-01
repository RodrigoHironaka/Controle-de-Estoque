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
    public class BLLItensVenda
    {
        private DALConexao conexao;
        public BLLItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda deve ser maior que zero!");
            }

            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O valor do item deve ser maior que zero!");
            }

            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero!");
            }

            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor deve ser maior que zero!");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto deve ser maior que zero!");
            }
            DALItensVenda DALObj = new DALItensVenda(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda deve ser maior que zero!");
            }

            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O valor do item deve ser maior que zero!");
            }

            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero!");
            }

            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor deve ser maior que zero!");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto deve ser maior que zero!");
            }
            DALItensVenda DALObj = new DALItensVenda(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda deve ser maior que zero!");
            }

            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O valor do item deve ser maior que zero!");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto deve ser maior que zero!");
            }
            DALItensVenda DALObj = new DALItensVenda(conexao);
            DALObj.Excluir(modelo);
        }

        public void ExcluirTodosOsItens(int vencod)
        {
            DALItensVenda DALObj = new DALItensVenda(conexao);
            DALObj.ExcluirTodosOsItens(vencod);
        }

        public DataTable Localizar(int vencod)
        {
            DALItensVenda DALObj = new DALItensVenda(conexao);
            return DALObj.Localizar(vencod);
        }

        public ModeloItensVenda CarregaModeloItensVenda(int ItvCod, int VenCod, int ProCod)
        {
            DALItensVenda DALObj = new DALItensVenda(conexao);
            return DALObj.CarregaModeloItensVenda(ItvCod,VenCod, ProCod);
        }  
    }
}
