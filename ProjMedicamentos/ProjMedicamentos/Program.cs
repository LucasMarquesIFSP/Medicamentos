using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMedicamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamentos medicamentos = new Medicamentos();
            List<Medicamento> lista = medicamentos.getLista();
            int menu, qtd, id, idLote, dia, ano, mes;
            string med, lab;


            do
            {
                Console.Clear();

                Console.WriteLine("0. Finalizar Processo");
                Console.WriteLine("1. Cadastrar medicamento");
                Console.WriteLine("2. Consultar medicamento");
                Console.WriteLine("3. Consultar medicamento Completo");
                Console.WriteLine("4. Comprar medicamento (cadastrar lote)");
                Console.WriteLine("5. Vender medicamento (abater do lote mais antigo)");
                Console.WriteLine("6. Listar medicamentos (informando dados sintéticos)");

                menu = int.Parse(Console.ReadLine());

                switch(menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Id do Medicamento: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nome do Medicamento: ");
                        med = Console.ReadLine();
                        Console.WriteLine("Laboratório de Fabricação: ");
                        lab = Console.ReadLine();
                        medicamentos.adicionar(new Medicamento(id, med, lab));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Id do Medicamento: ");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine(medicamentos.pesquisar(new Medicamento(id, "", "")).toString());
                        Console.ReadKey();
                        break;
                    case 3:
                        //NÃO TO ENTENDENDO ESSA PORRA.
                        Console.Clear();
                        Console.WriteLine("Id do Medicamento: ");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine(medicamentos.pesquisar(new Medicamento(id, "", "")).toString());
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Qual o ID do medicamento: ");
                        id = int.Parse(Console.ReadLine());
                        //generico = medicamentos.pesquisar(new Medicamento(id, "", ""));

                        Console.WriteLine("Qual o ID do Lote: ");
                        idLote = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a Quantidade de medicamentos: ");
                        qtd = int.Parse(Console.ReadLine());
                        Console.WriteLine("Vencimento");
                        Console.WriteLine("Dia: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Mes: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ano: ");
                        ano = int.Parse(Console.ReadLine());

                        medicamentos.pesquisar(new Medicamento(id, "", "")).comprar(new Lote(idLote, qtd, new DateTime(ano, mes, dia)));
                        //generico.comprar(new Lote(idLote, qtd, new DateTime(ano, mes, dia)));
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Qual o ID do medicamento: ");
                        id = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Quantidade: ");
                        qtd = int.Parse(Console.ReadLine());
                        if (medicamentos.pesquisar(new Medicamento(id, "", "")).vender(qtd))
                            Console.WriteLine("Venda Realizada Com sucesso");
                        else
                            Console.WriteLine("Venda Não Realizada");
                        break;
                    case 6:
                        Console.Clear();
                        
                        int a = 0;
                        foreach(Medicamento x in lista)
                        {
                            a += 1;
                            Console.WriteLine(a.ToString() + ": " + x.toString());
                        }

                        Console.ReadKey();
                        break;
                }

            } while (menu != 0);
        }
    }
}
