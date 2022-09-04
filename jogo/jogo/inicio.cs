using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class inicio : Form
    {
        public int tempo = 20, mortes = 0;
        public int velocidade = 1000;



        public inicio()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mensagem = new Form1();
            mensagem.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            int y = 0;
            int x = 0;

            Random aleatorio = new Random();

            y = aleatorio.Next(0, 278);
            x = aleatorio.Next(0, 600);

            pictureBox1.Location = new Point(x, y);
            pictureBox2.Location = new Point(x, y);

       
          
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            label4.Text = Convert.ToString(mortes);

            mortes = mortes + 1;
            velocidade= velocidade - 50;
            timer1.Interval = velocidade;
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inicio mensagem = new inicio();
            mensagem.Show();
            this.Close();
            velocidade = 1000;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tempo--;
            label3.Text = Convert.ToString(tempo);
            

            if (tempo == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

                if(tempo == 0 && mortes <= 9)
                {
                    pictureBox4.Visible = true;
                }
                else if (tempo == 0 && mortes >=10)
                {
                    pictureBox3.Visible = true;
                }

            }
        }
    }
}
