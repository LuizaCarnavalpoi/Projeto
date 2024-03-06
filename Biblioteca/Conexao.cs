using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public static class Conexao
    {
        public static SqlConnection conn;
        public static string conexao =
             @"Data Source=SJC0637877W10-1;
                Initial Catalog = Biblioteca_ze;
                User Id = sa;
                Password = Senac123";

        public static void Conectar()
        {
            conn = new SqlConnection(conexao);
            conn.Open();
        }

        public static void Fechar()
        {
            conn.Close();
        }

    }
}

    

