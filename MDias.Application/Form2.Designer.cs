namespace MDias.Application
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.CustomizableEdges = customizableEdges7;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(87, 81);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome ";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtNome.Size = new Size(200, 36);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.CustomizableEdges = customizableEdges9;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(87, 168);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha ";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSenha.Size = new Size(200, 36);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += this.txtSenha_TextChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges11;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(87, 239);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button1.Size = new Size(164, 47);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "guna2Button1";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button1);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}