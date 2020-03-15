﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSCGADominio.Entidades
{
   public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
         }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarErro(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public string ObterMensagensValidacao()
        {
            return string.Join(". ", MensagemValidacao);
        }

        public abstract void Validate(); 

        public bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
