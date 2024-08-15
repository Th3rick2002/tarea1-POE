namespace ejercicio_6
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
            groupBox1 = new GroupBox();
            buttonLb = new Button();
            labelLb = new Label();
            textBoxLb = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLb);
            groupBox1.Controls.Add(labelLb);
            groupBox1.Controls.Add(textBoxLb);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Libras a Kilogramos";
            // 
            // buttonLb
            // 
            buttonLb.Location = new Point(55, 149);
            buttonLb.Name = "buttonLb";
            buttonLb.Size = new Size(75, 23);
            buttonLb.TabIndex = 2;
            buttonLb.Text = "Calcular";
            buttonLb.UseVisualStyleBackColor = true;
            buttonLb.Click += buttonLb_Click;
            // 
            // labelLb
            // 
            labelLb.AutoSize = true;
            labelLb.Location = new Point(24, 195);
            labelLb.Name = "labelLb";
            labelLb.Size = new Size(0, 15);
            labelLb.TabIndex = 2;
            // 
            // textBoxLb
            // 
            textBoxLb.Location = new Point(39, 99);
            textBoxLb.Name = "textBoxLb";
            textBoxLb.Size = new Size(100, 23);
            textBoxLb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 60);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese la cantidad de libras";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(402, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 265);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kilogramos a Libras";
            // 
            // button2
            // 
            button2.Location = new Point(58, 149);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 60);
            label4.Name = "label4";
            label4.Size = new Size(185, 15);
            label4.TabIndex = 6;
            label4.Text = "Ingrese la cantidad de Kilogramos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 195);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "ejercicio 6";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label labelLb;
        private TextBox textBoxLb;
        private Button buttonLb;
        private Button button2;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
    }
}
