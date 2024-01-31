using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genius
{
    public partial class Form1 : Form
    {
        List<int> lstImagens = new List<int>();
        Random rdn = new Random();
        Bitmap[] vetImagens = {Properties.Resources.vermelho, Properties.Resources.verde, Properties.Resources.amarelo, Properties.Resources.azul};
        int contVoltas = 0, contRodadas = 1, contJogada = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                ptbGenius.Image = Properties.Resources.vermelho;
                verificarJogada(0);
            }
            else if (e.KeyCode == Keys.A)
            {
                ptbGenius.Image = Properties.Resources.verde;
                verificarJogada(1);
            }
            else if (e.KeyCode == Keys.S)
            {
                ptbGenius.Image = Properties.Resources.amarelo;
                verificarJogada(2);
            }
            else if (e.KeyCode == Keys.D)
            {
                ptbGenius.Image = Properties.Resources.azul;
                verificarJogada(3);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            ptbGenius.Image = Properties.Resources.padrao;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20; i++)
            {
                lstImagens.Add(rdn.Next(0, 4));
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contVoltas < contRodadas)
            {
                ptbGenius.Image = vetImagens[lstImagens[contVoltas]];
                timer1.Stop();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                contVoltas = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ptbGenius.Image = Properties.Resources.padrao;
            timer2.Stop();
            contVoltas++;
            timer1.Start();
        }

        public void verificarJogada(int tecla)
        {
            if (tecla == lstImagens[contJogada] && contJogada < contRodadas)
            {
                contJogada++;
                label1.Text = "Acertou!";
            }
            else
            {
                label1.Text = "Errou!";
            }
            if (contJogada >= contRodadas)
            {
                contJogada = 0;
                contRodadas++;
                timer3.Start();
            }
        }
    }
} 