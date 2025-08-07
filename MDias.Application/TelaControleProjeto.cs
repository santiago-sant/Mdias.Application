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

                dgvProjetos.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Excluir",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true,
                    Name = "Excluir"
                });

                // Botão Editar
                dgvProjetos.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Name = "Editar"
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
            // Verifica se clicou em uma célula de botão e em uma linha válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgvProjetos.Columns[e.ColumnIndex].Name;

                int idProjeto = Convert.ToInt32(dgvProjetos.Rows[e.RowIndex].Cells["Id_Projeto"].Value);

                // === Botão EXCLUIR ===
                if (columnName == "Excluir")
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este voluntário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        projeto Projeto = new projeto();
                        Projeto.Id_Projeto = idProjeto;

                        bool sucesso = Projeto.ExcluirProjeto();
                        if (sucesso)
                        {
                            MessageBox.Show("Projeto excluído com sucesso!");
                            CarregarProjetosPorNivel();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir Projeto.");
                        }
                    }
                }

                // === Botão EDITAR ===
                else if (columnName == "Editar")
                {
                    try
                    {
                        // Lê os valores da linha atualizada
                        string nome = dgvProjetos.Rows[e.RowIndex].Cells["Nome"].Value?.ToString();
                        string endereco = dgvProjetos.Rows[e.RowIndex].Cells["Endereco"].Value?.ToString();
                        string data = dgvProjetos.Rows[e.RowIndex].Cells["Data_Realizacao"].Value?.ToString();

                        // Monta o objeto Voluntario
                        projeto Projeto = new projeto();
                        Projeto.Id_Projeto = idProjeto;
                        Projeto.Nome = nome;
                        Projeto.Endereco = endereco;
                        Projeto.Data_Realizacao = DateTime.Parse(data);

                        // Atualiza no banco
                        bool sucesso = Projeto.AtualizarProjeto();

                        if (sucesso)
                        {
                            MessageBox.Show("Projeto atualizado com sucesso!");
                            CarregarProjetosPorNivel(); // Recarrega a grid
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar Projeto.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro na edição: " + ex.Message);
                    }
                }
            }
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

            if (sessao.TipoUsuario == "lider")
            {
                toolStripDropDownButton1.Visible = false; // <- aqui você oculta o item do MenuStrip
            }
        }

        private void PesquisarProjetos()
        {
            string nomeBuscado = txtBuscar.Text.Trim(); // O que foi digitado no TextBox

            if (string.IsNullOrEmpty(nomeBuscado))
            {
                CarregarProjetosPorNivel(); // Se o campo estiver vazio, carrega todos os projetos
                return;
            }

            try
            {
                // Chama a função que faz a consulta no banco
                DataTable projetos = projeto.PesquisarProjetosPorNome(nomeBuscado);

                dgvProjetos.DataSource = null;
                dgvProjetos.Rows.Clear();
                dgvProjetos.Columns.Clear();

                // Reconfigura as colunas do DataGridView
                dgvProjetos.AutoGenerateColumns = false;

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Id_Projeto",
                    HeaderText = "ID",
                    Name = "Id_Projeto"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nome",
                    HeaderText = "Nome",
                    Name = "Nome"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Endereco",
                    HeaderText = "Endereço",
                    Name = "Endereco"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Data_Realizacao",
                    HeaderText = "Data de Realização",
                    Name = "Data_Realizacao",
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
                });

                // Preenche os dados no DataGridView
                dgvProjetos.DataSource = projetos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar projetos: " + ex.Message);
            }
        }

        private void CarregarTodosProjetos()
        {
            try
            {
                // Verifica tipo de usuário (Adm ou Lider)
                DataTable projetos;
                if (sessao.TipoUsuario == "Adm")
                {
                    projetos = projeto.CarregarTodosProjetos(); // Carrega todos os projetos para Admin
                }
                else
                {
                    projetos = projeto.CarregarProjetosDoLider(); // Carrega os projetos do líder logado
                }

                dgvProjetos.Rows.Clear(); // Limpa as linhas anteriores
                dgvProjetos.Columns.Clear(); // Limpa as colunas anteriores

                dgvProjetos.AutoGenerateColumns = false;

                // Adiciona as colunas ao DataGridView
                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Id_Projeto",
                    HeaderText = "ID",
                    Name = "Id_Projeto"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nome",
                    HeaderText = "Nome",
                    Name = "Nome"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Endereco",
                    HeaderText = "Endereço",
                    Name = "Endereco"
                });

                dgvProjetos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Data_Realizacao",
                    HeaderText = "Data de Realização",
                    Name = "Data_Realizacao",
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
                });

                // Preenche os dados no DataGridView
                dgvProjetos.DataSource = projetos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar todos os projetos: " + ex.Message);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Detecta quando pressionamos a tecla Enter
            {
                PesquisarProjetos();  // Chama a função de pesquisa
                e.SuppressKeyPress = true;  // Impede o "beep" ao pressionar Enter
            }
        }
    }
}