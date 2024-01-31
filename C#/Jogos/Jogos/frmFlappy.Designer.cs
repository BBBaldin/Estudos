namespace Jogos
{
    partial class frmFlappy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlGround = new System.Windows.Forms.Panel();
            this.ptbBird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCima = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGround
            // 
            this.pnlGround.BackgroundImage = global::Jogos.Properties.Resources.ground_bird;
            this.pnlGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGround.Location = new System.Drawing.Point(0, 561);
            this.pnlGround.Name = "pnlGround";
            this.pnlGround.Size = new System.Drawing.Size(502, 114);
            this.pnlGround.TabIndex = 0;
            // 
            // ptbBird
            // 
            this.ptbBird.Image = global::Jogos.Properties.Resources.bird_gif;
            this.ptbBird.Location = new System.Drawing.Point(24, 50);
            this.ptbBird.Name = "ptbBird";
            this.ptbBird.Size = new System.Drawing.Size(67, 57);
            this.ptbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBird.TabIndex = 1;
            this.ptbBird.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlCima
            // 
            this.pnlCima.BackgroundImage = global::Jogos.Properties.Resources.tubocima;
            this.pnlCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCima.Location = new System.Drawing.Point(385, 0);
            this.pnlCima.Name = "pnlCima";
            this.pnlCima.Size = new System.Drawing.Size(90, 248);
            this.pnlCima.TabIndex = 2;
            // 
            // frmFlappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(502, 675);
            this.Controls.Add(this.pnlCima);
            this.Controls.Add(this.ptbBird);
            this.Controls.Add(this.pnlGround);
            this.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "frmFlappy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFlappy";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFlappy_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGround;
        private System.Windows.Forms.PictureBox ptbBird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlCima;
    }
}