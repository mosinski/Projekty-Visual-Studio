using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    label2.Text = ".............";
                    textBox1.Visible = false;
                }
                else
                {
                label2.Text = textBox1.Text;
                textBox1.Visible = false;
                } 
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBox1.Visible = false;
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == "")
                {
                    label4.Text = "..";
                    textBox2.Visible = false;
                }
                else
                {
                    label4.Text = textBox2.Text;
                    textBox2.Visible = false;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBox2.Visible = false;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }
    }
}
