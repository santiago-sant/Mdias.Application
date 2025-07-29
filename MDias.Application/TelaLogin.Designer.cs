namespace MDias.Application
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            spaceButton1 = new ReaLTaiizor.Controls.SpaceButton();
            thunderControlBox1 = new ReaLTaiizor.Controls.ThunderControlBox();
            formTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.FromArgb(32, 41, 50);
            formTheme1.Controls.Add(kryptonPictureBox1);
            formTheme1.Controls.Add(txtSenha);
            formTheme1.Controls.Add(txtUsuario);
            formTheme1.Controls.Add(spaceButton1);
            formTheme1.Controls.Add(thunderControlBox1);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 8F);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Margin = new Padding(3, 2, 3, 2);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 21, 3, 21);
            formTheme1.Sizable = true;
            formTheme1.Size = new Size(700, 338);
            formTheme1.SmartBounds = false;
            formTheme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            formTheme1.TabIndex = 0;
            formTheme1.Click += formTheme1_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(422, 59);
            kryptonPictureBox1.Margin = new Padding(3, 2, 3, 2);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(241, 202);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 6;
            kryptonPictureBox1.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 4;
            txtSenha.CustomizableEdges = customizableEdges1;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FillColor = Color.FromArgb(224, 224, 224);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(55, 158);
            txtSenha.Margin = new Padding(4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '.';
            txtSenha.PlaceholderText = "Senha ";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSenha.Size = new Size(325, 23);
            txtSenha.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderRadius = 4;
            txtUsuario.CustomizableEdges = customizableEdges3;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FillColor = Color.FromArgb(224, 224, 224);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(55, 100);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsuario.Size = new Size(325, 23);
            txtUsuario.TabIndex = 4;
            // 
            // spaceButton1
            // 
            spaceButton1.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            spaceButton1.Font = new Font("Verdana", 8F);
            spaceButton1.Image = null;
            spaceButton1.Location = new Point(152, 217);
            spaceButton1.Margin = new Padding(3, 2, 3, 2);
            spaceButton1.Name = "spaceButton1";
            spaceButton1.NoRounding = false;
            spaceButton1.Size = new Size(131, 38);
            spaceButton1.TabIndex = 3;
            spaceButton1.Text = "Entrar";
            spaceButton1.TextAlignment = HorizontalAlignment.Center;
            spaceButton1.Transparent = false;
            spaceButton1.Click += spaceButton1_Click;
            // 
            // thunderControlBox1
            // 
            thunderControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            thunderControlBox1.BackColor = Color.Transparent;
            thunderControlBox1.DefaultLocation = true;
            thunderControlBox1.ForeColor = Color.White;
            thunderControlBox1.Location = new Point(633, 3);
            thunderControlBox1.Margin = new Padding(3, 2, 3, 2);
            thunderControlBox1.Name = "thunderControlBox1";
            thunderControlBox1.Size = new Size(64, 18);
            thunderControlBox1.TabIndex = 0;
            thunderControlBox1.Text = "thunderControlBox1";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(formTheme1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(110, 38);
            Name = "TelaLogin";
            TransparencyKey = Color.Fuchsia;
            formTheme1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.ThunderControlBox thunderControlBox1;
        private ReaLTaiizor.Controls.SpaceButton spaceButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}
