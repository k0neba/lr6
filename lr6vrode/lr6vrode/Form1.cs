namespace lr6vrode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double x1, x2;
            x1 = Convert.ToDouble(textBox1.Text);
            x2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(Math.Pow(x1, 2) + (x2 * 3));
            textBox4.Text = Convert.ToString((x1 + x2) / 2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
             Close();
        }
    }
}
