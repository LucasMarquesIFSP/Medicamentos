using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMedicamentos
{
    class Lote
    {
        private int ID;
        private int QTD;
        private DateTime venc;

        public Lote()
        {
            this.ID = 0;
            this.QTD = 0;
            this.venc = new DateTime();
        }

        public Lote(int id, int qtd, DateTime venc)
        {
            this.ID = id;
            this.QTD = qtd;
            this.venc = venc;
        }

        public String toString()
        {
            return this.ID.ToString() + " - " + this.QTD.ToString() + " - " + this.venc.Date.ToString();
        }

        public int getQtd()
        {
            return QTD;
        }

        public void setQTD(int qt)
        {
            this.QTD = qt;
        }
    }
}
