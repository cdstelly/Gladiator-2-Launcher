namespace Gladiator_2_Launcher
{
    partial class frmGladiator2Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGladiator2Launcher));
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnJoinNetwork = new System.Windows.Forms.Button();
            this.btnHostNetwork = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Location = new System.Drawing.Point(12, 181);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(146, 47);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // btnJoinNetwork
            // 
            this.btnJoinNetwork.Location = new System.Drawing.Point(12, 235);
            this.btnJoinNetwork.Name = "btnJoinNetwork";
            this.btnJoinNetwork.Size = new System.Drawing.Size(146, 47);
            this.btnJoinNetwork.TabIndex = 1;
            this.btnJoinNetwork.Text = "Join Network Game";
            this.btnJoinNetwork.UseVisualStyleBackColor = true;
            this.btnJoinNetwork.Click += new System.EventHandler(this.btnJoinNetwork_Click);
            // 
            // btnHostNetwork
            // 
            this.btnHostNetwork.Location = new System.Drawing.Point(12, 288);
            this.btnHostNetwork.Name = "btnHostNetwork";
            this.btnHostNetwork.Size = new System.Drawing.Size(146, 47);
            this.btnHostNetwork.TabIndex = 2;
            this.btnHostNetwork.Text = "Host Network Game";
            this.btnHostNetwork.UseVisualStyleBackColor = true;
            this.btnHostNetwork.Click += new System.EventHandler(this.btnHostNetwork_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 178);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 341);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(146, 47);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 447);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 47);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start a single player game.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Join a game that is already in progress.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Host a game to play with other players.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Change settings for Gladiator2.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Exit this menu.";
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(12, 394);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(146, 47);
            this.btnCredits.TabIndex = 14;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "View credits for Gladiator2.";
            // 
            // frmGladiator2Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 504);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHostNetwork);
            this.Controls.Add(this.btnJoinNetwork);
            this.Controls.Add(this.btnSinglePlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGladiator2Launcher";
            this.Text = "Gladiator 2 Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnJoinNetwork;
        private System.Windows.Forms.Button btnHostNetwork;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Label label6;
    }
}

