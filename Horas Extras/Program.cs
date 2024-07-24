namespace Horas_Extras
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin loginForm = new FormLogin();
            Application.Run(loginForm);

            // Verifica se o login foi bem-sucedido antes de iniciar o MainForm
            if (loginForm.IsLoginSucessfull)
            {
                Application.Run(new MainForm());
            }
        }
    }
}