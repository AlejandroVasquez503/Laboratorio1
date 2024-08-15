using System;
using System.Windows.Forms;
using FigurasGeometricas;

namespace areaYperimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            double valor = 0;

            if (double.TryParse(ValorTextBox.Text, out valor))
            {
                if (cuadradoButton.Checked)
                {
                    Cuadrado cuadrado = new Cuadrado(valor);
                    cuadroResultado.Text = $"Área: {cuadrado.CalcularArea()}";
                }
                else if (circunferenciaButton.Checked)
                {
                    Circunferencia circunferencia = new Circunferencia(valor);
                    cuadroResultado.Text = $"Área: {circunferencia.CalcularArea()}";
                }
                else
                {
                    MessageBox.Show("Seleccione una figura.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }

        private void PerimetroButton_Click(object sender, EventArgs e)
        {
            double valor = 0;

            if (double.TryParse(ValorTextBox.Text, out valor))
            {
                if (cuadradoButton.Checked)
                {
                    Cuadrado cuadrado = new Cuadrado(valor);
                    perimetroResultado.Text = $"Perímetro: {cuadrado.CalcularPerimetro()}";
                }
                else if (circunferenciaButton.Checked)
                {
                    Circunferencia circunferencia = new Circunferencia(valor);
                    perimetroResultado.Text = $"Perímetro: {circunferencia.CalcularPerimetro()}";
                }
                else
                {
                    MessageBox.Show("Seleccione una figura.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
