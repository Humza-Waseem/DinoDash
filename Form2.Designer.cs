
namespace DinoHunter
{
    partial class Form2
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
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.Player = new System.Windows.Forms.PictureBox();
            this.neelaDino = new System.Windows.Forms.PictureBox();
            this.OrangeDino = new System.Windows.Forms.PictureBox();
            this.cyberDino = new System.Windows.Forms.PictureBox();
            this.UrnayWalaDino = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neelaDino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangeDino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyberDino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrnayWalaDino)).BeginInit();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(217, 495);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblScore.Location = new System.Drawing.Point(312, 495);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 26);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(354, 504);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(116, 12);
            this.HealthBar.TabIndex = 11;
            this.HealthBar.Value = 100;
            // 
            // Player
            // 
            this.Player.Image = global::DinoHunter.Properties.Resources.NewHunter__1___1___1_;
            this.Player.Location = new System.Drawing.Point(39, 156);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 10;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            // 
            // neelaDino
            // 
            this.neelaDino.Image = global::DinoHunter.Properties.Resources.DInosourEnemyCyber;
            this.neelaDino.Location = new System.Drawing.Point(1066, 349);
            this.neelaDino.Name = "neelaDino";
            this.neelaDino.Size = new System.Drawing.Size(130, 90);
            this.neelaDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.neelaDino.TabIndex = 8;
            this.neelaDino.TabStop = false;
            this.neelaDino.Tag = "enemy";
            // 
            // OrangeDino
            // 
            this.OrangeDino.Image = global::DinoHunter.Properties.Resources.DinoOrange__1_;
            this.OrangeDino.Location = new System.Drawing.Point(586, 156);
            this.OrangeDino.Name = "OrangeDino";
            this.OrangeDino.Size = new System.Drawing.Size(150, 78);
            this.OrangeDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OrangeDino.TabIndex = 7;
            this.OrangeDino.TabStop = false;
            this.OrangeDino.Tag = "enemy";
            // 
            // cyberDino
            // 
            this.cyberDino.Image = global::DinoHunter.Properties.Resources.DInoCyber1;
            this.cyberDino.Location = new System.Drawing.Point(680, 355);
            this.cyberDino.Name = "cyberDino";
            this.cyberDino.Size = new System.Drawing.Size(150, 84);
            this.cyberDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cyberDino.TabIndex = 6;
            this.cyberDino.TabStop = false;
            this.cyberDino.Tag = "enemy";
            // 
            // UrnayWalaDino
            // 
            this.UrnayWalaDino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UrnayWalaDino.Image = global::DinoHunter.Properties.Resources.dinoFlying;
            this.UrnayWalaDino.Location = new System.Drawing.Point(200, 27);
            this.UrnayWalaDino.Name = "UrnayWalaDino";
            this.UrnayWalaDino.Size = new System.Drawing.Size(180, 145);
            this.UrnayWalaDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UrnayWalaDino.TabIndex = 4;
            this.UrnayWalaDino.TabStop = false;
            this.UrnayWalaDino.Tag = "enemy";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1256, 528);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.neelaDino);
            this.Controls.Add(this.OrangeDino);
            this.Controls.Add(this.cyberDino);
            this.Controls.Add(this.UrnayWalaDino);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neelaDino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangeDino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyberDino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrnayWalaDino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox UrnayWalaDino;
        private System.Windows.Forms.PictureBox cyberDino;
        private System.Windows.Forms.PictureBox OrangeDino;
        private System.Windows.Forms.PictureBox neelaDino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.ProgressBar HealthBar;
    }
}