using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPratica
{
    public class Professor
    {
        private string usuario;
        private string senha;
        private string nome;

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                if (value == null)
                    throw new Exception("Impossivel ser nulo!");

                this.usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return this.senha;
            }
            set
            {
                if (value == null)
                    throw new Exception("Impossivel ser nulo!");

                this.senha = value;
            }
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                if (value == null)
                    throw new Exception("Impossivel ser nulo!");

                this.nome = value;
            }
        }

        public Professor(string usuario, string senha, string nome)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                throw new Exception("Usuário não digitado!!");
            if (string.IsNullOrWhiteSpace(senha))
                throw new Exception("Senha não digitada!!");

            this.usuario = usuario;
            this.senha = senha;
            this.nome = nome;
        }

        public override string ToString()
        {
            string ret = "Professor:" + this.Usuario;

            return ret;
        }

        public override int GetHashCode()
        {
            int ret = 44;

            ret = ret * 7 + this.usuario.GetHashCode();
            ret = ret * 7 + this.senha.GetHashCode();
            ret = ret * 7 + this.nome.GetHashCode();

            return ret;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            if (obj == null)
                return false;

            if (!(obj is Professor))
                return false;

            Professor prof = (Professor)obj;

            if (!this.usuario.Equals(prof.usuario))
                return false;

            return true;
        }

    }
}
