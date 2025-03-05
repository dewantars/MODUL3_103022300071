namespace jurnal3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Text += "4";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            output.Text += "0";
        }

        private void buttont_Click(object sender, EventArgs e)
        {
            result += Convert.ToInt32(output.Text);
            output.Text = "";
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            result += Convert.ToInt32(output.Text);
            output.Text = result.ToString();
            result = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
