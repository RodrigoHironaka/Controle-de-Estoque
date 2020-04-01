using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensVenda
    {
        public ModeloItensVenda()
        {
            this.ItvCod = 0;
            this.ItvQtde = 0;
            this.ItvValor = 0;
            this.VenCod = 0;
            this.ProCod = 0;
        }
        //---------------------------------------------------------------
        public ModeloItensVenda(int itvcod, double qtde, double valor, int vencod, int procod)
        {
            this.ItvCod = itvcod;
            this.ItvQtde = qtde;
            this.ItvValor = valor;
            this.VenCod = vencod;
            this.ProCod = procod;
        }
        //---------------------------------------------------------------
        private int itv_cod;
        public int ItvCod
        {
            get { return this.itv_cod; }
            set { this.itv_cod = value; }
        }
        //---------------------------------------------------------------
        private double itv_qtde;
        public double ItvQtde
        {
            get { return this.itv_qtde; }
            set { this.itv_qtde = value; }
        }
        //---------------------------------------------------------------
        private double itv_valor;
        public double ItvValor
        {
            get { return this.itv_valor; }
            set { this.itv_valor = value; }
        }
        //---------------------------------------------------------------
        private int ven_cod;
        public int VenCod
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }
        //---------------------------------------------------------------
        private int pro_cod;
        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        }
        //---------------------------------------------------------------
    }
}
