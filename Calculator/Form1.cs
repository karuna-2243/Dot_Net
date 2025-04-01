namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String num1 = "";
       
        String op = "";
        int num11;
        int num22;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void five_Click(object sender, EventArgs e)
        {
            num1 += "5";
            textBox1.Text = num1;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            num1 += "0";
            textBox1.Text = num1;
        }

        private void six_Click(object sender, EventArgs e)
        {
            num1 += "6";
            textBox1.Text = num1;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            num1 += "8";
            textBox1.Text = num1;
        }

        private void one_Click(object sender, EventArgs e)
        {
            num1 += "1";
            textBox1.Text = num1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            num1 += "2";
            textBox1.Text = num1;
        }

        private void three_Click(object sender, EventArgs e)
        {
            num1 += "3";
            textBox1.Text = num1;

        }

        private void four_Click(object sender, EventArgs e)
        {
            num1 += "4";
            textBox1.Text = num1;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            num1 += "7";
            textBox1.Text = num1;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            num1 += "9";
            textBox1.Text = num1;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1 = "";
            textBox1.Clear();

        }

        private void equal_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            String oper= op;
           int num22 = int.Parse(num1);

            if (oper == "+")
            {
                int result = num11 + num22;
                textBox1.Text = result.ToString();
            }
            else if (oper == "-")
            {
                int result = num11 - num22;
                textBox1.Text = result.ToString();
            }
            else if (oper == "*")
            {
                int result = num11 * num22;
                textBox1.Text = result.ToString();
            }
            else if (oper == "/")
            {
                int result = num11 / num22;
                textBox1.Text = result.ToString();
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            num11 = int.Parse(num1);
            num1 = "";
            op = "+";
            textBox1.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            num11 = int.Parse(num1);
            num1 = "";
            op = "-";
            textBox1.Clear();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            num11 = int.Parse(num1);
            num1 = "";
            op = "*";
            textBox1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            num11 = int.Parse(num1);
            num1 = "";
            op = "/";
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }






    }
}
