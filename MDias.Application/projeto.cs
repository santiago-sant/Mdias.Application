using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDias.Application
{
    internal class projeto
    {
        private int id;
        private string nome;
        private string endereco;
        private DateTime dataRealizacao;

        public int Id_Projeto
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public DateTime Data_Realizacao
        {
            get { return dataRealizacao; }
            set { dataRealizacao = value; }
        }

        public bool CadastrarProjeto()
        {
            try
            {
                using MySqlConnection conexao = new conexaoBD().conectar();
                string query = "INSERT INTO projeto (nome, endereco, data_realizacao) VALUES (@nome, @endereco, @data_realizacao)";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@data_realizacao", dataRealizacao);
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar projeto: " + ex.Message);
                return false;
            }
        }

        public bool ExcluirProjeto()
        {
            try
            {
                using MySqlConnection conexao = new conexaoBD().conectar();
                string query = "DELETE FROM projeto WHERE id_projeto = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir projeto: " + ex.Message);
                return false;
            }
        }

        public bool AtualizarProjeto()
        {
            try
            {
                using MySqlConnection conexao = new conexaoBD().conectar();
                string query = "UPDATE projeto SET nome = @nome, endereco = @endereco, data_realizacao = @data_realizacao WHERE id_projeto = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@data_realizacao", dataRealizacao);
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar projeto: " + ex.Message);
                return false;
            }
        }

        public static DataTable CarregarProjetosDoLider()
        {
            DataTable tabela = new DataTable();
            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().conectar())
                {
                    string listar = "SELECT * FROM projeto WHERE id_lider = @idLider";
                    MySqlCommand comando = new MySqlCommand(listar, conexaoBanco);
                    comando.Parameters.AddWithValue("@idLider", sessao.IdLiderLogado);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os projetos: " + ex.Message);
                throw;
            }
            return tabela;
        }

        public static DataTable CarregarTodosProjetos()
        {
            DataTable tabela = new DataTable();
            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().conectar())
                {
                    string query = "SELECT * FROM projeto";
                    MySqlCommand comando = new MySqlCommand(query, conexaoBanco);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os projetos: " + ex.Message);
                throw;
            }
            return tabela;
        }
    }
}