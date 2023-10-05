using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_2023.DAL
{
    internal class UtilsDAL
    {
        // MÉTODO QUE REALIZA A CONEXÃO COM O BANCO DE DADOS
        public static MySqlConnection GetConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cad_usuario",
                UserID = "root",
                Password = ""
            };

            // CRIAR CONEXÃO COM O BANCO DE DADOS
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            conn.Open(); // ABRE UMA CONEXÃO
            return conn;
        }
    }
}
