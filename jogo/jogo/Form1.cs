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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inicio mensagem = new inicio();
            mensagem.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Derrote 10 Batman ou mais em 20 segundos para ganhar o jogo, caso derrotar menos de 10 Batmas você perdera o game. A velocidade dos Batmas aumenta conforme você os mata. Para matar um Batman basta apertar nele. Boa sorte e seja rápido.");
        }
    }
}
