using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.2;
            if (this.Opacity == 1) { 
             timer2.Stop();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbJogo.Text == "FlappyBird")
            {
                frmFlappy bird = new frmFlappy();
                Hide();
                bird.ShowDialog();
                Show();
            }
            else if(cmbJogo.Text == "Mario")
            {

            }
            else if (cmbJogo.Text == "Barata")
            {

            }
            else
            {
                MessageBox.Show("Opção Inválida");
            }
        }
    }
}
