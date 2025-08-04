using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

          

namespace MDias.Application
{
    internal class conexaoBD
    {
        private string conexaoBanco = "Server=localhost;Database=MelhoresDias;Uid=root;Pwd=23041975;";

        public MySqlConnection conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);
            conexao.Open();
            return conexao;
        }
    }
}
