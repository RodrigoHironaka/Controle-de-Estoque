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
    public class BLLProduto
    {
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição é obrigatório");
            }

            if (modelo.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }

            if (modelo.ProQtde <= 0)
            {
                throw new Exception("A quantidade do produto deve ser maior que zero");
            }

            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O codigo da sub categoria é obrigatório");
            }

            if (modelo.CatCod <= 0)
            {
                throw new Exception("O codigo da categoria é obrigatório");
            }

            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O codigo daunidade de medida é obrigatório");
            }

            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Incluir(modelo);
        }

        public void Excluir(int codigo)
        {
            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Excluir(codigo);
        }

        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }

            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição é obrigatório");
            }

            if (modelo.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }

            if (modelo.ProQtde <= 0)
            {
                throw new Exception("A quantidade do produto deve ser maior que zero");
            }

            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O codigo da sub categoria é obrigatório");
            }

            if (modelo.CatCod <= 0)
            {
                throw new Exception("O codigo da categoria é obrigatório");
            }

            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O codigo da unidade de medida é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O codigo do produto obrigatório");
            }

            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Alterar(modelo);
        }

        public DataTable Localizar(String valor)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.Localizar(valor);
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CarregaModeloProduto(codigo);
        }
            
    }
}
