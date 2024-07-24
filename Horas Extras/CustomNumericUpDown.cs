using System;
using System.Drawing;
using System.Windows.Forms;

namespace Horas_Extras
{
    public class CustomNumericUpDown : NumericUpDown
    {
        protected override void UpdateEditText()
        {
            // Atualiza o texto no controle para exibir dois dígitos
            this.Text = this.Value.ToString("00");
        }
    }
}

