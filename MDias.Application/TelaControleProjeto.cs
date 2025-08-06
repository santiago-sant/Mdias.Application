using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDias.Application
{
    public partial class TelaControleProjeto : Form
    {
        public TelaControleProjeto()
        {
            InitializeComponent();
        }

        private void CarregarProjetosPorNivel()
        {
            try
            {
                DataTable projetos;

                if (sessao.TipoUsuario == "adm")
                {
                    projetos = projeto.CarregarTodosProjetos(); // Exibe todos os projetos
                }
                else if (sessao.TipoUsuario == "lider")
                {
                    projetos = projeto.CarregarProjetosDoLider(); // Exibe só os projetos do líder logado
                }
                else
                {
                    MessageBox.Show("Tipo de usuário inválido.");
                    return;
                }

                dgvProjetos.Columns.Clear();
                dgvProjetos.DataSource = null;
                dgvProjetos.AutoGenerateColumns = false;

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "ID",
                    Name = "Id_Projeto",
                    DataPropertyName = "Id_Projeto"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Nome",
                    Name = "Nome",
                    DataPropertyName = "Nome"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Endereço",
                    Name = "Endereco",
                    DataPropertyName = "Endereco"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Data de Realização",
                    Name = "Data_Realizacao",
                    DataPropertyName = "Data_Realizacao",
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "ID do Líder",
                    Name = "Id_Lider",
                    DataPropertyName = "Id_Lider"
                });

                dgvProjetos.DataSource = projetos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar projetos: " + ex.Message);
            }
        }

        private void dgvVoluntários_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaVoluntario telaVoluntario = new TelaVoluntario();
            telaVoluntario.Show();
            this.Close();
        }

        private void editarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleProjeto telaControleProjeto = new TelaControleProjeto();
            telaControleProjeto.Show();
            this.Close();
        }

        private void editarVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleVoluntario telaControleVoluntario = new TelaControleVoluntario();
            telaControleVoluntario.Show();
            this.Close();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaProjeto telaProjeto = new TelaProjeto();
            telaProjeto.Show();
            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLíder telaLider = new TelaLíder();
            telaLider.Show();
            this.Close();
        }

        private void editarLIderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleLider telaControleLider = new TelaControleLider();
            telaControleLider.Show();
            this.Close();
        }

        private void TelaControleProjeto_Load(object sender, EventArgs e)
        {
            CarregarProjetosPorNivel();
        }
    }
}