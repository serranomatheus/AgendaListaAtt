﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaListaAtt
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        
        public Telefone Telefones { get; set; }
        public Contato Proximo { get; set; }
        public Contato Anterior { get; set; }

        public Contato(string nome, string email, Telefone telefones)
        {
            Nome = nome;
            Email = email;
           
            Telefones = telefones;
            Proximo = null;
            Anterior = null;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + "\nEmail:" +Email+ "\n" + Telefones;
        }
    }
}
