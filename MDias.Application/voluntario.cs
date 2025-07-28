using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDias.Application
{
    internal class voluntario
    {
        private int id;
        private string nome;
        private string telefone;
        private string cpf;
        private string endereco;
        private string habilidade;

        public int Id_Voluntario
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Habilidade
        {
            get { return habilidade; }
            set { habilidade = value; }
        }

        public bool CadastrarVoluntario()
        {
            try
            {
                using MySqlConnection conexao = new conexaoBD().conectar();
                string query = "INSERT INTO voluntario (nome, telefone, cpf, endereco, habilidade) VALUES (@nome, @telefone, @cpf, @endereco, @habilidade)";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@habilidade", habilidade);
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar voluntário: " + ex.Message);
                return false;
            }
        }

        public bool ExcluirVoluntario()
        {
            try
            {
                using MySqlConnection conexao = new conexaoBD().conectar();
                string query = "DELETE FROM voluntario WHERE Id_Voluntario = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir voluntário: " + ex.Message);
                return false;
            }
        }

        public bool EditarVoluntario()
        {
            try
            {
                using MySqlConnection conexao = new conexaoBD().conectar();
                string query = "UPDATE voluntario SET nome = @nome, telefone = @telefone, cpf = @cpf, endereco = @endereco, habilidade = @habilidade WHERE Id_Voluntario = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@habilidade", habilidade);
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar voluntário: " + ex.Message);
                return false;
            }
        }

        public static DataTable ListarVoluntarios()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().conectar())
                {
                    string query = "SELECT * FROM voluntarios";
                    MySqlCommand cmd = new MySqlCommand(query, conexaoBanco);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar voluntários: " + ex.Message);
                throw;
            }
            return tabela;
        }
    }
}
