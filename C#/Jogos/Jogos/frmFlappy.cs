using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace Jogos
{
    public partial class frmFlappy : Form
    {
        ISoundEngine sound = new ISoundEngine();
        public frmFlappy()
        {
            InitializeComponent();
        }

        private void frmFlappy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
            }
            else if (e.KeyCode == Keys.Space)
            {
                ptbBird.Top -= 60;
                sound.Play2D("som\\flap.wav");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (ptbBird.Bounds.IntersectsWith(pnlGround.Bounds))
            {
                timer1.Stop();
                ptbBird.Top -= 16;
                sound.Play2D("som\\hit.wav");                
            }
            else if (ptbBird.Bounds.IntersectsWith(pnlCima.Bounds))
            {
                timer1.Stop();
                pnlCima.Left += 10;
                sound.Play2D("som\\hit.wav");
            }
            ptbBird.Top += 10; //gravidade
            pnlCima.Left -= 10; //cano
        }
    }
}
