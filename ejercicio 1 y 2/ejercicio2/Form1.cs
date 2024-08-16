namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // Intenta convertir el texto ingresado a un número
            if (double.TryParse(textBox1.Text, out double grados))
            {
                // Convertir grados a radianes
                double radianes = grados * (Math.PI / 180);

                // Calcular la cotangente en grados y radianes
                double cotangenteGrados = 1 / Math.Tan(grados * (Math.PI / 180));
                double cotangenteRadianes = 1 / Math.Tan(radianes);

                // Mostrar los resultados en las etiquetas
                gradoslabel2.Text = $"Cotangente en grados: {cotangenteGrados:F4}";
                radianeslabel3.Text = $"Cotangente en radianes: {cotangenteRadianes:F4}";
            }
            else
            {
                // Mostrar mensaje de error si la conversión falla
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
        }

        private void radianeslabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
