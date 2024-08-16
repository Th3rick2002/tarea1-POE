namespace Calculo_de_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void unoNumberttextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiarbutton2_Click(object sender, EventArgs e)
        {
            unoNumberttextBox1.Clear();
            twoNumbertboxtextBox2.Clear();
            treeNumberttextBox3.Clear();
        }

        private void exitbutton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
           

        }

        private void Calcularbutton1_MouseHover(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(unoNumberttextBox1.Text);
            int num2 = Convert.ToInt32(twoNumbertboxtextBox2.Text);
            int num3 = Convert.ToInt32(treeNumberttextBox3.Text);

            if (num1 >= num2 && num1 >= num3)
            {
                resultlabel1.Text = "El numero mayor es el:" + num1;
            }
            if (num2 >= num1 && num2 >= num3)
            {
                resultlabel1.Text = "El numero mayor es el:" + num2;
            }
            if (num3 >= num2 && num1 >= num2)
            {
                resultlabel1.Text = "El numero mayor es el:" + num3;
            }
        }
    }
}
