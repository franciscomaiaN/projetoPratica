using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPratica
{
    public class Aluno
    {
        private string usuario;
        private string nome;
        private string senha;
        private int idade;

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

        public int Idade
        {
            get
            {
                return this.idade;
            }
            set
            {
                this.idade = value;
            }
        }

        public Aluno(string usuario, string nome, string senha, int idade)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                throw new Exception("Usuário não digitado!!");

            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome não digitado!!");

            if (string.IsNullOrWhiteSpace(senha))
                throw new Exception("Senha não digitada!!");

            this.usuario = usuario;
            this.nome = nome;
            this.senha = senha;
            this.idade = idade;
        }

        public override string ToString()
        {
            string ret = "Nome:" + this.Nome+"\nIdade:"+ this.Idade;

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
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            if (obj == null)
                return false;

            if (!(obj is Aluno))
                return false;

            Aluno aluninho = (Aluno)obj;

            if (!this.usuario.Equals(aluninho.usuario))
                return false;

            return true;
        }
    }
}
