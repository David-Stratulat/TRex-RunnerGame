namespace TRex
{
    partial class TRexMainClass
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
            this.trexPictureBox = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtHighScoreLabel = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // trexPictureBox
            // 
            this.trexPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.trexPictureBox.Image = global::TRex_RunnerGame.Properties.Resources.running;
            this.trexPictureBox.Location = new System.Drawing.Point(188, 550);
            this.trexPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trexPictureBox.Name = "trexPictureBox";
            this.trexPictureBox.Size = new System.Drawing.Size(40, 43);
            this.trexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trexPictureBox.TabIndex = 0;
            this.trexPictureBox.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.BackColor = System.Drawing.Color.Transparent;
            this.obstacle2.Image = global::TRex_RunnerGame.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(843, 580);
            this.obstacle2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(32, 33);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 1;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // obstacle1
            // 
            this.obstacle1.BackColor = System.Drawing.Color.Transparent;
            this.obstacle1.Image = global::TRex_RunnerGame.Properties.Resources.obstacle_1;
            this.obstacle1.Location = new System.Drawing.Point(531, 554);
            this.obstacle1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 2;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(-14, 634);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1224, 62);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // txtScoreLabel
            // 
            this.txtScoreLabel.AutoSize = true;
            this.txtScoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtScoreLabel.Location = new System.Drawing.Point(20, 20);
            this.txtScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScoreLabel.Name = "txtScoreLabel";
            this.txtScoreLabel.Size = new System.Drawing.Size(161, 37);
            this.txtScoreLabel.TabIndex = 4;
            this.txtScoreLabel.Text = "Score: 0";
            // 
            // txtHighScoreLabel
            // 
            this.txtHighScoreLabel.AutoSize = true;
            this.txtHighScoreLabel.Location = new System.Drawing.Point(496, 274);
            this.txtHighScoreLabel.Name = "txtHighScoreLabel";
            this.txtHighScoreLabel.Size = new System.Drawing.Size(0, 20);
            this.txtHighScoreLabel.TabIndex = 5;
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.HighScoreLabel.Location = new System.Drawing.Point(438, 294);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(251, 37);
            this.HighScoreLabel.TabIndex = 6;
            this.HighScoreLabel.Text = "High Score: 0";
            // 
            // TRexMainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.txtHighScoreLabel);
            this.Controls.Add(this.txtScoreLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.trexPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TRexMainClass";
            this.Text = "TRex-RunnerGame";
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trexPictureBox;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txtScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtHighScoreLabel;
        private System.Windows.Forms.Label HighScoreLabel;
    }
}

