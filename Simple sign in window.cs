using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            label1.ForeColor = Color.Red;
            label1.Font = new Font("Splash", 16);
            label2.Font = new Font("Splash", 10);
            label2.Font = new Font("Splash", 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "SolafKmail" && textBox2.Text == "123")
            {
               MessageBox.Show("Hello");
            }
            else
            {
                MessageBox.Show("There are an error!");
            }
        }
        int counter = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (counter ==1)
            {
                this.BackColor = Color.Goldenrod;
                counter++;
            }
            else if(counter == 2)
            {
                this.BackColor = Color.SkyBlue;
                counter++;
            }
            else
            {
                this.BackColor = default;
                counter = 1;
            }
        }
    }
}
