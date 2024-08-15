namespace ejercicio_6
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ConversorKg
        {
            public double Convertkilograms(double pounds)
            {
                double kilograms = pounds * 0.453592;

                return kilograms;
            }
        }

        public class Conversor
        {
            public double Convertpounds(double kilograms)
            {
                double pounds = kilograms * 2.20462;

                return pounds;
            }
        }



        private void buttonLb_Click(object sender, EventArgs e)
        {
            double pounds = Convert.ToInt32(textBoxLb.Text);


            double response = new ConversorKg().Convertkilograms(pounds);

            labelLb.Text = $"la cantidad de libras en kg es: {response}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double kilograms = Convert.ToInt32(textBox2.Text);


            double response = new Conversor().Convertpounds(kilograms);

            label3.Text = $"la cantidad de kg en libras es: {response}";
        }
    }
}
