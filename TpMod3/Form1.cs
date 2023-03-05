using System.Reflection.Emit;

namespace TpMod3
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

        private void button1_Click(object sender, EventArgs e)
        {
            string button = textBox1.Text;
            label1.Text = "Halooooo!!! " + button;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}