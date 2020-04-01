using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVenda
    {
        private DALConexao conexao;

        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into venda(ven_data, ven_nfiscal, ven_total, ven_nparcelas, ven_status, cli_cod, tpa_cod, ven_avista) values "
                + "(@ven_data, @ven_nfiscal, @ven_total, @ven_nparcelas, @ven_status, @cli_cod, @tpa_cod, @ven_avista); select @@IDENTITY;";

            cmd.Parameters.Add("@ven_data", System.Data.SqlDbType.DateTime);//especifica se realmente é uma data
            cmd.Parameters["@ven_data"].Value = modelo.VenData;//armazena a informação

            cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNfiscal);
            cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNparcelas);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@ven_avista", modelo.VenAvista);
            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Alterar(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update venda set ven_data=@ven_data, ven_nfiscal=@ven_nfiscal, ven_total=@ven_total, " +
                "ven_nparcelas=@ven_nparcelas, ven_status=@ven_status, cli_cod=@cli_cod, tpa_cod=@tpa_cod, ven_avista=@ven_avista " +
                "where ven_cod=@codigo;";

            cmd.Parameters.Add("@ven_data", System.Data.SqlDbType.DateTime);//especifica se realmente é uma data
            cmd.Parameters["@ven_data"].Value = modelo.VenData;//armazena a informação

            cmd.Parameters.AddWithValue("@ven_nfiscal", modelo.VenNfiscal);
            cmd.Parameters.AddWithValue("@ven_total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@ven_nparcelas", modelo.VenNparcelas);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@cli_cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpa_cod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@ven_avista", modelo.VenAvista);
            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
            cmd.ExecuteNonQuery();

        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from venda where ven_cod=@codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();
        }

        //implementar cancelar venda
        public Boolean CancelarVenda(int codigo)
        {
            Boolean retorno = true;
            //Atualizar a tabela de venda
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.IniciarTransacao();
            try
            {
                cmd.Transaction = this.conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set ven_status= 'cancelado'" +
                    "where ven_cod=@codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                //incrementar o estoque com os itens da venda cancelada

                //localizar os itens da venda
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select itv_cod, pro_cod, itv_qtde from itensvenda where ven_cod =" +
                    codigo.ToString(), conexao.StringConexao);
                da.Fill(tabela);

                //alterar a qtd do estoque
                ModeloProduto produto;
                //DALConexao cxp = new DALConexao(DadosDaConexao.StringDeConexao);
                //DALProduto dalProduto = new DALProduto(cxp);
                DALProduto dalProduto = new DALProduto(conexao); 
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(tabela.Rows[i]["pro_cod"]),true); 
                    produto.ProQtde = produto.ProQtde + Convert.ToDouble(tabela.Rows[i]["itv_qtde"]);
                    dalProduto.Alterar(produto,true);
                }
                conexao.TerminarTransacao();
                conexao.Desconectar();
            }
            catch
            {
                conexao.CancelaTransacao();
                conexao.Desconectar();
                retorno = false;
            }
            return retorno;
        }

        //localizar pelo CÓDIGO do cliente
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select v.ven_cod, v.ven_data, c.cli_nome, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas,v.ven_status,v.ven_total " +
                                                   "from venda v " +
                                                   "inner join cliente c on(v.cli_cod = c.cli_cod) " +
                                                   "where c.cli_cod = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //localizar pelo NOME do cliente
        public DataTable Localizar(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select v.ven_cod, v.ven_data, c.cli_nome, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas,v.ven_status,v.ven_total " +
                                                   "from venda v " +
                                                   "inner join cliente c on(v.cli_cod = c.cli_cod) " +
                                                    "where c.cli_nome like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //localizar venda completa
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select v.ven_cod, v.ven_data, c.cli_nome, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas, v.ven_status, v.ven_total " +
                                                    "from venda v " +
                                                    "inner join cliente c on(v.cli_cod = c.cli_cod)", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //localizar parcelas abertas
        public DataTable LocalizarPorParcelasEmAberto()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select distinct v.ven_cod, v.ven_data, c.cli_nome, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas,v.ven_status,v.ven_total " +
                                                   "from venda v " +
                                                   "inner join cliente c on(v.cli_cod = c.cli_cod) " +
                                                   "inner join parcelasvenda p on (v.ven_cod = p.ven_cod) " +
                                                   "where p.pve_datapagto is NULL", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        // retorna quantidade de parcelas nao pagas
        public int QuantidadeParcelasNaoPagas(int Codigo)
        {
            int qtde = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select count(ven_cod) from parcelasvenda where ven_cod = @cod and pve_datapagto is null";
            cmd.Parameters.AddWithValue("@cod", Codigo);
            conexao.Conectar();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

            return qtde;
        }

        //localizar por DATA da venda
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select v.ven_cod, v.ven_data, c.cli_nome, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas,v.ven_status,v.ven_total " +
                                                   "from venda v " +
                                                   "inner join cliente c on(v.cli_cod = c.cli_cod) " +
                                                    "where v.ven_data BETWEEN @dtinicial and @dtfinal ";
            //verifica se é uma DATA
            cmd.Parameters.Add("@dtinicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtinicial"].Value = dtinicial;

            //verifica se é uma DATA
            cmd.Parameters.Add("@dtfinal", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtfinal"].Value = dtfinal;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenNfiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenNparcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.VenAvista = Convert.ToInt32(registro["ven_avista"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
