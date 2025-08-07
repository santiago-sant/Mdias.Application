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

                // Verifica tipo de usuário (Adm ou Lider)
                DataTable projetos;
                if (sessao.TipoUsuario == "Adm")
                {
                    projetos = projeto.CarregarTodosProjetos();
                }
                else
                {
                    projetos = projeto.CarregarProjetosDoLider();
                }

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

                dgvVoluntario.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Telefone",
                    HeaderText = "Telefone",
                    Name = "Telefone"
                });

                dgvVoluntario.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Endereco",
                    HeaderText = "Endereço",
                    Name = "Endereco"
                });

                // Coluna ComboBox com os projetos
                DataGridViewComboBoxColumn comboProjetos = new DataGridViewComboBoxColumn()
                {
                    HeaderText = "Projeto",
                    Name = "Projeto",
                    DataPropertyName = "Id_Projeto", // <- certifique-se que essa coluna está vindo no SELECT
                    DataSource = projetos,
                    DisplayMember = "Nome",
                    ValueMember = "Id_Projeto",
                    FlatStyle = FlatStyle.Flat
                };

                dgvVoluntario.Columns.Add(comboProjetos);

                // Botão Excluir
                dgvVoluntario.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Excluir",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true,
                    Name = "Excluir"
                });

                // Botão Editar
                dgvVoluntario.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Name = "Editar"
                });

                // Define a fonte de dados
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



        private void formTheme1_Click(object sender, EventArgs e)
        {
        }

        private void TelaControleVoluntario_Load(object sender, EventArgs e)
        {
            CarregarVoluntariosComProjetos();
        }

        private void dgvVoluntario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvVoluntario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se clicou em uma célula de botão e em uma linha válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgvVoluntario.Columns[e.ColumnIndex].Name;

                // ID do voluntário
                int idVoluntario = Convert.ToInt32(dgvVoluntario.Rows[e.RowIndex].Cells["Id_Voluntario"].Value);

                // === Botão EXCLUIR ===
                if (columnName == "Excluir")
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este voluntário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        voluntario Voluntario = new voluntario();
                        Voluntario.Id_Voluntario = idVoluntario;

                        bool sucesso = Voluntario.ExcluirVoluntario();
                        if (sucesso)
                        {
                            MessageBox.Show("Voluntário excluído com sucesso!");
                            CarregarVoluntariosComProjetos();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir voluntário.");
                        }
                    }
                }

                // === Botão EDITAR ===
                else if (columnName == "Editar")
                {
                    try
                    {
                        // Lê os valores da linha atualizada
                        string nome = dgvVoluntario.Rows[e.RowIndex].Cells["Nome"].Value?.ToString();
                        string cpf = dgvVoluntario.Rows[e.RowIndex].Cells["Cpf"].Value?.ToString();
                        string habilidade = dgvVoluntario.Rows[e.RowIndex].Cells["Habilidade"].Value?.ToString();
                        string telefone = dgvVoluntario.Rows[e.RowIndex].Cells["Telefone"].Value?.ToString();
                        string endereco = dgvVoluntario.Rows[e.RowIndex].Cells["Endereco"].Value?.ToString();

                        // --- Lê o Projeto (ComboBox) ---
                        object projetoSelecionado = dgvVoluntario.Rows[e.RowIndex].Cells["Projeto"].Value;
                        int idProjeto = 0;
                        if (projetoSelecionado != null)
                            idProjeto = Convert.ToInt32(projetoSelecionado);

                        // Monta o objeto Voluntario
                        voluntario Voluntario = new voluntario();
                        Voluntario.Id_Voluntario = idVoluntario;
                        Voluntario.Nome = nome;
                        Voluntario.Cpf = cpf;
                        Voluntario.Habilidade = habilidade;
                        Voluntario.Telefone = telefone;
                        Voluntario.Endereco = endereco;
                        Voluntario.Id_Projeto = idProjeto; // <- agora passando corretamente

                        // Atualiza no banco
                        bool sucesso = Voluntario.EditarVoluntario();

                        if (sucesso)
                        {
                            MessageBox.Show("Voluntário atualizado com sucesso!");
                            CarregarVoluntariosComProjetos(); // Recarrega a grid
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar voluntário.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro na edição: " + ex.Message);
                    }
                }

            }
        }

        private void dgvVoluntario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}