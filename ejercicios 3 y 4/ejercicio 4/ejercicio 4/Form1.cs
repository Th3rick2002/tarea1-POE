namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            textBox1.KeyDown += new KeyEventHandler(TextBox1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            HandleRestrictedKeys(e);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Manejar eventos de teclas presionadas en el TextBox
            HandleRestrictedKeys(e);
        }

        private void HandleRestrictedKeys(KeyEventArgs e)
        {
            // Comprobar si la tecla presionada es una de las teclas prohibidas
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space || e.KeyCode == Keys.Back)
            {
                // Mostrar mensaje de advertencia
                MessageBox.Show("Esta tecla está prohibida.");
                // Prevenir la acción por defecto de la tecla
                e.SuppressKeyPress = true;
            }
        }
    }
}
