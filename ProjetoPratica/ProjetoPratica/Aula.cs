using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPratica
{
    class Aula
    {
        private string professor;
        private string materia;
        private Pagina[] paginas;
        private string titulo;

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }

        public string Professor
        {
            get
            {
                return this.professor;
            }
            set
            {
                if (value == null)
                    throw new Exception("Impossivel ser nulo!");

                this.professor = value;
            }
        }

        public string Materia
        {
            get
            {
                return this.materia;
            }
            set
            {
                if (value == null)
                    throw new Exception("Impossivel ser nulo!");

                this.materia = value;
            }
        }

        public Pagina[] Paginas
        {
            get
            {
                return this.paginas;
            }
            set
            {
                if (value == null)
                    throw new Exception("Impossivel ser nulo!");
                this.paginas = value;
            }
        }

        public Aula(string titulo, string prof, string materia, Pagina[] paginas)
        {
            if (prof == null)
                throw new Exception("Professor nulo!");

            if (string.IsNullOrWhiteSpace(materia))
                throw new Exception("Nome não digitado!!");

            if (paginas == null)
                throw new Exception("Paginas nulas!!");

            this.titulo = titulo;
            this.professor = prof;
            this.materia = materia;
            this.paginas = paginas;
        }

/*      public override string ToString()
        {
            string ret = "Nome:" + this.Nome + "\nIdade:" + this.Idade;

            return ret;
        }

        public override int GetHashCode()
        {
            int ret = 40;

            ret = ret * 7 + this.idade.GetHashCode();
            ret = ret * 7 + this.nome.GetHashCode();
            ret = ret * 7 + this.senha.GetHashCode();
            ret = ret * 7 + this.usuario.GetHashCode();

            return ret;
        }*/

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            if (obj == null)
                return false;

            if (!(obj is Aula))
                return false;

            Aula aluninho = (Aula)obj;

            if (!this.titulo.Equals(aluninho.titulo))
                return false;

            return true;
        }
    }
}