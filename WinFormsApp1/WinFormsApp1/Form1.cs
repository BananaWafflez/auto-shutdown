namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            if (numericUpDown1.Value > 23) {
                MessageBox.Show("Sorry, thats not a valid time");
                numericUpDown1.Value = 0;
            }
            
            
        }
    }
}