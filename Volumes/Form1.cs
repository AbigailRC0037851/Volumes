using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumes
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

        private void PictureBox3_Click(object sender, EventArgs e)
        {
                    }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius;

            try
            {
                radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("not correct value");
                radius = 0.0;
            }
            double surfacearea = 4.0 * Math.PI * radius * radius;
            label2.Text = "=" + surfacearea;
        }
    }
}
