using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendasimples_t5
{
    internal class contato
    {
        // Variaveis locais da classe Contato.
        // Acessiveis apenas pela classe Contato.
        private string primeiroNome;
        private string sobrenome;
        private string telefone;
        // PROPRIEDADES da classe Contato.
        // Acessíveis por qualquer parte desse programa.
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "00-00000-0000";
                }
            }
        }
        // Construtor da classe.
        public Contato()
        {
            PrimeiroNome = "João";
            Sobrenome = "Da Silva";
            Telefone = "11-98888-8776";
        }
        // Sobrecarga de método.
        public Contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
    }
}
public 
    public override string to string 
    string saida = string format `0 