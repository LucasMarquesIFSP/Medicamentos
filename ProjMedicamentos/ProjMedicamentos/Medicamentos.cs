using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMedicamentos
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;
        
        public Medicamentos()
        {
            listaMedicamentos = new List<Medicamento>();
        }
        public void adicionar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            bool veri = false;
            foreach (Medicamento x in listaMedicamentos)
            {
                if (x.Equals(medicamento.getID()) && x.qtdeDisponivel() <= 0)
                {
                    listaMedicamentos.Remove(x);
                    veri = true;
                }
            }
            return veri;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento retorno = new Medicamento();
            foreach(Medicamento x in listaMedicamentos)
            {
                if (x.Equals(medicamento.getID()))
                    retorno = x;
                else
                    retorno = new Medicamento();
            }

            return retorno;
        }
        public List<Medicamento> getLista()
        {
            return listaMedicamentos;
        }
        public int qtdMedicamentos()
        {
            return listaMedicamentos.Count();
        }
    }
}
