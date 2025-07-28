using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MDias.Application
{
    internal class lider
    {
        private int id;
        private string nome;
        private string endereco;
        private string senha;
        private string telefone;
        private string cpf;

        public int Id_Lider
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

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public static string CriptografarSenha(string Senha)
        {
            try
            {
                using (var sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criptografar senha: " + ex.Message);
                throw;
            }
        }

        public bool cadastrarLider()
        {
            try
            {
                string senhaCriptografada = CriptografarSenha(Senha);
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "INSERT INTO lider (Nome, Telefone,Endereco,Cpf, Senha) VALUES (@Nome, @Telefone, @Endereco,@Cpf, @Senha)";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Telefone", Telefone);
                    comando.Parameters.AddWithValue("@Senha", senhaCriptografada);
                    comando.Parameters.AddWithValue("@Endereco", Endereco);
                    comando.Parameters.AddWithValue("@Cpf", Cpf);
                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                return false;
            }
        }

        public bool DesativarLider(int Id_Lider)
        {
            try
            {
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "UPDATE lider SET ativo = 0 WHERE id = @Id";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", Id_Lider);

                    int linhasAfetadas = comando.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao desativar líder: " + ex.Message);
                return false;
            }
        }

        public bool ReativarLider(int Id_Lider)
        {
            try
            {
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "UPDATE lider SET ativo = 1 WHERE id = @Id";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", Id_Lider);

                    int linhasAfetadas = comando.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao reativar líder: " + ex.Message);
                return false;
            }
        }

        public int? verificarLider()
        {
            try
            {
                string senhaCriptografada = CriptografarSenha(Senha);
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "SELECT id FROM lider WHERE Nome=@Nome AND Senha=@Senha AND ativo=1";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Senha", senhaCriptografada);

                    object result = comando.ExecuteScalar();

                    if (result != null)
                        return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar líder: " + ex.Message);
            }

            return null;
        }

        public static DataTable ListarLider()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().conectar())
                {
                    string query = "SELECT * FROM lider";
                    MySqlCommand cmd = new MySqlCommand(query, conexaoBanco);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar lider: " + ex.Message);
                throw;
            }
            return tabela;
        }
    }
}