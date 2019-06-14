using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMedicamentos
{
    class Medicamento
    {
        private int ID;
        private string NOME;
        private string LABORATORIO;
        private Queue<Lote> lotes;

        public Medicamento()
        {
            this.ID = 0;
            this.NOME = "";
            this.LABORATORIO = "";
            this.lotes = new Queue<Lote>();
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.ID = id;
            this.NOME = nome;
            this.LABORATORIO = laboratorio;
            this.lotes = new Queue<Lote>();
        }

        public int qtdeDisponivel()
        {
            int soma = 0;
            foreach(Lote x in this.lotes)
            {
                soma += x.getQtd();
            }

            return soma;
        }

        public void comprar(Lote lote)
        {
            this.lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {
            bool veri = false;
            int valida = qtde;

            if(qtde <= qtdeDisponivel())
            {
                while(valida > 0)
                {
                    if(lotes.First().getQtd() > 0)
                    {
                        valida = valida - lotes.First().getQtd();
                        if (valida > 0) { }
                        //problemas na matematica (- com - é +)
                        else
                            lotes.First().setQTD(lotes.First().getQtd() - valida);
                    }
                    else if(lotes.First().getQtd() <= 0)
                    {
                        lotes.Dequeue();
                    }
                }
                veri = true;
            }
            else
            {
                veri = false;
            }

            return veri;
        }

        public int getID()
        {
            return this.ID;
        }

        public string toString()
        {
            return "ID: "+this.ID.ToString() + " | Nome: " + this.NOME + " | Lab:" + this.LABORATORIO + " | QtdDispo: " + qtdeDisponivel().ToString();
        }

        public override bool Equals(object obj)
        {
            bool valida = true;
            if (this.ID != int.Parse(obj.ToString()))
                valida = false;

            return valida;
        }

        public Queue<Lote> getLote()
        {
            return lotes;
        }

    }
}
