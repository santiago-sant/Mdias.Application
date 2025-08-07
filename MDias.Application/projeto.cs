using MySql.Data.MySqlClient;
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
                using (MySqlConnection Conexao = new conexaoBD().conectar())
                {
                    string Query = "INSERT INTO projeto (Nome, Endereco, Data_Realizacao,Id_Lider) VALUES (@Nome, @Endereco, @Data_Realizacao,@Id_Lider)";

                    using (MySqlCommand Cmd = new MySqlCommand(Query, Conexao))
                    {
                        Cmd.Parameters.AddWithValue("@Nome", Nome);
                        Cmd.Parameters.AddWithValue("@Endereco", Endereco);
                        Cmd.Parameters.AddWithValue("@Data_Realizacao", Data_Realizacao);
                        Cmd.Parameters.AddWithValue("@Id_Lider", sessao.IdLogado);
                        int Resultado = Cmd.ExecuteNonQuery();
                        return Resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar projeto: " + ex.Message);
                return false;
            }
        }

        public static DataTable PesquisarProjetosPorNome(string nome)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conexao = new conexaoBD().conectar())
            {
                string sql = "SELECT Id_Projeto, Nome, Endereco, Data_Realizacao FROM projeto WHERE Nome LIKE @nome";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");  // '%' permite pesquisa parcial no nome

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);  // Preenche o DataTable com os resultados da consulta
                    }
                }
            }

            return dt;
        }

        public bool ExcluirProjeto()
        {
            try
            {
                using (MySqlConnection Conexao = new conexaoBD().conectar())
                {
                    string Query = "DELETE FROM projeto WHERE Id_Projeto = @Id_Projeto";

                    using (MySqlCommand cmd = new MySqlCommand(Query, Conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id_Projeto", Id_Projeto);
                        int Resultado = cmd.ExecuteNonQuery();
                        return Resultado > 0;
                    }
                }
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
                using (MySqlConnection Conexao = new conexaoBD().conectar())
                {
                    string Query = "UPDATE projeto SET Nome = @Nome, Endereco = @Endereco, Data_Realizacao = @Data_Realizacao WHERE Id_Projeto = @Id_Projeto";

                    using (MySqlCommand cmd = new MySqlCommand(Query, Conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id_Projeto", Id_Projeto);
                        cmd.Parameters.AddWithValue("@Nome", Nome);
                        cmd.Parameters.AddWithValue("@Endereco", Endereco);
                        cmd.Parameters.AddWithValue("@Data_Realizacao", Data_Realizacao);
                        int Resultado = cmd.ExecuteNonQuery();
                        return Resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar projeto: " + ex.Message);
                return false;
            }
        }

        public static DataTable CarregarProjetosDoLider()
        {
            DataTable Tabela = new DataTable();
            try
            {
                using (MySqlConnection ConexaoBanco = new conexaoBD().conectar())
                {
                    string Query = "SELECT * FROM projeto WHERE Id_Lider = @Id_Lider";

                    using (MySqlCommand Cmd = new MySqlCommand(Query, ConexaoBanco))
                    {
                        Cmd.Parameters.AddWithValue("@Id_Lider", sessao.IdLogado);

                        using (MySqlDataAdapter Adaptador = new MySqlDataAdapter(Cmd))
                        {
                            Adaptador.Fill(Tabela);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os projetos: " + ex.Message);
                throw;
            }
            return Tabela;
        }

        public static DataTable CarregarTodosProjetos()
        {
            DataTable Tabela = new DataTable();
            try
            {
                using (MySqlConnection ConexaoBanco = new conexaoBD().conectar())
                {
                    string Query = "SELECT * FROM projeto";

                    using (MySqlCommand Cmd = new MySqlCommand(Query, ConexaoBanco))
                    {
                        using (MySqlDataAdapter Adaptador = new MySqlDataAdapter(Cmd))
                        {
                            Adaptador.Fill(Tabela);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os projetos: " + ex.Message);
                throw;
            }
            return Tabela;
        }
    }
}