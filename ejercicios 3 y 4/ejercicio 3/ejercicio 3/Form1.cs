namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Heptágono");
            comboBox1.Items.Add("Círculo");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Heptágono")
            {
                Heptagono heptagono = new Heptagono();
                if (double.TryParse(textBox1.Text, out double lado))
                {
                    heptagono.Lado = lado;
                    double area = heptagono.CalcularArea();
                    double perimetro = heptagono.CalcularPerimetro();
                    label3.Text = $"Área: {area:F2}";
                    label4.Text = $"Perímetro: {perimetro:F2}";
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para el lado.");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Círculo")
            {
                Circulo circulo = new Circulo();
                if (double.TryParse(textBox1.Text, out double radio))
                {
                    circulo.Radio = radio;
                    double area = circulo.CalcularArea();
                    double perimetro = circulo.CalcularPerimetro();
                    label3.Text = $"Área: {area:F2}";
                    label4.Text = $"Perímetro: {perimetro:F2}";
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para el radio.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "Área: ";
            label2.Text = "Perímetro: ";
        }
    }

    public class Heptagono
    {
        public double Lado { get; set; }

        public double CalcularArea()
        {
            return (7 * Lado * Lado) / (4 * Math.Tan(Math.PI / 7));
        }

        public double CalcularPerimetro()
        {
            return 7 * Lado;
        }
    }

    public class Circulo
    {
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }


}
