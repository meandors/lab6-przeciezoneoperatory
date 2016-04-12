using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bMnożenie_Click(object sender, EventArgs e)
        {
            if (tbI1.Text != "" && tbI2.Text != "" && tbR1.Text != "" && tbR2.Text != "")
            {
                Zespolone z1 = new Zespolone(double.Parse(tbR1.Text), double.Parse(tbI1.Text));
                Zespolone z2 = new Zespolone(double.Parse(tbR2.Text), double.Parse(tbI2.Text));

                Zespolone result = z1 * z2;

                tbResult.Text = result.ToString();
            }
        }

        private void bDodawanie_Click(object sender, EventArgs e)
        {
            if (tbI1.Text != "" && tbI2.Text != "" && tbR1.Text != "" && tbR2.Text != "")
            {
                Zespolone z1 = new Zespolone(double.Parse(tbR1.Text), double.Parse(tbI1.Text));
                Zespolone z2 = new Zespolone(double.Parse(tbR2.Text), double.Parse(tbI2.Text));

                Zespolone result = z1 + z2;

                tbResult.Text = result.ToString();
            }
        }

        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            if (tbI1.Text != "" && tbI2.Text != "" && tbR1.Text != "" && tbR2.Text != "")
            {
                Zespolone z1 = new Zespolone(double.Parse(tbR1.Text), double.Parse(tbI1.Text));
                Zespolone z2 = new Zespolone(double.Parse(tbR2.Text), double.Parse(tbI2.Text));

                Zespolone result = z1 - z2;

                tbResult.Text = result.ToString();
            }
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            if (tbI1.Text != "" && tbI2.Text != "" && tbR1.Text != "" && tbR2.Text != "")
            {
                Zespolone z1 = new Zespolone(double.Parse(tbR1.Text), double.Parse(tbI1.Text));
                Zespolone z2 = new Zespolone(double.Parse(tbR2.Text), double.Parse(tbI2.Text));

                Zespolone result = z1 / z2;

                tbResult.Text = result.ToString();
            }
        }

        private void bRownosc_Click(object sender, EventArgs e)
        {
            if (tbI1.Text != "" && tbI2.Text != "" && tbR1.Text != "" && tbR2.Text != "")
            {
                Zespolone z1 = new Zespolone(double.Parse(tbR1.Text), double.Parse(tbI1.Text));
                Zespolone z2 = new Zespolone(double.Parse(tbR2.Text), double.Parse(tbI2.Text));

                if (z1 == z2)
                    MessageBox.Show("Są równe!");
                else
                    MessageBox.Show("Nie są równe!");
            }
        }
    }
}
