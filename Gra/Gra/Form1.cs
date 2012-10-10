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
        static int x = 0, komputer, czlowiek, wynik_komp = 0, wynik_czlowiek = 0, licznik = 0, ponownie;
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void Gracz_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int komputer = r.Next(3);
            if (label2.Text != "............." & label4.Text != "..")
            {
                x = Convert.ToInt32(label4.Text);
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                MessageBox.Show("Gratulacja Spełniasz wszystkie warunki " + wynik_komp);
                //while (wynik_czlowiek < x && wynik_komp < x)
                //{
                //}
                
            }
            else
            {
                MessageBox.Show("Najpierw uzupełnij Imie gracza oraz ilość wygranych!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int czlowiek = 1;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            silnik();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int czlowiek = 0;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            silnik();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int czlowiek = 2;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            silnik();
        }

        private void silnik()
        {
            if (czlowiek == 0 && komputer == 0)
            {
                MessageBox.Show("Remis ;] Komputer wybrał papier.");
            }
            else if (czlowiek == 0 && komputer == 1)
            {
                MessageBox.Show("Przegrałeś ;( Komputer wybrał nożyczki.");
            }
            else if (czlowiek == 0 && komputer == 2)
            {
                MessageBox.Show("Wygrałeś ;)) Komputer wybrał kamień.");
            }
            else if (czlowiek == 1 && komputer == 0)
            {
                MessageBox.Show("Wygrałeś ;)) Komputer wybrał papier.");
            }
            else if (czlowiek == 1 && komputer == 1)
            {
                MessageBox.Show("Remis ;] Komputer wybrał nożyczki.");
            }
            else if (czlowiek == 1 && komputer == 2)
            {
                MessageBox.Show("Przegrałeś ;( Komputer wybrał kamień.");
            }
        }
    }
}
