namespace GUI_Fraction_Calculator
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
            numerator1 = new TextBox();
            denominator1 = new TextBox();
            comboBox1 = new ComboBox();
            denominator2 = new TextBox();
            numerator2 = new TextBox();
            label1 = new Label();
            denominatorResult = new TextBox();
            numeratorResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // numerator1
            // 
            numerator1.Location = new Point(19, 19);
            numerator1.Name = "numerator1";
            numerator1.Size = new Size(31, 27);
            numerator1.TabIndex = 1;
            numerator1.Text = "0";
            numerator1.TextChanged += numerator1_TextChanged;
            // 
            // denominator1
            // 
            denominator1.Location = new Point(19, 52);
            denominator1.Name = "denominator1";
            denominator1.Size = new Size(31, 27);
            denominator1.TabIndex = 2;
            denominator1.Text = "0";
            denominator1.TextChanged += denominator1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(56, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(37, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "+";
            // 
            // denominator2
            // 
            denominator2.Location = new Point(98, 52);
            denominator2.Name = "denominator2";
            denominator2.Size = new Size(31, 27);
            denominator2.TabIndex = 6;
            denominator2.Text = "0";
            denominator2.TextChanged += textBox1_TextChanged;
            // 
            // numerator2
            // 
            numerator2.Location = new Point(98, 19);
            numerator2.Name = "numerator2";
            numerator2.Size = new Size(31, 27);
            numerator2.TabIndex = 5;
            numerator2.Text = "0";
            numerator2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(136, 40);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 8;
            label1.Text = "=";
            label1.Click += label1_Click;
            // 
            // denominatorResult
            // 
            denominatorResult.Location = new Point(161, 52);
            denominatorResult.Name = "denominatorResult";
            denominatorResult.ReadOnly = true;
            denominatorResult.Size = new Size(31, 27);
            denominatorResult.TabIndex = 11;
            // 
            // numeratorResult
            // 
            numeratorResult.Location = new Point(161, 19);
            numeratorResult.Name = "numeratorResult";
            numeratorResult.ReadOnly = true;
            numeratorResult.Size = new Size(31, 27);
            numeratorResult.TabIndex = 10;
            numeratorResult.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(61, 96);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 12;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(219, 81);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 13;
            button2.Text = "Сократить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(61, 133);
            button3.Name = "button3";
            button3.Size = new Size(94, 31);
            button3.TabIndex = 14;
            button3.Text = "Сравнить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 27);
            textBox1.TabIndex = 16;
            textBox1.Text = "0";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(31, 27);
            textBox2.TabIndex = 15;
            textBox2.Text = "0";
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(282, 48);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(31, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(282, 15);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(31, 27);
            textBox4.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(256, 37);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 19;
            label2.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(325, 165);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(denominatorResult);
            Controls.Add(numeratorResult);
            Controls.Add(label1);
            Controls.Add(denominator2);
            Controls.Add(numerator2);
            Controls.Add(comboBox1);
            Controls.Add(denominator1);
            Controls.Add(numerator1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox numerator1;
        private TextBox denominator1;
        private ComboBox comboBox1;
        private TextBox denominator2;
        private TextBox numerator2;
        private Label label1;
        private TextBox denominatorResult;
        private TextBox numeratorResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
    }
}
