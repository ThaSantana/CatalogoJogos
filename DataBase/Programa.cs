using System;

namespace DataBase
{
    public class Programa
    {
        private string sqlConn()
        {
            return ConfigurationManager.AppSettings["SqlConn"];
        }

        public DataTable Lista()
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string queryString = "select * from paginas";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                
            }
        }

        public void Salvar(int id, string nome, string Genero)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string queryString = "insert into programa(nome,genero) values ('" + nome + "','" + Genero + "')";
                if (id != 0)
                {
                    queryString = "update programa set nome'" + nome +  "'genero='" + Genero + "' where id=" + id;
                }
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();



            }
        }
    }

}

