namespace Horas_Extras
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            labelSenha = new Label();
            labelUsuário = new Label();
            labelTítulo = new Label();
            imagemFormLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagemFormLogin).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(113, 276);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(59, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(59, 166);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(187, 23);
            txtUsername.TabIndex = 2;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(128, 209);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 3;
            labelSenha.Text = "Senha";
            // 
            // labelUsuário
            // 
            labelUsuário.AutoSize = true;
            labelUsuário.Location = new Point(128, 148);
            labelUsuário.Name = "labelUsuário";
            labelUsuário.Size = new Size(47, 15);
            labelUsuário.TabIndex = 4;
            labelUsuário.Text = "Usuário";
            // 
            // labelTítulo
            // 
            labelTítulo.AutoSize = true;
            labelTítulo.Location = new Point(113, 9);
            labelTítulo.Name = "labelTítulo";
            labelTítulo.Size = new Size(72, 15);
            labelTítulo.TabIndex = 5;
            labelTítulo.Text = "Horas Extras";
            // 
            // imagemFormLogin
            // 
            imagemFormLogin.Image = (Image)resources.GetObject("imagemFormLogin.Image");
            imagemFormLogin.Location = new Point(83, 43);
            imagemFormLogin.Name = "imagemFormLogin";
            imagemFormLogin.Size = new Size(131, 90);
            imagemFormLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            imagemFormLogin.TabIndex = 6;
            imagemFormLogin.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(293, 349);
            Controls.Add(imagemFormLogin);
            Controls.Add(labelTítulo);
            Controls.Add(labelUsuário);
            Controls.Add(labelSenha);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            Text = "Horas Extras";
            ((System.ComponentModel.ISupportInitialize)imagemFormLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label labelSenha;
        private Label labelUsuário;
        private Label labelTítulo;
        private PictureBox imagemFormLogin;
    }
}
