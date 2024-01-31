namespace jokenpo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJogador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbPedra = new System.Windows.Forms.RadioButton();
            this.rdbPapel = new System.Windows.Forms.RadioButton();
            this.rdbTesoura = new System.Windows.Forms.RadioButton();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblComputador = new System.Windows.Forms.Label();
            this.ptbComputador = new System.Windows.Forms.PictureBox();
            this.ptbJogador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(201, 423);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(137, 33);
            this.lblJogador.TabIndex = 2;
            this.lblJogador.Text = "Jogador : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 59);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // rdbPedra
            // 
            this.rdbPedra.AutoSize = true;
            this.rdbPedra.Checked = true;
            this.rdbPedra.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPedra.Location = new System.Drawing.Point(331, 506);
            this.rdbPedra.Name = "rdbPedra";
            this.rdbPedra.Size = new System.Drawing.Size(97, 37);
            this.rdbPedra.TabIndex = 5;
            this.rdbPedra.TabStop = true;
            this.rdbPedra.Text = "Pedra";
            this.rdbPedra.UseVisualStyleBackColor = true;
            this.rdbPedra.CheckedChanged += new System.EventHandler(this.rdbPedra_CheckedChanged);
            // 
            // rdbPapel
            // 
            this.rdbPapel.AutoSize = true;
            this.rdbPapel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPapel.Location = new System.Drawing.Point(440, 506);
            this.rdbPapel.Name = "rdbPapel";
            this.rdbPapel.Size = new System.Drawing.Size(94, 37);
            this.rdbPapel.TabIndex = 6;
            this.rdbPapel.Text = "Papel";
            this.rdbPapel.UseVisualStyleBackColor = true;
            this.rdbPapel.CheckedChanged += new System.EventHandler(this.rdbPapel_CheckedChanged);
            // 
            // rdbTesoura
            // 
            this.rdbTesoura.AutoSize = true;
            this.rdbTesoura.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTesoura.Location = new System.Drawing.Point(548, 506);
            this.rdbTesoura.Name = "rdbTesoura";
            this.rdbTesoura.Size = new System.Drawing.Size(120, 37);
            this.rdbTesoura.TabIndex = 7;
            this.rdbTesoura.Text = "Tesoura";
            this.rdbTesoura.UseVisualStyleBackColor = true;
            this.rdbTesoura.CheckedChanged += new System.EventHandler(this.rdbTesoura_CheckedChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(420, 575);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(151, 49);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblComputador
            // 
            this.lblComputador.AutoSize = true;
            this.lblComputador.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputador.Location = new System.Drawing.Point(616, 423);
            this.lblComputador.Name = "lblComputador";
            this.lblComputador.Size = new System.Drawing.Size(188, 33);
            this.lblComputador.TabIndex = 9;
            this.lblComputador.Text = "Computador : 0";
            // 
            // ptbComputador
            // 
            this.ptbComputador.Image = global::jokenpo.Properties.Resources.tesoura;
            this.ptbComputador.Location = new System.Drawing.Point(598, 113);
            this.ptbComputador.Name = "ptbComputador";
            this.ptbComputador.Size = new System.Drawing.Size(234, 251);
            this.ptbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbComputador.TabIndex = 1;
            this.ptbComputador.TabStop = false;
            // 
            // ptbJogador
            // 
            this.ptbJogador.Image = global::jokenpo.Properties.Resources.tesoura;
            this.ptbJogador.Location = new System.Drawing.Point(168, 113);
            this.ptbJogador.Name = "ptbJogador";
            this.ptbJogador.Size = new System.Drawing.Size(234, 251);
            this.ptbJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbJogador.TabIndex = 0;
            this.ptbJogador.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 733);
            this.Controls.Add(this.lblComputador);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.rdbTesoura);
            this.Controls.Add(this.rdbPapel);
            this.Controls.Add(this.rdbPedra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.ptbComputador);
            this.Controls.Add(this.ptbJogador);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbJogador;
        private System.Windows.Forms.PictureBox ptbComputador;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbPedra;
        private System.Windows.Forms.RadioButton rdbPapel;
        private System.Windows.Forms.RadioButton rdbTesoura;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblComputador;
    }
}

