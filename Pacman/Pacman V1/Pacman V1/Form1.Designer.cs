namespace Pacman_V1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.redghost = new System.Windows.Forms.PictureBox();
            this.blueGhost = new System.Windows.Forms.PictureBox();
            this.orangeGhost = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(52, 15);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: 0";
            // 
            // pacman
            // 
            this.pacman.Image = global::Pacman_V1.Properties.Resources.Pacman;
            this.pacman.Location = new System.Drawing.Point(66, 86);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(50, 50);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pacman.TabIndex = 2;
            this.pacman.TabStop = false;
            // 
            // redghost
            // 
            this.redghost.Image = global::Pacman_V1.Properties.Resources.clied;
            this.redghost.Location = new System.Drawing.Point(181, 231);
            this.redghost.Name = "redghost";
            this.redghost.Size = new System.Drawing.Size(50, 50);
            this.redghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redghost.TabIndex = 3;
            this.redghost.TabStop = false;
            this.redghost.Tag = "ghost";
            // 
            // blueGhost
            // 
            this.blueGhost.Image = global::Pacman_V1.Properties.Resources.dinki;
            this.blueGhost.Location = new System.Drawing.Point(181, 86);
            this.blueGhost.Name = "blueGhost";
            this.blueGhost.Size = new System.Drawing.Size(35, 35);
            this.blueGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueGhost.TabIndex = 4;
            this.blueGhost.TabStop = false;
            this.blueGhost.Tag = "ghost";
            // 
            // orangeGhost
            // 
            this.orangeGhost.Image = global::Pacman_V1.Properties.Resources.inki;
            this.orangeGhost.Location = new System.Drawing.Point(75, 161);
            this.orangeGhost.Name = "orangeGhost";
            this.orangeGhost.Size = new System.Drawing.Size(50, 50);
            this.orangeGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orangeGhost.TabIndex = 5;
            this.orangeGhost.TabStop = false;
            this.orangeGhost.Tag = "ghost";
            // 
            // pinkGhost
            // 
            this.pinkGhost.Image = global::Pacman_V1.Properties.Resources.pinki;
            this.pinkGhost.Location = new System.Drawing.Point(181, 161);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(50, 50);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pinkGhost.TabIndex = 6;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // TIMER
            // 
            this.TIMER.Interval = 40;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.orangeGhost);
            this.Controls.Add(this.blueGhost);
            this.Controls.Add(this.redghost);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtScore;
        private PictureBox pacman;
        private PictureBox redghost;
        private PictureBox blueGhost;
        private PictureBox orangeGhost;
        private PictureBox pinkGhost;
        private System.Windows.Forms.Timer TIMER;
    }
}