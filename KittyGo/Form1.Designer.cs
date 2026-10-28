namespace KittyGo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.platform5 = new System.Windows.Forms.PictureBox();
            this.platform6 = new System.Windows.Forms.PictureBox();
            this.platform7 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin5 = new System.Windows.Forms.PictureBox();
            this.coin6 = new System.Windows.Forms.PictureBox();
            this.coin7 = new System.Windows.Forms.PictureBox();
            this.coin8 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(672, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(95, 22);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::KittyGo.Properties.Resources.player11;
            this.player.Location = new System.Drawing.Point(304, 395);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(44, 57);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.Image = global::KittyGo.Properties.Resources.door_closed;
            this.door.Location = new System.Drawing.Point(50, 60);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(74, 90);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door.TabIndex = 2;
            this.door.TabStop = false;
            this.door.Tag = "door";
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.Image = global::KittyGo.Properties.Resources.key1;
            this.key.Location = new System.Drawing.Point(1436, 409);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(40, 40);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key.TabIndex = 3;
            this.key.TabStop = false;
            this.key.Tag = "key";
            // 
            // platform1
            // 
            this.platform1.Image = global::KittyGo.Properties.Resources.platform1;
            this.platform1.Location = new System.Drawing.Point(0, 550);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(690, 50);
            this.platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1.TabIndex = 4;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
            // 
            // platform2
            // 
            this.platform2.Image = global::KittyGo.Properties.Resources.platform1;
            this.platform2.Location = new System.Drawing.Point(0, 150);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(160, 50);
            this.platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2.TabIndex = 5;
            this.platform2.TabStop = false;
            this.platform2.Tag = "platform";
            // 
            // platform3
            // 
            this.platform3.Image = global::KittyGo.Properties.Resources.platform1;
            this.platform3.Location = new System.Drawing.Point(337, 263);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(160, 50);
            this.platform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3.TabIndex = 6;
            this.platform3.TabStop = false;
            this.platform3.Tag = "platform";
            // 
            // platform4
            // 
            this.platform4.Image = global::KittyGo.Properties.Resources.platform1;
            this.platform4.Location = new System.Drawing.Point(603, 402);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(160, 50);
            this.platform4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform4.TabIndex = 7;
            this.platform4.TabStop = false;
            this.platform4.Tag = "platform";
            // 
            // platform5
            // 
            this.platform5.Image = global::KittyGo.Properties.Resources.platform1;
            this.platform5.Location = new System.Drawing.Point(689, 128);
            this.platform5.Name = "platform5";
            this.platform5.Size = new System.Drawing.Size(160, 50);
            this.platform5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5.TabIndex = 8;
            this.platform5.TabStop = false;
            this.platform5.Tag = "platform";
            // 
            // platform6
            // 
            this.platform6.Image = global::KittyGo.Properties.Resources.platform1;
            this.platform6.Location = new System.Drawing.Point(1036, 320);
            this.platform6.Name = "platform6";
            this.platform6.Size = new System.Drawing.Size(160, 50);
            this.platform6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform6.TabIndex = 9;
            this.platform6.TabStop = false;
            this.platform6.Tag = "platform";
            // 
            // platform7
            // 
            this.platform7.Image = global::KittyGo.Properties.Resources.platform1;
            this.platform7.Location = new System.Drawing.Point(1324, 449);
            this.platform7.Name = "platform7";
            this.platform7.Size = new System.Drawing.Size(160, 50);
            this.platform7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform7.TabIndex = 10;
            this.platform7.TabStop = false;
            this.platform7.Tag = "platform";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = global::KittyGo.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(373, 222);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(32, 32);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 11;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = global::KittyGo.Properties.Resources.coin;
            this.coin2.Location = new System.Drawing.Point(426, 222);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(32, 32);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 12;
            this.coin2.TabStop = false;
            this.coin2.Tag = "coin";
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.Image = global::KittyGo.Properties.Resources.coin;
            this.coin3.Location = new System.Drawing.Point(724, 90);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(32, 32);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 13;
            this.coin3.TabStop = false;
            this.coin3.Tag = "coin";
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Transparent;
            this.coin4.Image = global::KittyGo.Properties.Resources.coin;
            this.coin4.Location = new System.Drawing.Point(778, 90);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(32, 32);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 14;
            this.coin4.TabStop = false;
            this.coin4.Tag = "coin";
            // 
            // coin5
            // 
            this.coin5.BackColor = System.Drawing.Color.Transparent;
            this.coin5.Image = global::KittyGo.Properties.Resources.coin;
            this.coin5.Location = new System.Drawing.Point(1060, 281);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(32, 32);
            this.coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin5.TabIndex = 15;
            this.coin5.TabStop = false;
            this.coin5.Tag = "coin";
            // 
            // coin6
            // 
            this.coin6.BackColor = System.Drawing.Color.Transparent;
            this.coin6.Image = global::KittyGo.Properties.Resources.coin;
            this.coin6.Location = new System.Drawing.Point(1113, 281);
            this.coin6.Name = "coin6";
            this.coin6.Size = new System.Drawing.Size(32, 32);
            this.coin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin6.TabIndex = 16;
            this.coin6.TabStop = false;
            this.coin6.Tag = "coin";
            // 
            // coin7
            // 
            this.coin7.BackColor = System.Drawing.Color.Transparent;
            this.coin7.Image = global::KittyGo.Properties.Resources.coin;
            this.coin7.Location = new System.Drawing.Point(1361, 411);
            this.coin7.Name = "coin7";
            this.coin7.Size = new System.Drawing.Size(32, 32);
            this.coin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin7.TabIndex = 17;
            this.coin7.TabStop = false;
            this.coin7.Tag = "coin";
            // 
            // coin8
            // 
            this.coin8.BackColor = System.Drawing.Color.Transparent;
            this.coin8.Image = global::KittyGo.Properties.Resources.coin;
            this.coin8.Location = new System.Drawing.Point(1415, 411);
            this.coin8.Name = "coin8";
            this.coin8.Size = new System.Drawing.Size(32, 32);
            this.coin8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin8.TabIndex = 18;
            this.coin8.TabStop = false;
            this.coin8.Tag = "coin";
            // 
            // background
            // 
            this.background.Image = global::KittyGo.Properties.Resources.background11;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(2400, 600);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 19;
            this.background.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(78, 173, 245);
            this.ClientSize = new System.Drawing.Size(1440, 600);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.door);
            this.Controls.Add(this.key);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform5);
            this.Controls.Add(this.platform6);
            this.Controls.Add(this.platform7);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin5);
            this.Controls.Add(this.coin6);
            this.Controls.Add(this.coin7);
            this.Controls.Add(this.coin8);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Kitty Go";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox platform4;
        private System.Windows.Forms.PictureBox platform5;
        private System.Windows.Forms.PictureBox platform6;
        private System.Windows.Forms.PictureBox platform7;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin5;
        private System.Windows.Forms.PictureBox coin6;
        private System.Windows.Forms.PictureBox coin7;
        private System.Windows.Forms.PictureBox coin8;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Timer GameTimer;
    }
}
