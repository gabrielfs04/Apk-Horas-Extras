namespace Horas_Extras
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnGerar = new Button();
            CalendárioExtras = new MonthCalendar();
            horasEntrada = new CustomNumericUpDown();
            minutosEntrada = new CustomNumericUpDown();
            doisPontosE = new Label();
            doisPontosS = new Label();
            minutosSaída = new CustomNumericUpDown();
            horasSaída = new CustomNumericUpDown();
            indicadorEntrada = new Label();
            indicadorSaída = new Label();
            indicadorCalendário = new Label();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            planilhaReembolsoToolStripMenuItem = new ToolStripMenuItem();
            btnAdicionar = new Button();
            listaExtras = new ListBox();
            hScrollBar1 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)horasEntrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutosEntrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutosSaída).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horasSaída).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(207, 415);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(97, 41);
            btnGerar.TabIndex = 1;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // CalendárioExtras
            // 
            CalendárioExtras.Location = new Point(18, 74);
            CalendárioExtras.Name = "CalendárioExtras";
            CalendárioExtras.TabIndex = 2;
            CalendárioExtras.DateChanged += CalendárioExtras_DateChanged;
            // 
            // horasEntrada
            // 
            horasEntrada.Location = new Point(253, 135);
            horasEntrada.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            horasEntrada.Name = "horasEntrada";
            horasEntrada.Size = new Size(35, 23);
            horasEntrada.TabIndex = 3;
            horasEntrada.ValueChanged += horasEntrada_ValueChanged;
            // 
            // minutosEntrada
            // 
            minutosEntrada.Location = new Point(310, 135);
            minutosEntrada.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minutosEntrada.Name = "minutosEntrada";
            minutosEntrada.Size = new Size(35, 23);
            minutosEntrada.TabIndex = 4;
            minutosEntrada.ValueChanged += minutosEntrada_ValueChanged;
            // 
            // doisPontosE
            // 
            doisPontosE.AutoSize = true;
            doisPontosE.Location = new Point(294, 137);
            doisPontosE.Name = "doisPontosE";
            doisPontosE.Size = new Size(10, 15);
            doisPontosE.TabIndex = 5;
            doisPontosE.Text = ":";
            // 
            // doisPontosS
            // 
            doisPontosS.AutoSize = true;
            doisPontosS.Location = new Point(429, 137);
            doisPontosS.Name = "doisPontosS";
            doisPontosS.Size = new Size(10, 15);
            doisPontosS.TabIndex = 8;
            doisPontosS.Text = ":";
            // 
            // minutosSaída
            // 
            minutosSaída.Location = new Point(445, 135);
            minutosSaída.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minutosSaída.Name = "minutosSaída";
            minutosSaída.Size = new Size(35, 23);
            minutosSaída.TabIndex = 7;
            minutosSaída.ValueChanged += minutosSaída_ValueChanged;
            // 
            // horasSaída
            // 
            horasSaída.Location = new Point(388, 135);
            horasSaída.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            horasSaída.Name = "horasSaída";
            horasSaída.Size = new Size(35, 23);
            horasSaída.TabIndex = 6;
            horasSaída.ValueChanged += horasSaída_ValueChanged;
            // 
            // indicadorEntrada
            // 
            indicadorEntrada.AutoSize = true;
            indicadorEntrada.Location = new Point(279, 108);
            indicadorEntrada.Name = "indicadorEntrada";
            indicadorEntrada.Size = new Size(47, 15);
            indicadorEntrada.TabIndex = 10;
            indicadorEntrada.Text = "Entrada";
            // 
            // indicadorSaída
            // 
            indicadorSaída.AutoSize = true;
            indicadorSaída.Location = new Point(415, 108);
            indicadorSaída.Name = "indicadorSaída";
            indicadorSaída.Size = new Size(35, 15);
            indicadorSaída.TabIndex = 11;
            indicadorSaída.Text = "Saída";
            // 
            // indicadorCalendário
            // 
            indicadorCalendário.AutoSize = true;
            indicadorCalendário.Location = new Point(96, 50);
            indicadorCalendário.Name = "indicadorCalendário";
            indicadorCalendário.Size = new Size(64, 15);
            indicadorCalendário.TabIndex = 12;
            indicadorCalendário.Text = "Calendário";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(492, 25);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { planilhaReembolsoToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // planilhaReembolsoToolStripMenuItem
            // 
            planilhaReembolsoToolStripMenuItem.Name = "planilhaReembolsoToolStripMenuItem";
            planilhaReembolsoToolStripMenuItem.Size = new Size(178, 22);
            planilhaReembolsoToolStripMenuItem.Text = "Planilha Reembolso";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(310, 185);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(113, 31);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listaExtras
            // 
            listaExtras.FormattingEnabled = true;
            listaExtras.ItemHeight = 15;
            listaExtras.Location = new Point(18, 291);
            listaExtras.Name = "listaExtras";
            listaExtras.Size = new Size(462, 94);
            listaExtras.TabIndex = 15;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(18, 367);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(445, 17);
            hScrollBar1.TabIndex = 16;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(463, 291);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 93);
            vScrollBar1.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(492, 478);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Controls.Add(listaExtras);
            Controls.Add(btnAdicionar);
            Controls.Add(toolStrip1);
            Controls.Add(indicadorCalendário);
            Controls.Add(indicadorSaída);
            Controls.Add(indicadorEntrada);
            Controls.Add(doisPontosS);
            Controls.Add(minutosSaída);
            Controls.Add(horasSaída);
            Controls.Add(doisPontosE);
            Controls.Add(minutosEntrada);
            Controls.Add(horasEntrada);
            Controls.Add(CalendárioExtras);
            Controls.Add(btnGerar);
            Name = "MainForm";
            Text = "Gerador Planilha";
            ((System.ComponentModel.ISupportInitialize)horasEntrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutosEntrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutosSaída).EndInit();
            ((System.ComponentModel.ISupportInitialize)horasSaída).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.MonthCalendar CalendárioExtras;
        private CustomNumericUpDown horasEntrada;
        private CustomNumericUpDown minutosEntrada;
        private System.Windows.Forms.Label doisPontosE;
        private System.Windows.Forms.Label doisPontosS;
        private CustomNumericUpDown minutosSaída;
        private CustomNumericUpDown horasSaída;
        private System.Windows.Forms.Label indicadorEntrada;
        private System.Windows.Forms.Label indicadorSaída;
        private System.Windows.Forms.Label indicadorCalendário;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem planilhaReembolsoToolStripMenuItem;
        private Button btnAdicionar;
        private ListBox listaExtras;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
    }
}
