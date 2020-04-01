using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelaVenda
    {
        public ModeloParcelaVenda()
        {
            this.PveCod = 0;
            this.PveValor = 0;
            this.VenCod = 0;
            //this.PveDataPagto = DateTime.Now;
            this.PveDataVecto = DateTime.Now;
        }

        private int pve_cod;
        public int PveCod
        {
            get { return this.pve_cod; }
            set { this.pve_cod = value; }
        }

        private int ven_cod;
        public int VenCod
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }

        private Double pve_valor;
        public Double PveValor
        {
            get { return this.pve_valor; }
            set { this.pve_valor = value; }
        }

        private DateTime pve_dataPagto;
        public DateTime PveDataPagto
        {
            get { return this.pve_dataPagto; }
            set { this.pve_dataPagto = value; }
        }

        private DateTime pve_dataVecto;
        public DateTime PveDataVecto
        {
            get { return this.pve_dataVecto; }
            set { this.pve_dataVecto = value; }
        }
    }
}
