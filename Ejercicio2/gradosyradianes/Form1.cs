namespace gradosyradianes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GradosButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (double.TryParse(ValorTerabox.Text, out double anguloGrados))
            {
                double anguloRadianes = anguloGrados * Math.PI / 180;
                double coseno = Math.Cos(anguloRadianes);
                coseno = Math.Round(coseno, 2);
                ResultadoLabel.Text = $"Coseno en grados: {coseno}";
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.");
            }
        }

        private void RadianesButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (double.TryParse(ValorTerabox.Text, out double anguloRadianes))
            {
                double coseno = Math.Cos(anguloRadianes);
                coseno = Math.Round(coseno, 2);
                ResultadoLabel.Text = $"Coseno en radianes: {coseno}";
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.");
            }
        }

    }
}
