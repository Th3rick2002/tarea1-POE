using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phrase = Convert.ToString(textBox1.Text);

            string phraseLower = phrase.ToLower();

            string[] words = phraseLower.Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            
            foreach (KeyValuePair<string, int> pair in wordCount)
            {
                if (pair.Value > 1)
                {
                    label2.Text = ($"{pair.Key}: {pair.Value} veces");
                }
            }
        }
    }
}
