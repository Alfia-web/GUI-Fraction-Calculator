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
            try
            {
                var numerator = int.Parse(numerator1.Text);
            }
            catch (FormatException)
            {
                numerator1.Clear();
            }
        }

        private void wholeNumber1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var wholeNumber = int.Parse(wholeNumber1.Text);
            }
            catch (FormatException)
            {
                wholeNumber1.Clear();
            }
        }

        private void wholeNumber2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var wholeNumber = int.Parse(wholeNumber2.Text);
            }
            catch (FormatException)
            {
                wholeNumber2.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var numeric2 = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                textBox2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var wholeNumber = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                textBox1.Clear();
            }
        }

        private void denominator1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var denominator = int.Parse(denominator1.Text);
            }
            catch (FormatException)
            {
                denominator1.Clear();
            }
        }
    }
}
