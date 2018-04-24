using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPratica
{
    public static class Professores
    {
        static string cs = ProjetoPratica.Properties.Settings.Default.BDPRII17178ConnectionString;
        public static Professor Logar(string usuario, string senha)
        {      
            Professor ret;
            try
            {
                SqlConnection con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;

                SqlCommand cmd = new SqlCommand("Select * from professor where usuario = @user and senha = @senha", con);
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
                    ret = new Professor(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString());
                }
                else
                    throw new Exception("Usuário não existente\nou senha incorreta");

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            return ret;
        }
    }
}
