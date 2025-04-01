namespace CollegeFestEventApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(people.Text);
            if (n < 0)
            {
                MessageBox.Show("You are stupid");
                return;
            }

            listbox.Items.Add($"College is hosting a fest for {n} people.");
            listbox.Items.Add($"Catering Bill for {n} people: Rs {n * 200}");
            listbox.Items.Add($"Decoration Bill for {n} people: Rs {n * 10}");

        }
      
        
    }
}
