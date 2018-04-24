using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPratica
{
    class Pagina
    {
        private string texto;

        public string Texto
        {
            get
            {
                return this.texto;
            }
            set
            {
                if (value == null)
                    throw new Exception("Impossivel ser nulo!");

                this.texto = value;
            }
        }

        public Pagina(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new Exception("Página sem texto!!");

            this.texto = texto;
        }

        public override string ToString()
        {
            string ret = this.texto;

            return ret;
        }

        public override int GetHashCode()
        {
            int ret = 40;

            ret = ret * 7 + this.texto.GetHashCode();

            return ret;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            if (obj == null)
                return false;

            if (!(obj is Pagina))
                return false;

            Pagina aluninho = (Pagina)obj;

            if (!this.texto.Equals(aluninho.texto))
                return false;

            return true;
        }
    }
}
