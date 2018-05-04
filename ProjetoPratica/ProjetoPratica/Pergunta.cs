using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPratica
{
    class Pergunta
    {
        private string textoPergunta;
        private string alternativaA;
        private string alternativaB;
        private string alternativaC;
        private string alternativaD;
        private char certa;

        public Pergunta(string texto, string a, string b, string c, string d, char certo)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new Exception("Pergunta nula!");

            if (string.IsNullOrWhiteSpace(a))
                throw new Exception("Alternativa nula!");

            if (string.IsNullOrWhiteSpace(b))
                throw new Exception("Alternativa nula!");

            if (string.IsNullOrWhiteSpace(c))
                throw new Exception("Alternativa nula!");

            if (string.IsNullOrWhiteSpace(d))
                throw new Exception("Alternativa nula!");

            if (certo != 'A' && certo != 'B' && certo != 'C' && certo != 'D')
                throw new Exception("Resposta invalida!");

            this.textoPergunta = texto;
            this.alternativaA = a;
            this.alternativaB = b;
            this.alternativaC = c;
            this.alternativaD = d;
            this.certa = certo;
        }

        public string TextoAlternativa
        {
            get
            {
                return this.textoPergunta;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Impossivel ser nulo!");
                this.textoPergunta = value;
            }
        }

        public string AlternativaA
        {
            get
            {
                return this.alternativaA;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Impossivel ser nulo!");
                this.alternativaA = value;
            }
        }

        public string AlternativaB
        {
            get
            {
                return this.alternativaB;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Impossivel ser nulo!");
                this.alternativaB = value;
            }
        }

        public string AlternativaC
        {
            get
            {
                return this.alternativaC;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Impossivel ser nulo!");
                this.alternativaC = value;
            }
        }

        public string AlternativaD
        {
            get
            {
                return this.alternativaD;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Impossivel ser nulo!");
                this.alternativaD = value;
            }
        }

        public char Certa
        {
            get
            {
                return this.certa;
            }
            set
            {
                if (value != 'A' && value != 'B' && value != 'C' && value != 'D')
                    throw new Exception("Valor invalido!");
                this.certa = value;
            }
        }

    }
}
