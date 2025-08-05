using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MDias.Application
{
    public partial class TelaControleVoluntario : Form
    {
        public TelaControleVoluntario()
        {
            InitializeComponent();
        }

        private void CarregarVoluntariosComProjetos()
        {
            try
            {
                DataTable voluntarios = voluntario.ListarVoluntarios();
                DataTable projetos = projeto.CarregarProjetosDoLider();

                dgvVoluntario.Columns.Clear();
                dgvVoluntario.DataSource = null;
                dgvVoluntario.AutoGenerateColumns = false;

                // Colunas fixas
                dgvVoluntario.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Id_Voluntario",
                    HeaderText = "ID",
                    Name = "Id_Voluntario"
                });

                dgvVoluntario.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nome",
                    HeaderText = "Nome",
                    Name = "Nome"
                });

                dgvVoluntario.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Cpf",
                    HeaderText = "CPF",
                    Name = "Cpf"
                });

                dgvVoluntario.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Habilidade",
                    HeaderText = "Habilidade",
                    Name = "Habilidade"
                });

                // Coluna ComboBox com os projetos
                DataGridViewComboBoxColumn comboProjetos = new DataGridViewComboBoxColumn()
                {
                    HeaderText = "Projeto",
                    Name = "Projeto",
                    DataSource = projetos,
                    DisplayMember = "Nome",
                    ValueMember = "Id_Projeto",
                    FlatStyle = FlatStyle.Flat
                };

                dgvVoluntario.Columns.Add(comboProjetos);

                // Definir fonte de dados
                dgvVoluntario.DataSource = voluntarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaVoluntario telaVolutario = new TelaVoluntario();
            telaVolutario.Show();
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

        private void editarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleProjeto telaControleProjeto = new TelaControleProjeto();
            telaControleProjeto.Show();
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

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void formTheme1_Click(object sender, EventArgs e)
        {
        }

        private void TelaControleVoluntario_Load(object sender, EventArgs e)
        {
            CarregarVoluntariosComProjetos();
        }

        private void dgvVoluntario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVoluntario.Columns[e.ColumnIndex].Name == "Projeto")
            {
                int idVoluntario = Convert.ToInt32(dgvVoluntario.Rows[e.RowIndex].Cells["Id_Voluntario"].Value);
                object projetoSelecionado = dgvVoluntario.Rows[e.RowIndex].Cells["Projeto"].Value;

                if (projetoSelecionado != null)
                {
                    int idProjeto = Convert.ToInt32(projetoSelecionado);

                    bool sucesso = Participante.SalvarParticipante(idVoluntario, idProjeto); // exemplo de classe
                    if (sucesso)
                        MessageBox.Show("Voluntário associado com sucesso!");
                    else
                        MessageBox.Show("Não foi possível associar (já existe ou ocorreu erro).");
                }
            }
        }
    }
}