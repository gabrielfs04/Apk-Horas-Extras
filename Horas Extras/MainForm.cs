using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Horas_Extras
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Inicialização das propriedades do NumericUpDown
            horasEntrada.Minimum = 0;
            horasEntrada.Maximum = 23;
            minutosEntrada.Minimum = 0;
            minutosEntrada.Maximum = 59;
            horasSaída.Minimum = 0;
            horasSaída.Maximum = 23;
            minutosSaída.Minimum = 0;
            minutosSaída.Maximum = 59;
        }

        private DateTime dataSelecionada;



        private void CalendárioExtras_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataSelecionada = e.Start;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Pega os valores dos controles NumericUpDown
            decimal valorHorasEntrada = horasEntrada.Value;
            decimal valorMinutosEntrada = minutosEntrada.Value;
            decimal valorHorasSaida = horasSaída.Value;
            decimal valorMinutosSaida = minutosSaída.Value;

            // Formata a data e os valores como uma única string e adiciona à ListBox
            string dataFormatada = dataSelecionada.ToShortDateString();
            string entradaSaidaFormatada = $"Entrada: {valorHorasEntrada:00}:{valorMinutosEntrada:00} - Saída: {valorHorasSaida:00}:{valorMinutosSaida:00}";
            string itemFormatado = $"{dataFormatada} - {entradaSaidaFormatada}";

            listaExtras.Items.Add(itemFormatado);
        }

        private void horasEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minutosEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void horasSaída_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minutosSaída_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\gabriel.silva\Desktop\Horas-Extras.xlsx";

            // Abra a aplicação do Excel
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Seleciona a primeira planilha

            // Itera sobre os itens do ListBox e preenche a planilha
            int row = 2; // Começa na linha 2 para pular o cabeçalho, ajuste conforme necessário
            foreach (var item in listaExtras.Items)
            {
                string[] parts = item.ToString().Split(new[] { " - " }, StringSplitOptions.None);
                string data = parts[0];
                string entrada = parts[1].Replace("Entrada: ", "");
                string saida = parts[2].Replace("Saída: ", "");

                worksheet.Cells[row, 1] = data;
                worksheet.Cells[row, 2] = entrada;
                worksheet.Cells[row, 3] = saida;

                row++;
            }

            // Salva e fecha o arquivo Excel
            workbook.Save();
            workbook.Close();
            excelApp.Quit();

            // Liberar recursos
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);

            MessageBox.Show("Arquivo Excel preenchido com sucesso.");
        }
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Erro ao liberar objeto: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
