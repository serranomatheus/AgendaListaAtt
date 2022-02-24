using System;

namespace AgendaListaAtt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            string opc = "a";
            do
            {
                Console.Clear();
                opc = Menu();

                switch (opc)
                {
                    case "1": InserirContato();
                        break;
                    case "2":
                        break;
                    case "3":agenda.Buscar();
                        break;
                    case "4": agenda.Print();
                        break;
                    case "5":
                        break;
                    case "0":
                        break;
                            default:
                        Console.Clear();
                        Console.WriteLine("*******  Nenhuma opcao selecionado  ********");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                        Console.WriteLine("--------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }while (opc != "0");

            void Buscar()
            {
                Console.Clear();
                if (agenda.Vazio())
                {

                }
            }

            void InserirContato()
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Tipo: ");
                string tipo = Console.ReadLine();
                Console.Write("Ddd: ");
                string ddd = Console.ReadLine();
                Console.Write("Numero: ");
                string numero = Console.ReadLine();
                agenda.Push(new Contato(nome, email, new Telefone(tipo, ddd, numero)));
            }          

            string Menu()
            {
                Console.WriteLine("***** MENU *****");
                Console.WriteLine("[1]Adicionar Contato");
                Console.WriteLine("[2]Remover Contato");
                Console.WriteLine("[3]Buscar Contato");
                Console.WriteLine("[4]Imprimir Contato");
                Console.WriteLine("[5]Editar Contato");
                Console.WriteLine("[0]Sair");
                return Console.ReadLine();
            }

        }
    }
}
