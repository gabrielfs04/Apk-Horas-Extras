namespace Horas_Extras
{
    public partial class FormLogin : Form
    {
        public bool IsLoginSucessfull { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
            IsLoginSucessfull = false; // Inicialmente, o login não foi bem-sucedido
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Aqui você pode adicionar a lógica para verificar as credenciais
            if (username == "admin.admin" && password == "z1234xcv@")
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                IsLoginSucessfull = true; // Define que o login foi bem-sucedido

                this.Close(); // Fecha o formulário de login
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
