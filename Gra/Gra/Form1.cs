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
        static int x = 0, komputer = 0, czlowiek = 0, wynik_komp = 0, wynik_czlowiek = 0, licznik = 0, ponownie;
        public Form1()
        {
            InitializeComponent();
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

        private void label4_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
        }

        private void Gracz_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            komputer = r.Next(3);
            if (label2.Text != "............." & label4.Text != "..")
            {
                x = Convert.ToInt32(label4.Text);
                if (wynik_czlowiek < x && wynik_komp < x)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                }
                else
                {
                    if (MessageBox.Show("Czy chcesz zagrać jeszcze raz ?", "Koniec Rozgrywki", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        wynik_komp = 0;
                        wynik_czlowiek = 0;
                        label5.Text = Convert.ToString(wynik_czlowiek);
                        label7.Text = Convert.ToString(wynik_komp);

                        MessageBox.Show("Gra rozpoczyna się na nowo");
                    }
                    else
                    {
                        MessageBox.Show("Dziękujemy za gre i zapraszamy ponownie!");
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Najpierw uzupełnij Imie gracza oraz ilość wygranych!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            czlowiek = 1;
            Gracz.Image = Properties.Resources.scissors_big;
            silnik();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            czlowiek = 0;
            Gracz.Image = Properties.Resources.paper_big;
            silnik();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            czlowiek = 2;
            Gracz.Image = Properties.Resources.rock_big;
            silnik();
        }

        private void silnik()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            if (czlowiek == 0 && komputer == 0)
            {
                Komputer.Image = Properties.Resources.paper_big;
            }
            else if (czlowiek == 0 && komputer == 1)
            {
                Komputer.Image = Properties.Resources.scissors_big;
                wynik_komp++;
                label7.Text = Convert.ToString(wynik_komp);
            }
            else if (czlowiek == 0 && komputer == 2)
            {
                Komputer.Image = Properties.Resources.rock_big;
                wynik_czlowiek++;
                label5.Text = Convert.ToString(wynik_czlowiek);
            }
            else if (czlowiek == 1 && komputer == 0)
            {
                Komputer.Image = Properties.Resources.paper_big;
                wynik_czlowiek++;
                label5.Text = Convert.ToString(wynik_czlowiek);
            }
            else if (czlowiek == 1 && komputer == 1)
            {
                Komputer.Image = Properties.Resources.scissors_big;
            }
            else if (czlowiek == 1 && komputer == 2)
            {
                Komputer.Image = Properties.Resources.rock_big;
                wynik_komp++;
                label7.Text = Convert.ToString(wynik_komp);
            }
            else if (czlowiek == 2 && komputer == 0)
            {
                Komputer.Image = Properties.Resources.paper_big;
                wynik_komp++;
                label7.Text = Convert.ToString(wynik_komp);
            }
            else if (czlowiek == 2 && komputer == 1)
            {
                Komputer.Image = Properties.Resources.scissors_big;
                wynik_czlowiek++;
                label5.Text = Convert.ToString(wynik_czlowiek);
            }
            else if (czlowiek == 2 && komputer == 2)
            {
                Komputer.Image = Properties.Resources.rock_big;
            }
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (numericUpDown1.Text == "0")
                {
                    label4.Text = "..";
                    numericUpDown1.Visible = false;
                }
                else if (numericUpDown1.Text != "0")
                {
                    label4.Text = numericUpDown1.Text;
                    numericUpDown1.Visible = false;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                numericUpDown1.Visible = false;
            }
        }
    }
}
