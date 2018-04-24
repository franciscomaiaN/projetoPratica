using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoPratica
{
    public static class Alunos
    {
        static string cs = ProjetoPratica.Properties.Settings.Default.BDPRII17178ConnectionString;

        public static void Cadastrar(Aluno aluno)
        {
            SqlConnection con = new SqlConnection();
            cs = cs.Substring(cs.IndexOf("Data Source"));
            con.ConnectionString = cs;

            SqlCommand cmd = new SqlCommand("Insert into aluno values(@user, @nome, @senha, @idade)", con);
            cmd.Parameters.AddWithValue("@user", aluno.Usuario);
            cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@senha", aluno.Senha);
            cmd.Parameters.AddWithValue("@idade", aluno.Idade);
                
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static Aluno Logar(string usuario, string senha)
        {
            Aluno ret;

            SqlConnection con = new SqlConnection();
            cs = cs.Substring(cs.IndexOf("Data Source"));
            con.ConnectionString = cs;

            SqlCommand cmd = new SqlCommand("Select * from aluno where usuario = @user and senha = @senha", con);
            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapt.Fill(ds);
            con.Close();

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                ret = new Aluno(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), Convert.ToInt32(dr.ItemArray[3]));
            }
            else
                throw new Exception("Usuário não existente\nou senha incorreta");

            return ret;
        }

    }
}