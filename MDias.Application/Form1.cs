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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaVoluntario telaVoluntario = new TelaVoluntario();
            telaVoluntario.Show();
            this.Hide();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleVoluntario telaControleVoluntario = new TelaControleVoluntario();
            telaControleVoluntario.Show();
            this.Hide();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaProjeto telaProjeto = new TelaProjeto();
            telaProjeto.Show();
            this.Hide();
        }
    }
}