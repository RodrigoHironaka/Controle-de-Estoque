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
    public class BLLItensCompra
    {
        private DALConexao conexao;
        public BLLItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O Código da compra é obrigatório");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O Código do item é obrigatório");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O Código do produto é obrigatório");
            }

            DALItensCompra DALObj = new DALItensCompra(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O Código da compra é obrigatório");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O Código do item é obrigatório");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O Código do produto é obrigatório");
            }

            DALItensCompra DALObj = new DALItensCompra(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O Código da compra é obrigatório");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O Código do item é obrigatório");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O Código do produto é obrigatório");
            }

            DALItensCompra DALObj = new DALItensCompra(conexao);
            DALObj.Excluir(modelo);
        }

        public void ExcluirTodosOsItens(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DALItensCompra DALObj = new DALItensCompra(conexao);
            DALObj.ExcluirTodosOsItens(comcod);
        }


        public DataTable Localizar(int comcod)
        {
            DALItensCompra DALObj = new DALItensCompra(conexao);
            return DALObj.Localizar(comcod);
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod, int ComCod, int ProCod)
        {
            DALItensCompra DALObj = new DALItensCompra(conexao);
            return DALObj.CarregaModeloItensCompra(ItcCod, ComCod, ProCod);
        }
    }
}
