using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao conexao;
        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }
            modelo.ForNome = modelo.ForNome.ToUpper();

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório");
            }
            modelo.ForCnpj = modelo.ForCnpj.ToUpper();

            //verificar cnpj-----------------------------------------------------------------------------

            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("O CNPJ é Inválido");
            }
            //------------------------------------------------------------------------------------------------
            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do fornecedor é obrigatório");
            }
            modelo.ForIe = modelo.ForIe.ToUpper();

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do fornecedor é obrigatório");
            }
            modelo.ForFone = modelo.ForFone.ToUpper();
            //-------------------------------------------------------------------------------------------------
            //validação email
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex); //Regex Biblioteca de espressoes regulares
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Digite um email válido.");
            }

            //-------------------------------------------------------------------------------------------------


            DALFornecedor DALObj = new DALFornecedor(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }
            modelo.ForNome = modelo.ForNome.ToUpper();

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório");
            }
            modelo.ForCnpj = modelo.ForCnpj.ToUpper();

            //verificar cnpj-----------------------------------------------------------------------------
            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("O CNPJ é Inválido");
            }

            //-------------------------------------------------------------------------------------------------
            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do fornecedor é obrigatório");
            }
            modelo.ForIe = modelo.ForIe.ToUpper();

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do fornecedor é obrigatório");
            }
            modelo.ForFone = modelo.ForFone.ToUpper();
            //-------------------------------------------------------------------------------------------------
            //valida email
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                             + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Digite um email válido.");
            }

            DALFornecedor DALObj = new DALFornecedor(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            return DALObj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarCNPJ(String valor)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            return DALObj.LocalizarCNPJ(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            return DALObj.CarregaModeloFornecedor(codigo);
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            return DALObj.CarregaModeloFornecedor(cnpj);
        }
    }
}
