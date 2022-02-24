using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaListaAtt
{
    internal class Agenda
    {
        public Contato Head { get; set; }
        public Contato Tail { get; set; }
        public int Quantidade { get; set; }

        public Agenda()
        {
            Head = null;
            Tail = null;
        }

        public void Pop(Contato contato)
        {
            if(contato.Nome == Head.Nome)
            {
                Head = Head.Proximo;
            }
            else
            {
                Contato aux = Head;
                Contato aux1 = Head.Proximo;
                for(int i = 0; i < Quantidade; i++)
                {
                    if(string.Compare(contato.Nome, aux1.Nome) == 0)
                    {
                        aux.Proximo = aux1.Proximo;
                        if(aux1.Proximo == null)
                        {
                            Tail = aux;
                        }
                    }
                    else
                        aux = aux1;
                        aux1 = aux1.Proximo;
                }
            }
        }
        public bool Vazio()
        {
            if (Head == null & Tail == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(Contato novoContato)
        {
            if (Vazio())
            {
                Head = novoContato;
                Tail = novoContato;
            }
            else
            {
                Tail.Proximo = novoContato;
                novoContato.Anterior = Tail;
                Tail = novoContato;
            }
            Sort();
        }
        public void Print()
        {
            Console.Clear();
            if (Vazio())
            {
                Console.WriteLine("************** Agenda vazia ****************");
            }
            else
            {

                Contato aux = Head;
                do
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                    Console.ReadKey();
                } while (aux != null);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("********* Fim da lista de Contatos *********");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
            Console.Clear();

        }
        public void BuscarPop()
        {
            if (Vazio())
            {
                Console.WriteLine("************** Agenda vazia ****************");
            }
        }
        public void Buscar()
        {
            Console.Clear();
            Contato aux = Head;
            bool cont = false;
            Console.Clear();
            if (Vazio())
            {
                Console.WriteLine("************** Agenda vazia ****************");
            }
            else
            {
                Console.WriteLine("Qual nome deseja buscar?");
                string nomeBuscar = Console.ReadLine();
                do
                {
                    if (aux.Nome.ToLower().Contains(nomeBuscar))
                    {
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine(aux.ToString());
                        cont = true;
                    }
                    aux = aux.Proximo;
                } while (aux != null);

                if (!cont)
                {
                    Console.WriteLine("*******  Nenhum Contato encontrado!! *******");
                }               
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
            Console.Clear();
        }
        public void Sort()
        {
            Contato aux = new Contato(null, null, null);
            for (Contato referencia = Head; referencia != null; referencia = referencia.Proximo)
            {
                for (Contato comparacao = referencia.Proximo; comparacao != null; comparacao = comparacao.Proximo)
                {
                    if (string.Compare(referencia.Nome, comparacao.Nome) > 0)
                    {
                        aux.Nome = referencia.Nome;
                        aux.Email = referencia.Email;
                        aux.Telefones = referencia.Telefones;
                        //Console.WriteLine(aux.ToString());
                        referencia.Nome = comparacao.Nome;
                        referencia.Email = comparacao.Email;
                        referencia.Telefones = comparacao.Telefones;
                        //  Console.WriteLine(referencia.ToString());
                        comparacao.Nome = aux.Nome;
                        comparacao.Email = aux.Email;
                        comparacao.Telefones = aux.Telefones;
                        //  Console.WriteLine(comparacao.ToString());

                    }
                }
            }
        }
    }
}
