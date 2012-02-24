namespace Gladiator_2_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnJoinNetwork = new System.Windows.Forms.Button();
            this.btnHostNetwork = new System.Windows.Forms.Button();
            this.txtJoinIP = new System.Windows.Forms.TextBox();
            this.pnlJoinGame = new System.Windows.Forms.Panel();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlJoinGame.SuspendLayout();
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
            // txtJoinIP
            // 
            this.txtJoinIP.Location = new System.Drawing.Point(21, 33);
            this.txtJoinIP.Name = "txtJoinIP";
            this.txtJoinIP.Size = new System.Drawing.Size(146, 20);
            this.txtJoinIP.TabIndex = 3;
            this.txtJoinIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlJoinGame
            // 
            this.pnlJoinGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJoinGame.Controls.Add(this.btnJoin);
            this.pnlJoinGame.Controls.Add(this.label1);
            this.pnlJoinGame.Controls.Add(this.txtJoinIP);
            this.pnlJoinGame.Location = new System.Drawing.Point(188, 205);
            this.pnlJoinGame.Name = "pnlJoinGame";
            this.pnlJoinGame.Size = new System.Drawing.Size(196, 90);
            this.pnlJoinGame.TabIndex = 4;
            this.pnlJoinGame.Visible = false;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(46, 60);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(102, 21);
            this.btnJoin.TabIndex = 5;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP of Host";
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkLog.Location = new System.Drawing.Point(51, 427);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 456);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.pnlJoinGame);
            this.Controls.Add(this.btnHostNetwork);
            this.Controls.Add(this.btnJoinNetwork);
            this.Controls.Add(this.btnSinglePlayer);
            this.Name = "Form1";
            this.Text = "Gladiator 2 Launcher";
            this.pnlJoinGame.ResumeLayout(false);
            this.pnlJoinGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnJoinNetwork;
        private System.Windows.Forms.Button btnHostNetwork;
        private System.Windows.Forms.TextBox txtJoinIP;
        private System.Windows.Forms.Panel pnlJoinGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettings;
    }
}

