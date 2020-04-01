using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVenda
    {
        public ModeloVenda()
        {
            this.VenCod = 0;
            this.VenData = DateTime.Now;
            this.VenNfiscal = 0;
            this.VenTotal = 0;
            this.VenNparcelas = 0;
            this.VenStatus = "ativo";
            this.CliCod = 0;
            this.TpaCod = 0;
            this.VenAvista = 1;
        }

        public ModeloVenda(int venCod, DateTime data, int nfiscal, double total, int nparcelas, String status, int cliCod, int tpaCod, int venAvista)
        {
            this.VenCod = venCod;
            this.VenData = data;
            this.VenNfiscal = nfiscal;
            this.VenTotal = total;
            this.VenNparcelas = nparcelas;
            this.VenStatus = status;
            this.CliCod = cliCod;
            this.TpaCod = tpaCod;
            this.VenAvista = venAvista;
        }

        private int _ven_cod;
        public int VenCod
        {
            get { return this._ven_cod; }
            set { this._ven_cod = value; }
        }

        private DateTime _ven_data;
        public DateTime VenData
        {
            get { return this._ven_data; }
            set { this._ven_data = value; }
        }

        private int _ven_nfiscal;
        public int VenNfiscal
        {
            get { return this._ven_nfiscal; }
            set { this._ven_nfiscal = value; }
        }

        private Double _ven_total;
        public Double VenTotal
        {
            get { return this._ven_total; }
            set { this._ven_total = value; }
        }

        private int _ven_nparcelas;
        public int VenNparcelas
        {
            get { return this._ven_nparcelas; }
            set { this._ven_nparcelas = value; }
        }

        private String _ven_status;
        public String VenStatus
        {
            get { return this._ven_status; }
            set { this._ven_status = value; }
        }

        private int _cli_cod;
        public int CliCod
        {
            get { return this._cli_cod; }
            set { this._cli_cod = value; }
        }

        private int _tpa_cod;
        public int TpaCod
        {
            get { return this._tpa_cod; }
            set { this._tpa_cod = value; }
        }

        private int _ven_avista;
        public int VenAvista
        {
            get { return this._ven_avista; }
            set { this._ven_avista = value; }
        }
    }
}
