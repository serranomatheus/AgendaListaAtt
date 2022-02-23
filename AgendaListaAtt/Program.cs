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
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                Console.WriteLine("Tipo");
                string tipo = Console.ReadLine();
                Console.WriteLine("Ddd");
                string ddd = Console.ReadLine();
                Console.WriteLine("Numero");
                string numero = Console.ReadLine();
                Console.WriteLine("sair");
                opc = Console.ReadLine();
                agenda.Push(new Contato(nome, email, new Telefone(tipo, ddd, numero)));
            } while (opc != "0");
            agenda.Print();
        
        
        }
    }
}
