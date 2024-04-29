using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_contatos_tessete
{
    internal class contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        //propriedades (get a set)
        //é um controle de acesso as variaveis
        public string Nome
        {
            get
            {
                return nome;
            }
            set 
            {
                nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set 
            {
            sobrenome = value;
            }
        }
        public string Telefone
        {
            get 
            { 
                return telefone;
            }
            set
            {
                if (telefone.Length == 11) 
                {
                    telefone = value;
                }
                else 
                {
                    //País-cidade-telefone, ex: =55-11-97878-8787
                    telefone = "00-00000-0000";
                }
            }
        }

        public contato() 
        {
            Nome = "deide";
            Sobrenome = "Costa";
            Telefone = "11-40028-9225";
        }

        public contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += String.Format("(+) {1}-{2}", Telefone.Substring(0,2), Telefone.Substring(2,5),
              Telefone.Substring(7,4) );
            return saida;
        }
    }
}
