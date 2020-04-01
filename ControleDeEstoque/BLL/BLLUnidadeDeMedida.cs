using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUnidadeDeMedida
    {
        private DALConexao conexao;
        public BLLUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Unidade de Medida é obrigatório");
            }
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da Unidade de Medida é obrigatório");
            }
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Unidade de Medida é obrigatório");
            }

            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            return DALObj.Localizar(valor);
        }

        public int VerificaUnidadeDeMedida(String valor)
        {
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            return DALObj.VerificaUnidadeDeMedida(valor);
        }

        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            return DALObj.CarregaModeloUnidadeDeMedida(codigo);
        }
    }
}
