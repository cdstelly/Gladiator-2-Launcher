namespace Gladiator_2_Launcher
{
    partial class frmSettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxWindowSettings = new System.Windows.Forms.GroupBox();
            this.chkEnableAmbientOcclusion = new System.Windows.Forms.CheckBox();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.chkEnableWindowedMode = new System.Windows.Forms.CheckBox();
            this.chkEnableMotionBlur = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxWindowSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resolution:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gladiator 2 Settings";
            // 
            // gbxWindowSettings
            // 
            this.gbxWindowSettings.Controls.Add(this.chkEnableAmbientOcclusion);
            this.gbxWindowSettings.Controls.Add(this.cmbResolution);
            this.gbxWindowSettings.Controls.Add(this.chkEnableWindowedMode);
            this.gbxWindowSettings.Controls.Add(this.label2);
            this.gbxWindowSettings.Controls.Add(this.chkEnableMotionBlur);
            this.gbxWindowSettings.Controls.Add(this.label1);
            this.gbxWindowSettings.Controls.Add(this.label6);
            this.gbxWindowSettings.Controls.Add(this.label4);
            this.gbxWindowSettings.Controls.Add(this.label5);
            this.gbxWindowSettings.Location = new System.Drawing.Point(16, 45);
            this.gbxWindowSettings.Name = "gbxWindowSettings";
            this.gbxWindowSettings.Size = new System.Drawing.Size(199, 121);
            this.gbxWindowSettings.TabIndex = 8;
            this.gbxWindowSettings.TabStop = false;
            this.gbxWindowSettings.Text = "Window Settings";
            // 
            // chkEnableAmbientOcclusion
            // 
            this.chkEnableAmbientOcclusion.AutoSize = true;
            this.chkEnableAmbientOcclusion.Location = new System.Drawing.Point(175, 97);
            this.chkEnableAmbientOcclusion.Name = "chkEnableAmbientOcclusion";
            this.chkEnableAmbientOcclusion.Size = new System.Drawing.Size(15, 14);
            this.chkEnableAmbientOcclusion.TabIndex = 14;
            this.chkEnableAmbientOcclusion.UseVisualStyleBackColor = true;
            // 
            // cmbResolution
            // 
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Items.AddRange(new object[] {
            "800x600",
            "1024x768",
            "1280x1024"});
            this.cmbResolution.Location = new System.Drawing.Point(69, 25);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(121, 21);
            this.cmbResolution.TabIndex = 9;
            // 
            // chkEnableWindowedMode
            // 
            this.chkEnableWindowedMode.AutoSize = true;
            this.chkEnableWindowedMode.Location = new System.Drawing.Point(175, 74);
            this.chkEnableWindowedMode.Name = "chkEnableWindowedMode";
            this.chkEnableWindowedMode.Size = new System.Drawing.Size(15, 14);
            this.chkEnableWindowedMode.TabIndex = 13;
            this.chkEnableWindowedMode.UseVisualStyleBackColor = true;
            // 
            // chkEnableMotionBlur
            // 
            this.chkEnableMotionBlur.AutoSize = true;
            this.chkEnableMotionBlur.Location = new System.Drawing.Point(175, 52);
            this.chkEnableMotionBlur.Name = "chkEnableMotionBlur";
            this.chkEnableMotionBlur.Size = new System.Drawing.Size(15, 14);
            this.chkEnableMotionBlur.TabIndex = 12;
            this.chkEnableMotionBlur.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enable Ambient Occlusion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enable Motion Blur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enable Windowed Mode:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 262);
            this.Controls.Add(this.gbxWindowSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmSettings";
            this.Text = "Gladiator 2 Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbxWindowSettings.ResumeLayout(false);
            this.gbxWindowSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxWindowSettings;
        private System.Windows.Forms.CheckBox chkEnableAmbientOcclusion;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.CheckBox chkEnableWindowedMode;
        private System.Windows.Forms.CheckBox chkEnableMotionBlur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}