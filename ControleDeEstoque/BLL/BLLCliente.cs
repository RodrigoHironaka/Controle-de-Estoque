using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;
using Ferramentas;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;
        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            modelo.CliNome = modelo.CliNome.ToUpper();

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do cliente é obrigatório");
            }
            modelo.CliCpfCnpj = modelo.CliCpfCnpj.ToUpper();

            //verificar cpj e cnpj-----------------------------------------------------------------------------
            if (modelo.CliTipo == "Física")
            {
                //cpf
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O CPF é Inválido");
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O CNPJ é Inválido");
                }
            }
            //------------------------------------------------------------------------------------------------
            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatório");
            }
            modelo.CliRgIe = modelo.CliRgIe.ToUpper();

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }
            modelo.CliFone = modelo.CliFone.ToUpper();
            //-------------------------------------------------------------------------------------------------
            //validação email
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex); //Regex Biblioteca de espressoes regulares
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Digite um email válido.");
            }

            //-------------------------------------------------------------------------------------------------


            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            modelo.CliNome = modelo.CliNome.ToUpper();

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do cliente é obrigatório");
            }
            modelo.CliCpfCnpj = modelo.CliCpfCnpj.ToUpper();

            //verificar cpj e cnpj-----------------------------------------------------------------------------
            if (modelo.CliTipo == "Física")
            {
                //cpf
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O CPF é Inválido");
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O CNPJ é Inválido");
                }
            }
            //-------------------------------------------------------------------------------------------------
            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatório");
            }
            modelo.CliRgIe = modelo.CliRgIe.ToUpper();

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }
            modelo.CliFone = modelo.CliFone.ToUpper();
            //-------------------------------------------------------------------------------------------------
            //valida email
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                             + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Digite um email válido.");
            }

            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarCPFCNPJ(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarCPFCNPJ(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregaModeloCliente(codigo);
        }

        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregaModeloCliente(cpfcnpj);
        }
    }
}
