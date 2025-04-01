namespace Assign4_WindowForm_Tshirt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }

        private void cal_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(input.Text);

            int price = 0;
            if (s.Checked)
            {
                price = 125;
            }
            else if (m.Checked)
            {
                price = 175;
            }
            else if (l.Checked)
            {
                price = 250;
            }
            else
            {
                MessageBox.Show("Please select a size");
            }


            String c = code.Text;
            if (c.Equals("TRUEBLUE"))
            {
                price = price * n;
                price = price - (price * 10 / 100);
                price = price + (price * 9 / 100);

            }
            else
            {
                price = price * n;
                price = price + (price * 9 / 100);

            }


            //print to the final boxLl
            p.Text = price.ToString();

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
