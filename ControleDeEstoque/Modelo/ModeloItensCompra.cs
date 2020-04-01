using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensCompra
    {
        public ModeloItensCompra()
        {
            this.ItcCod = 0;
            this.ItcQtde = 0;
            this.ItcValor = 0;
            this.ComCod = 0;
            this.ProCod = 0;
        }
        //---------------------------------------------------------------
        public ModeloItensCompra(int itccod, double qtde, double valor, int comcod, int procod)
        {
            this.ItcCod = itccod;
            this.ItcQtde = qtde;
            this.ItcValor = valor;
            this.ComCod = comcod;
            this.ProCod = procod;
        }
//---------------------------------------------------------------
        private int itc_cod;
        public int ItcCod
        {
            get { return this.itc_cod; }
            set { this.itc_cod = value; }
        }
//---------------------------------------------------------------
        private double itc_qtde;
        public double ItcQtde
        {
            get { return this.itc_qtde; }
            set { this.itc_qtde = value; }
        }
//---------------------------------------------------------------
        private double itc_valor;
        public double ItcValor
        {
            get { return this.itc_valor; }
            set { this.itc_valor = value; }
        }
//---------------------------------------------------------------
        private int com_cod;
        public int ComCod
        {
            get { return this.com_cod; }
            set { this.com_cod = value; }
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
