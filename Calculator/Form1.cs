namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2, result;
        string operation;
        private void number1Button_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void number2Button_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void number6Button_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(display.Text);
            operation = "*";
            display.Clear();
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(display.Text);
            operation = "/";
            display.Clear();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(display.Text);
            operation = "-";
            display.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(display.Text);
            operation = "+";
            display.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(display.Text);
            switch (operation)
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
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        MessageBox.Show("Cannot divide by zero.");
                    return;
                default:
                    MessageBox.Show("Invalid operation.");
                    return;
            }
            display.Text = result.ToString();
        }
    }
}
