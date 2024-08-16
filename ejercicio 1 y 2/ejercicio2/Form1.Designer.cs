namespace ejercicio2
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
            angulolabel1 = new Label();
            gradoslabel2 = new Label();
            radianeslabel3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // angulolabel1
            // 
            angulolabel1.AutoSize = true;
            angulolabel1.Location = new Point(112, 75);
            angulolabel1.Name = "angulolabel1";
            angulolabel1.Size = new Size(127, 20);
            angulolabel1.TabIndex = 0;
            angulolabel1.Text = "Ángulo en grados";
            // 
            // gradoslabel2
            // 
            gradoslabel2.AutoSize = true;
            gradoslabel2.Location = new Point(256, 75);
            gradoslabel2.Name = "gradoslabel2";
            gradoslabel2.Size = new Size(159, 20);
            gradoslabel2.TabIndex = 1;
            gradoslabel2.Text = "Cotangente en grados:";
            // 
            // radianeslabel3
            // 
            radianeslabel3.AutoSize = true;
            radianeslabel3.Location = new Point(427, 75);
            radianeslabel3.Name = "radianeslabel3";
            radianeslabel3.Size = new Size(169, 20);
            radianeslabel3.TabIndex = 2;
            radianeslabel3.Text = "Cotangente en radianes:";
            radianeslabel3.Click += radianeslabel3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(256, 256);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 4;
            button1.Text = "Calcular Cotangente";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(radianeslabel3);
            Controls.Add(gradoslabel2);
            Controls.Add(angulolabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label angulolabel1;
        private Label gradoslabel2;
        private Label radianeslabel3;
        private TextBox textBox1;
        private Button button1;
    }
}
