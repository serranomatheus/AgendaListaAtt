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
            if (Vazio())
            {
                Console.WriteLine("Agenda vazia");
            }
            else
            {
                Contato aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
            }
        }
        public void Sort()
        {
            Contato aux = new Contato(null,null,null);
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
