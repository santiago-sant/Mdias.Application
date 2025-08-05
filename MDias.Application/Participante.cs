using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDias.Application
{
    internal class Participante
    {
        private int idVoluntario;
        private int idProjeto;

        public int Id_Voluntario
        {
            get { return idVoluntario; }
            set { idVoluntario = value; }
        }

        public int Id_Projeto
        {
            get { return idProjeto; }
            set { idProjeto = value; }
        }

        public static bool SalvarParticipante(int idVoluntario, int idProjeto)
        {
            try
            {
                using (MySqlConnection conexao = new conexaoBD().conectar())
                {
                    string query = "INSERT IGNORE INTO participantes (Id_Voluntario, Id_Projeto) VALUES (@idVoluntario, @idProjeto)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idVoluntario", idVoluntario);
                        cmd.Parameters.AddWithValue("@idProjeto", idProjeto);
                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar participante: " + ex.Message);
                return false;
            }
        }
    }
}