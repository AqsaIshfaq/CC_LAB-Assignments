
using System.Text.RegularExpressions;

namespace Regularexpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(tex_pattern.Text);
            bool result = reg.IsMatch(text_tex.Text);
            label.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}