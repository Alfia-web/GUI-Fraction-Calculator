namespace GUI_Fraction_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numerator1_TextChanged(object sender, EventArgs e)
        {
            var text = numerator1.Text;
            if (text == "" || text == "-") return;
            if (!int.TryParse(numerator1.Text, out int value))
                numerator1.Clear();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var text = numerator2.Text;
            if (text == "" || text == "-") return;
            if (!int.TryParse(numerator2.Text, out int value))
                numerator2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var text = denominator2.Text;
            if (text == "" || text == "-") return;
            if (!int.TryParse(denominator2.Text, out int value))
                denominator2.Clear();
        }

        private void denominator1_TextChanged(object sender, EventArgs e)
        {
            var text = denominator1.Text;
            if (text == "" || text == "-") return;
            if (!int.TryParse(denominator1.Text, out int value))
                denominator1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeratorNum1 = int.Parse(numerator1.Text);
            int denominatorNum1 = int.Parse(denominator1.Text);

            int numeratorNum2 = int.Parse(numerator2.Text);
            int denominatorNum2 = int.Parse(denominator2.Text);

            Fraction f1, f2;
            try
            {
                f1 = new Fraction(numeratorNum1, denominatorNum1);
                f2 = new Fraction(numeratorNum2, denominatorNum2);

                Fraction result;
                switch (comboBox1.SelectedItem?.ToString())
                {
                    case "+":
                        result = f1 + f2;
                        break;
                    case "-":
                        result = f1 - f2;
                        break;
                    case "*":
                        result = f1 * f2;
                        break;
                    case "/":
                        result = f1 / f2;
                        break;
                    default:
                        return;
                }
                var partsResult = result.ToString().Split('/');
                numeratorResult.Text = partsResult[0];
                denominatorResult.Text = partsResult[1];
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int numeratorNum = int.Parse(textBox2.Text);
            int denominatorNum = int.Parse(textBox1.Text);
            Fraction f;
            try
            {
                f = new Fraction(numeratorNum, denominatorNum);
                Fraction result = f.Reduce();

                var partsResult = result.ToString().Split('/');
                textBox4.Text = partsResult[0];
                textBox3.Text = partsResult[1];
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            var text = textBox2.Text;
            if (text == "" || text == "-") return;
            if (!int.TryParse(textBox2.Text, out int value))
                textBox2.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var text = textBox2.Text;
            if (text == "" || text == "-") return;
            if (!int.TryParse(textBox1.Text, out int value))
                textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numeratorNum1 = int.Parse(numerator1.Text);
            int denominatorNum1 = int.Parse(denominator1.Text);

            int numeratorNum2 = int.Parse(numerator2.Text);
            int denominatorNum2 = int.Parse(denominator2.Text);

            Fraction f1, f2;
            try
            {
                f1 = new Fraction(numeratorNum1, denominatorNum1);
                f2 = new Fraction(numeratorNum2, denominatorNum2);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
            MessageBox.Show(Fraction.Compare(f1, f2));
        }
    }
}
