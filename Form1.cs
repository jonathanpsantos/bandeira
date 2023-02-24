using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03
{
    public partial class FormCobinacoes : Form
    {

        //método para verificar situação dos checkboxes

        private void verifica()
        {
            if (!chkRetangulo.Checked && !chkLosango.Checked && !chkCirculo.Checked)
            {
                labelTexto.Text = "Forma desconhecida";
                pictureBoxFormas.Image = null;
            }
            else if (chkRetangulo.Checked && !chkLosango.Checked && !chkCirculo.Checked)
            {
                labelTexto.Text = "Retângulo";
                pictureBoxFormas.Image = Properties.Resources.retangulo;
            }
            else if (!chkRetangulo.Checked && chkLosango.Checked && !chkCirculo.Checked)
            {
                labelTexto.Text = "Losango";
                pictureBoxFormas.Image = Properties.Resources.losango;
            }
            else if (chkCirculo.Checked && !chkRetangulo.Checked && !chkLosango.Checked)
            {
                labelTexto.Text = "Circulo";
                pictureBoxFormas.Image = Properties.Resources.circulo;
            }
            else if (!chkCirculo.Checked && chkRetangulo.Checked && chkLosango.Checked)
            {
                labelTexto.Text = "Retângulo e Losango";
                pictureBoxFormas.Image = Properties.Resources.retangulo_losango;
            }
            else if (chkCirculo.Checked && !chkRetangulo.Checked && chkLosango.Checked)
            {
                labelTexto.Text = "Losango e Circulo";
                pictureBoxFormas.Image = Properties.Resources.losango_circulo;

            }
            else if (chkCirculo.Checked && chkRetangulo.Checked && !chkLosango.Checked)
            {
                labelTexto.Text = "Retângulo e Circulo";
                pictureBoxFormas.Image = Properties.Resources.retangulo_circulo;
            }

            else {
                labelTexto.Text = "Bandeira";
                pictureBoxFormas.Image = Properties.Resources.bandeira;
            }
        }
                                public FormCobinacoes()
        {
            InitializeComponent();
        }

        private void chkRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void FormCobinacoes_Load(object sender, EventArgs e)
        {

        }

        private void chkLosango_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void chkCirculo_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }
    }
}
