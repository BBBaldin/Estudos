using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jokenpo
{
    public partial class Form1 : Form
    {
        int vpc = 0, vjog = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbPedra_CheckedChanged(object sender, EventArgs e)
        {
            ptbJogador.Image = jokenpo.Properties.Resources.pedra;
        }

        private void rdbPapel_CheckedChanged(object sender, EventArgs e)
        {
            ptbJogador.Image = jokenpo.Properties.Resources.papel;
        }

        private void rdbTesoura_CheckedChanged(object sender, EventArgs e)
        {
            ptbJogador.Image = jokenpo.Properties.Resources.tesoura;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int escolhaPC = rdm.Next(1, 4); // 1 Pedra 2 Papel 3 Tesoura
            

            if (rdbPedra.Checked && escolhaPC == 1)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.pedra;
                ptbComputador.Image = jokenpo.Properties.Resources.pedra;
                MessageBox.Show("Empate!");
            }
            else if (rdbPedra.Checked && escolhaPC == 2)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.pedra;
                ptbComputador.Image = jokenpo.Properties.Resources.papel;
                vpc++;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("erro3.wav");
                sound.Play();
                MessageBox.Show("Computador Ganhou!");                
            }
            else if (rdbPedra.Checked && escolhaPC == 3)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.pedra;
                ptbComputador.Image = jokenpo.Properties.Resources.tesoura;
                vjog++;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("acerto1.wav");
                sound.Play();
                MessageBox.Show("Jogador Ganhou!");
            }
            else if (rdbPapel.Checked && escolhaPC == 1)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.papel;
                ptbComputador.Image = jokenpo.Properties.Resources.pedra;
                vjog++;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("acerto1.wav");
                sound.Play();
                MessageBox.Show("Jogador Ganhou!");
            }
            else if (rdbPapel.Checked && escolhaPC == 2)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.papel;
                ptbComputador.Image = jokenpo.Properties.Resources.papel;                
                MessageBox.Show("Empate!");
            }
            else if (rdbPapel.Checked && escolhaPC == 3)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.papel;
                ptbComputador.Image = jokenpo.Properties.Resources.tesoura;
                vpc++;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("erro3.wav");
                sound.Play();
                MessageBox.Show("Computador Ganhou!");
            }
            else if (rdbTesoura.Checked && escolhaPC == 1)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.tesoura;
                ptbComputador.Image = jokenpo.Properties.Resources.pedra;
                vpc++;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("erro3.wav");
                sound.Play();
                MessageBox.Show("Computador Ganhou!");
            }
            else if (rdbTesoura.Checked && escolhaPC == 2)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.tesoura;
                ptbComputador.Image = jokenpo.Properties.Resources.papel;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer("acerto1.wav");
                sound.Play();
                vjog++;                
                MessageBox.Show("Jogador Ganhou!");
            }
            else if (rdbTesoura.Checked && escolhaPC == 3)
            {
                ptbJogador.Image = jokenpo.Properties.Resources.tesoura;
                ptbComputador.Image = jokenpo.Properties.Resources.tesoura;
                MessageBox.Show("Empate!");
            }
            lblComputador.Text = $"Computador : {vpc}";
            lblJogador.Text = $"Jogador : {vjog}";
        }
    }
}
