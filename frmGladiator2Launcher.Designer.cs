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
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Location = new System.Drawing.Point(24, 205);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(146, 47);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // btnJoinNetwork
            // 
            this.btnJoinNetwork.Location = new System.Drawing.Point(24, 259);
            this.btnJoinNetwork.Name = "btnJoinNetwork";
            this.btnJoinNetwork.Size = new System.Drawing.Size(146, 47);
            this.btnJoinNetwork.TabIndex = 1;
            this.btnJoinNetwork.Text = "Join Network Game";
            this.btnJoinNetwork.UseVisualStyleBackColor = true;
            this.btnJoinNetwork.Click += new System.EventHandler(this.btnJoinNetwork_Click);
            // 
            // btnHostNetwork
            // 
            this.btnHostNetwork.Location = new System.Drawing.Point(24, 312);
            this.btnHostNetwork.Name = "btnHostNetwork";
            this.btnHostNetwork.Size = new System.Drawing.Size(146, 47);
            this.btnHostNetwork.TabIndex = 2;
            this.btnHostNetwork.Text = "Host Network Game";
            this.btnHostNetwork.UseVisualStyleBackColor = true;
            this.btnHostNetwork.Click += new System.EventHandler(this.btnHostNetwork_Click);
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkLog.Location = new System.Drawing.Point(218, 328);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(119, 17);
            this.chkLog.TabIndex = 5;
            this.chkLog.Text = "Enable Server Logs";
            this.chkLog.UseVisualStyleBackColor = false;
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
            this.btnSettings.Location = new System.Drawing.Point(24, 365);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(146, 47);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(24, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 47);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmGladiator2Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 474);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.btnHostNetwork);
            this.Controls.Add(this.btnJoinNetwork);
            this.Controls.Add(this.btnSinglePlayer);
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
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnClose;
    }
}

