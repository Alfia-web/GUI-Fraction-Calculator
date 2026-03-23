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
            wholeNumber1 = new TextBox();
            numerator1 = new TextBox();
            denominator1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            wholeNumber2 = new TextBox();
            label1 = new Label();
            denominatorResult = new TextBox();
            numeratorResult = new TextBox();
            wholeResult = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // wholeNumber1
            // 
            wholeNumber1.Location = new Point(18, 45);
            wholeNumber1.Name = "wholeNumber1";
            wholeNumber1.Size = new Size(31, 27);
            wholeNumber1.TabIndex = 0;
            wholeNumber1.TextChanged += wholeNumber1_TextChanged;
            // 
            // numerator1
            // 
            numerator1.Location = new Point(55, 27);
            numerator1.Name = "numerator1";
            numerator1.Size = new Size(31, 27);
            numerator1.TabIndex = 1;
            numerator1.TextChanged += numerator1_TextChanged;
            // 
            // denominator1
            // 
            denominator1.Location = new Point(55, 60);
            denominator1.Name = "denominator1";
            denominator1.Size = new Size(31, 27);
            denominator1.TabIndex = 2;
            denominator1.TextChanged += denominator1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(92, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(37, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "+";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(31, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // wholeNumber2
            // 
            wholeNumber2.Location = new Point(133, 45);
            wholeNumber2.Name = "wholeNumber2";
            wholeNumber2.Size = new Size(31, 27);
            wholeNumber2.TabIndex = 4;
            wholeNumber2.TextChanged += wholeNumber2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(208, 48);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 8;
            label1.Text = "=";
            label1.Click += label1_Click;
            // 
            // denominatorResult
            // 
            denominatorResult.Location = new Point(269, 60);
            denominatorResult.Name = "denominatorResult";
            denominatorResult.ReadOnly = true;
            denominatorResult.Size = new Size(31, 27);
            denominatorResult.TabIndex = 11;
            // 
            // numeratorResult
            // 
            numeratorResult.Location = new Point(269, 27);
            numeratorResult.Name = "numeratorResult";
            numeratorResult.ReadOnly = true;
            numeratorResult.Size = new Size(31, 27);
            numeratorResult.TabIndex = 10;
            numeratorResult.TextChanged += textBox5_TextChanged;
            // 
            // wholeResult
            // 
            wholeResult.Location = new Point(232, 45);
            wholeResult.Name = "wholeResult";
            wholeResult.ReadOnly = true;
            wholeResult.Size = new Size(31, 27);
            wholeResult.TabIndex = 9;
            wholeResult.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(133, 106);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 12;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(369, 160);
            Controls.Add(button1);
            Controls.Add(denominatorResult);
            Controls.Add(numeratorResult);
            Controls.Add(wholeResult);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(wholeNumber2);
            Controls.Add(comboBox1);
            Controls.Add(denominator1);
            Controls.Add(numerator1);
            Controls.Add(wholeNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox wholeNumber1;
        private TextBox numerator1;
        private TextBox denominator1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox wholeNumber2;
        private Label label1;
        private TextBox denominatorResult;
        private TextBox numeratorResult;
        private TextBox wholeResult;
        private Button button1;
    }
}
