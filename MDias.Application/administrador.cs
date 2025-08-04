using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MDias.Application
{
    internal class administrador
    {
        private int id;
        private string nome;
        private string senha;

        public int Id_Administrador
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public bool cadastrarAdm()
        {
            try
            {
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "INSERT INTO administrador (Nome, Senha) VALUES (@Nome, @Senha)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", Nome);
                        cmd.Parameters.AddWithValue("@Senha", CriptografarSenha(Senha));
                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                    
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar líder: " + ex.Message);
                return false;
            }
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
                throw new Exception("Erro ao criptografar senha: " + ex.Message);
            }
        }

        public int? verificarAdm()
        {
            try
            {
                
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string senhaCriptografada = CriptografarSenha(Senha);

                    string query = "SELECT * FROM administrador WHERE Nome = @Nome AND Senha = @Senha";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Nome", Nome);
                        comando.Parameters.AddWithValue("@Senha", senhaCriptografada);
                        object result = comando.ExecuteScalar(); // retorna o primeiro valor encontrado

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar usuário: " + ex.Message);
            }
            return null; // login inválido
        }
    }
}