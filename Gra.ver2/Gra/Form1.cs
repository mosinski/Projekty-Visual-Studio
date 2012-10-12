using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Form1 : Form
    {
        static int x = 0, komputer = 0, czlowiek = 0, wynik_komp = 0, wynik_czlowiek = 0, sound = 1;
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


        private void label4_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
        }

        private void Gracz_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            komputer = r.Next(5);
            if (label2.Text != "............." & label4.Text != "..")
            {
                x = Convert.ToInt32(label4.Text);
                if (wynik_czlowiek < x && wynik_komp < x)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                }
                else
                {
                    if (MessageBox.Show("Czy chcesz zagrać jeszcze raz ?", "Koniec Rozgrywki", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        wynik_komp = 0;
                        wynik_czlowiek = 0;
                        label5.Text = Convert.ToString(wynik_czlowiek);
                        label7.Text = Convert.ToString(wynik_komp);
                        Gracz.Image = Properties.Resources.question_md;
                        Komputer.Image = Properties.Resources.computer_md;

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

        //reakcja po naciśnieciu odpowiedniego obrazka
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            czlowiek = 3;
            Gracz.Image = Properties.Resources.spock_big;
            silnik();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            czlowiek = 4;
            Gracz.Image = Properties.Resources.lizard_big;
            silnik();
        }

        private void silnik()
        {
            //ukrycie obrazków wyboru
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            //podniesienie wyniku komputera za każdy wygrany przypadek
            if ((czlowiek == 0 && komputer == 1) || (czlowiek == 0 && komputer == 4) || (czlowiek == 1 && komputer == 2) || (czlowiek == 1 && komputer == 3) || (czlowiek == 2 && komputer == 0) || (czlowiek == 2 && komputer == 3) || (czlowiek == 3 && komputer == 0) || (czlowiek == 3 && komputer == 4) || (czlowiek == 4 && komputer == 1) || (czlowiek == 4 && komputer == 2))
            {
                wynik_komp++;
                label7.Text = Convert.ToString(wynik_komp);
            }

            //podniesienie wyniku komputera za każdy wygrany przypadek
            else if ((czlowiek == 0 && komputer == 2) || (czlowiek == 0 && komputer == 3) || (czlowiek == 1 && komputer == 0) || (czlowiek == 1 && komputer == 4) || (czlowiek == 2 && komputer == 1) || (czlowiek == 2 && komputer == 4) || (czlowiek == 3 && komputer == 1) || (czlowiek == 3 && komputer == 2) || (czlowiek == 4 && komputer == 0) || (czlowiek == 4 && komputer == 3))
            {
                wynik_czlowiek++;
                label5.Text = Convert.ToString(wynik_czlowiek);
            }

            //przypożadkowanie wylosawanej liczbie komputera odpowiedni obrazek
            if (komputer == 0)
            {
                Komputer.Image = Properties.Resources.paper_big;
            }
            else if (komputer == 1)
            {
                Komputer.Image = Properties.Resources.scissors_big;
            }
            else if (komputer == 2)
            {
                Komputer.Image = Properties.Resources.rock_big;
            }
            else if (komputer == 3)
            {
                Komputer.Image = Properties.Resources.spock_big;
            }
            else if (komputer == 4)
            {
                Komputer.Image = Properties.Resources.lizard_big;
            }

            //odtwarzanie dźwięku
            if ((sound == 1) && (wynik_czlowiek == x) || (wynik_komp == x))
            {
                if (wynik_czlowiek > wynik_komp)
                {
                    SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.win);
                    simpleSound.Play();
                }
                else
                {
                    SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.lose);
                    simpleSound.Play();
                }
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

        private void s(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (sound == 1)
            {
                dzwiek.Image = Properties.Resources.soundoff;
                sound = 0;
            }
            else if (sound == 0)
            {
                dzwiek.Image = Properties.Resources.sound;
                sound = 1;
            }
        }
    }
}
