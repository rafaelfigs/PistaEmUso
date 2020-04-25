using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pista_em_uso
{
    public partial class JanelaPrincipal : Form
    {
        int rumoPista = 0;
        int direcaoVento = 0;
        int declinacaoMagnetica = 0;
        bool declinacaoOeste = true;

        Stopwatch stopWatch = new Stopwatch();

        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void textBoxRumoPista_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRumoPista.Text.All(char.IsDigit) && textBoxRumoPista.Text.Length >= 1 && textBoxRumoPista.Text.Length <= 3 && Convert.ToInt32(textBoxRumoPista.Text) >= 0 && Convert.ToInt32(textBoxRumoPista.Text) <= 360)
            {
                rumoPista = Convert.ToInt32(textBoxRumoPista.Text);
            }

            else
            {
                textBoxRumoPista.Text = string.Empty;
            }
        }

        private void radioButtonOeste_CheckedChanged(object sender, EventArgs e)
        {
            declinacaoOeste = true;
        }

        private void radioButtonLeste_CheckedChanged(object sender, EventArgs e)
        {
            declinacaoOeste = false;
        }

        private void checkBoxSempreVisivel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSempreVisivel.Checked)
            {
                this.TopMost = true;
            }

            else
            {
                this.TopMost = false;
            }
        }

        private void trackBarTransparencia_Scroll(object sender, EventArgs e)
        {
            ActiveForm.Opacity = ((double) (trackBarTransparencia.Value) / 100.0D);
        }

        private void checkBoxCronometro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCronometro.Checked)
            {
                stopWatch = new Stopwatch();
                timer1.Enabled = true;
                stopWatch.Start();
            }

            else
            {
                stopWatch.Stop();
                timer1.Enabled = false;
                // this.labelCronometro.Text = "00:00";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelCronometro.Text = stopWatch.Elapsed.ToString(@"mm\:ss");
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (textBoxRumoPista.Text.Length >= 1 && textBoxDirecaoVento.Text.Length >= 1 && textBoxDeclinacaoMagnetica.Text.Length >= 1)
            {
                labelResultadoPistaEmUso.Text = PistaEmUso.SaidaPistaEmUso(rumoPista, direcaoVento, declinacaoMagnetica, declinacaoOeste);
            }
            else
            {
                MessageBox.Show("Dados em branco. Tente novamente.");
            }
        }

        private void textBoxDeclinacaoMagnetica_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDeclinacaoMagnetica.Text.All(char.IsDigit) && textBoxDeclinacaoMagnetica.Text.Length >= 1 && textBoxDeclinacaoMagnetica.Text.Length <= 3 && Convert.ToInt32(textBoxDeclinacaoMagnetica.Text) >= 0 && Convert.ToInt32(textBoxDeclinacaoMagnetica.Text) <= 360)
            {
                declinacaoMagnetica = Convert.ToInt32(textBoxDeclinacaoMagnetica.Text);
            }

            else
            {
                textBoxDeclinacaoMagnetica.Text = string.Empty;
            }
        }

        private void textBoxDirecaoVento_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDirecaoVento.Text.All(char.IsDigit) && textBoxDirecaoVento.Text.Length >= 1 && textBoxDirecaoVento.Text.Length <= 3 && Convert.ToInt32(textBoxDirecaoVento.Text) >= 0 && Convert.ToInt32(textBoxDirecaoVento.Text) <= 360)
            {
                direcaoVento = Convert.ToInt32(textBoxDirecaoVento.Text);
            }

            else
            {
                textBoxDirecaoVento.Text = string.Empty;
            }
        }
    }
}
