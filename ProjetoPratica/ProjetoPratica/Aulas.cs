using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPratica
{
    class Aulas
    {
        static string cs = ProjetoPratica.Properties.Settings.Default.BDPRII17178ConnectionString;

        public static String[] GetAulas(string materia)
        {
            SqlConnection con = new SqlConnection();
            cs = cs.Substring(cs.IndexOf("Data Source"));
            con.ConnectionString = cs;

            SqlCommand cmd = new SqlCommand("Select titulo from aula where materia = @materia",con);
            cmd.Parameters.AddWithValue("@materia", materia);

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapt.Fill(ds);
            con.Close();
            DataRow dr;
            String[] ret = new String[ds.Tables[0].Rows.Count];

            if(ds.Tables[0].Rows.Count != 0)
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dr = ds.Tables[0].Rows[i];
                    ret[i] = dr.ItemArray[0].ToString();
                }

            return ret;
        }

        public static Aula GetAula (string titulo)
        {
            SqlConnection con = new SqlConnection();
            cs = cs.Substring(cs.IndexOf("Data Source"));
            con.ConnectionString = cs;

            SqlCommand cmd;
            SqlDataAdapter adapt;
            DataSet ds = new DataSet();
            DataRow dr;

            cmd = new SqlCommand("Select texto from paginaAula where aula = @aula", con);
            cmd.Parameters.AddWithValue("@aula", titulo);

            con.Open();
            adapt = new SqlDataAdapter(cmd);

            adapt.Fill(ds);
            con.Close();
            Pagina[] pag = new Pagina[ds.Tables[0].Rows.Count];

            for (int i = 0; i <= ds.Tables[0].Rows.Count; i++)
            {
                dr = ds.Tables[0].Rows[i];
                pag[i] = new Pagina(dr.ItemArray[0].ToString());
            }

            cmd = new SqlCommand("Select * from aula where titulo = @titulo", con);
            cmd.Parameters.AddWithValue("@titulo", titulo);

            con.Open();
            adapt = new SqlDataAdapter(cmd);

            adapt.Fill(ds);
            con.Close();
            Aula ret;

            if (ds.Tables[0].Rows.Count == 1)
            {
                dr = ds.Tables[0].Rows[1];
                ret = new Aula(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), pag);
            }
            else
                throw new Exception("Aula inexistente");

            return ret;
        }

        public static void AddAula(Aula nova)
        {
            SqlConnection con = new SqlConnection();
            cs = cs.Substring(cs.IndexOf("Data Source"));
            con.ConnectionString = cs;

            SqlCommand cmd = new SqlCommand("Insert into aula values(@titulo, @professor, @materia)", con);
            cmd.Parameters.AddWithValue("@titulo", nova.Titulo);
            cmd.Parameters.AddWithValue("@professor", nova.Professor);
            cmd.Parameters.AddWithValue("@materia", nova.Materia);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
