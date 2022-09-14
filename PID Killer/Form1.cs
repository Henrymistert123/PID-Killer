using System.Diagnostics;

namespace PID_Killer
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

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/Ctaskkill /f /pid " + textBox1.Text);
        }
    }
}