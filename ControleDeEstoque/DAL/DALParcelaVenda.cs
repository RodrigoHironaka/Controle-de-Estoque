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
    public class DALParcelaVenda
    {
        private DALConexao conexao;

        public DALParcelaVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelaVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into parcelasvenda(pve_cod, pve_valor, pve_datavecto, ven_cod) values (@pve_cod, @pve_valor, @pve_datavecto, @ven_cod);";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);
            cmd.Parameters["@pve_datavecto"].Value = modelo.PveDataVecto;
            cmd.ExecuteNonQuery();
        }

        public void Alterar(ModeloParcelaVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update parcelasvenda set  pve_valor = @pve_valor, pve_datapagto = @pve_datapagto, pve_datavecto = @pve_datavecto" +
                "where pve_cod = @pve_cod, and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.Date);
            //data de pagamento
            if (modelo.PveDataPagto == null)
            {
                cmd.Parameters["@pve_datavecto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pve_datavecto"].Value = modelo.PveDataPagto;
            }
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ModeloParcelaVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelasvenda where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.ExecuteNonQuery();
        }

        public void ExcluirTodasAsParcelas(int vencod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelasvenda where ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@ven_cod", vencod);
            cmd.ExecuteNonQuery();
        }

        public DataTable Localizar(int vencod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from parcelasvenda where ven_cod =" +
                vencod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelaVenda CarregaModeloParcelaVenda(int PveCod, int VenCod)
        {
            ModeloParcelaVenda modelo = new ModeloParcelaVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelasvenda where pve_cod = @pve_cod and ven_cod = @ven_cod";
            cmd.Parameters.AddWithValue("@pve_cod", PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", VenCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PveCod = PveCod;
                modelo.VenCod = VenCod;
                modelo.PveDataPagto = Convert.ToDateTime(registro["pve_datapagto"]);
                modelo.PveDataVecto = Convert.ToDateTime(registro["pve_datavecto"]);
                modelo.PveValor = Convert.ToDouble(registro["pve_valor"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public void EfetuaRecebimentoParcela(int venCod, int pveCod, DateTime dtrecebimento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update parcelasvenda set pve_datapagto = @pve_datapagto " +
                "where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", pveCod);
            cmd.Parameters.AddWithValue("@ven_cod", venCod);
            cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters["@pve_datapagto"].Value = dtrecebimento.Date;
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

    }
}
