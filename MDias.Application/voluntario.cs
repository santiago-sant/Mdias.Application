using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private int idProjeto;

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

        public int Id_Projeto
        {
            get { return idProjeto; }
            set { idProjeto = value; }
        }

        public bool CadastrarVoluntario()
        {
            try
            {
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "INSERT INTO voluntario (Nome, Telefone, Cpf, Endereco, Habilidade) VALUES (@Nome, @Telefone, @Cpf, @Endereco, @Habilidade)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", Nome);
                        cmd.Parameters.AddWithValue("@Telefone", Telefone);
                        cmd.Parameters.AddWithValue("@Cpf", Cpf);
                        cmd.Parameters.AddWithValue("@Endereco", Endereco);
                        cmd.Parameters.AddWithValue("@Habilidade", Habilidade);
                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
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
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "DELETE FROM voluntario WHERE Id_Voluntario = @Id_Voluntario";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id_Voluntario", Id_Voluntario);
                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir voluntário: " + ex.Message);
                return false;
            }
        }

        public static DataTable PesquisarPorNome(string nome)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conexao = new conexaoBD().conectar())
            {
                string sql = "SELECT Id_Voluntario, Nome, Cpf, Habilidade FROM voluntario WHERE Nome LIKE @nome";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public bool EditarVoluntario()
        {
            try
            {
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "UPDATE voluntario SET Nome = @Nome, Cpf = @Cpf, Habilidade = @Habilidade, Telefone = @Telefone, Endereco = @Endereco, Id_Projeto = @Id_Projeto WHERE Id_Voluntario = @Id_Voluntario";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id_Voluntario", Id_Voluntario);
                        cmd.Parameters.AddWithValue("@Nome", Nome);
                        cmd.Parameters.AddWithValue("@Telefone", Telefone);
                        cmd.Parameters.AddWithValue("@Cpf", Cpf);
                        cmd.Parameters.AddWithValue("@Endereco", Endereco);
                        cmd.Parameters.AddWithValue("@Habilidade", Habilidade);
                        cmd.Parameters.AddWithValue("@Id_Projeto", Id_Projeto);
                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
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
                    string query = "SELECT * FROM voluntario";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexaoBanco))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            adaptador.Fill(tabela);
                        }
                    }
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