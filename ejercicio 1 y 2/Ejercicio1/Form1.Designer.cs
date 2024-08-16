namespace Calculo_de_numeros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numberlabel1 = new Label();
            number2label2 = new Label();
            Numbert3label3 = new Label();
            unoNumberttextBox1 = new TextBox();
            twoNumbertboxtextBox2 = new TextBox();
            treeNumberttextBox3 = new TextBox();
            Calcularbutton1 = new Button();
            Limpiarbutton2 = new Button();
            exitbutton3 = new Button();
            resultlabel1 = new Label();
            SuspendLayout();
            // 
            // numberlabel1
            // 
            numberlabel1.AutoSize = true;
            numberlabel1.Location = new Point(234, 96);
            numberlabel1.Name = "numberlabel1";
            numberlabel1.Size = new Size(71, 20);
            numberlabel1.TabIndex = 0;
            numberlabel1.Text = "Numero1";
            // 
            // number2label2
            // 
            number2label2.AutoSize = true;
            number2label2.Location = new Point(234, 151);
            number2label2.Name = "number2label2";
            number2label2.Size = new Size(71, 20);
            number2label2.TabIndex = 1;
            number2label2.Text = "Numero2";
            // 
            // Numbert3label3
            // 
            Numbert3label3.AutoSize = true;
            Numbert3label3.Location = new Point(234, 221);
            Numbert3label3.Name = "Numbert3label3";
            Numbert3label3.Size = new Size(71, 20);
            Numbert3label3.TabIndex = 2;
            Numbert3label3.Text = "Numero3";
            // 
            // unoNumberttextBox1
            // 
            unoNumberttextBox1.Location = new Point(323, 89);
            unoNumberttextBox1.Name = "unoNumberttextBox1";
            unoNumberttextBox1.Size = new Size(125, 27);
            unoNumberttextBox1.TabIndex = 3;
            unoNumberttextBox1.TextChanged += unoNumberttextBox1_TextChanged;
            // 
            // twoNumbertboxtextBox2
            // 
            twoNumbertboxtextBox2.Location = new Point(323, 148);
            twoNumbertboxtextBox2.Name = "twoNumbertboxtextBox2";
            twoNumbertboxtextBox2.Size = new Size(125, 27);
            twoNumbertboxtextBox2.TabIndex = 4;
            twoNumbertboxtextBox2.TextChanged += textBox2_TextChanged;
            // 
            // treeNumberttextBox3
            // 
            treeNumberttextBox3.Location = new Point(323, 214);
            treeNumberttextBox3.Name = "treeNumberttextBox3";
            treeNumberttextBox3.Size = new Size(125, 27);
            treeNumberttextBox3.TabIndex = 5;
            // 
            // Calcularbutton1
            // 
            Calcularbutton1.Location = new Point(122, 311);
            Calcularbutton1.Name = "Calcularbutton1";
            Calcularbutton1.Size = new Size(94, 29);
            Calcularbutton1.TabIndex = 6;
            Calcularbutton1.Text = "Calcular";
            Calcularbutton1.UseVisualStyleBackColor = true;
            Calcularbutton1.MouseHover += Calcularbutton1_MouseHover;
            // 
            // Limpiarbutton2
            // 
            Limpiarbutton2.Location = new Point(298, 306);
            Limpiarbutton2.Name = "Limpiarbutton2";
            Limpiarbutton2.Size = new Size(94, 29);
            Limpiarbutton2.TabIndex = 7;
            Limpiarbutton2.Text = "Limpiar";
            Limpiarbutton2.UseVisualStyleBackColor = true;
            Limpiarbutton2.Click += Limpiarbutton2_Click;
            // 
            // exitbutton3
            // 
            exitbutton3.Location = new Point(496, 307);
            exitbutton3.Name = "exitbutton3";
            exitbutton3.Size = new Size(94, 29);
            exitbutton3.TabIndex = 8;
            exitbutton3.Text = "Salir";
            exitbutton3.UseVisualStyleBackColor = true;
            exitbutton3.Click += exitbutton3_Click;
            // 
            // resultlabel1
            // 
            resultlabel1.AutoSize = true;
            resultlabel1.Location = new Point(327, 263);
            resultlabel1.Name = "resultlabel1";
            resultlabel1.Size = new Size(75, 20);
            resultlabel1.TabIndex = 9;
            resultlabel1.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultlabel1);
            Controls.Add(exitbutton3);
            Controls.Add(Limpiarbutton2);
            Controls.Add(Calcularbutton1);
            Controls.Add(treeNumberttextBox3);
            Controls.Add(twoNumbertboxtextBox2);
            Controls.Add(unoNumberttextBox1);
            Controls.Add(Numbert3label3);
            Controls.Add(number2label2);
            Controls.Add(numberlabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberlabel1;
        private Label number2label2;
        private Label Numbert3label3;
        private TextBox unoNumberttextBox1;
        private TextBox twoNumbertboxtextBox2;
        private TextBox treeNumberttextBox3;
        private Button Calcularbutton1;
        private Button Limpiarbutton2;
        private Button exitbutton3;
        private Label resultlabel1;
    }
}
