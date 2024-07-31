namespace Kalkulacka_pro_cerny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        double num1;
        double num2;
        string option;
        double result;


        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button2.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button12.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = " + ";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = num1 + " + ";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = " - ";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = num1 + " - ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            option = " * ";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = num1 + " * ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = " / ";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = num1 + " / ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string[] parts = txtDisplay.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 3)
            {
                MessageBox.Show("Invalid format. Please ensure you've entered a valid expression.");
                return;
            }

            num1 = int.Parse(parts[0]);
            option = parts[1];
            num2 = int.Parse(parts[2]);

            switch (option)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    MessageBox.Show("Unknown operator.");
                    return;
            }

            txtDisplay.Text = txtDisplay.Text + " = " + result;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
