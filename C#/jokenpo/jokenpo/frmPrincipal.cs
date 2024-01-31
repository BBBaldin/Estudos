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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            //f1.Show();
            Hide();
            f1.ShowDialog();
            Show();
        }
    }
}
