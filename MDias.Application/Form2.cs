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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                administrador adm = new administrador
                {
                    Nome = txtNome.Text,
                    Senha = txtSenha.Text
                };
                if (adm.cadastrarAdm())
                {
                    MessageBox.Show("Administrador cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Clear();
                    txtSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
    }
}