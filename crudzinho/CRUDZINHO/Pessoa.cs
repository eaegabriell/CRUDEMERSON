using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUDZINHO
{
    class Pessoa
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string datadenascimento { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\Desktop\CRUDZINHO\CRUDZINHO\DbPessoa.mdf;Integrated Security=True");

        public List<Pessoa> listapessoas()
            List<Pessoa> li = new List<Pessoa>();
            string sql = "SELECT * FROM Pessoa";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pessoa p = new Pessoa();
                p.Id = (int)dr["Id"];
                p.nome = dr["nome"].ToString();
                p.celular = dr["celular"].ToString();
                p.email = dr["email"].ToString();
                p.datadenascimento = dr["datadenascimento"].ToString();
                li.Add(p);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public void Inserir(string nome, string celular, string email, string datadenascimento)
        {
            string sql = "INSERT INTO Pessoa(nome,celular,email,datadenascimento) VALUES ('"+nome+"','"+celular+ "','" + email + "','" + datadenascimento + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
           
        }
        public void Atualizar(int Id, string nome,string celular, string email, string datadenascimento)
        {
            string sql = "UPDATE Pessoa SET nome='" + nome + "','" + celular + "','" + email + "','" + datadenascimento + "' WHERE Id= '" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Pessoa WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Pessoa WHERE Id='"+Id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                celular = dr["celular"].ToString();
                email = dr["email"].ToString();
                datadenascimento = dr["datadenascimento"].ToString();
            }
            dr.Close();
            con.Close();
        }
    }
}
