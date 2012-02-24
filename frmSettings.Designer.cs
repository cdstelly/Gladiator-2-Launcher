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
            this.chkWindowedMode = new System.Windows.Forms.CheckBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxWindowSettings = new System.Windows.Forms.GroupBox();
            this.gbxWindowSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkWindowedMode
            // 
            this.chkWindowedMode.AutoSize = true;
            this.chkWindowedMode.Checked = true;
            this.chkWindowedMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWindowedMode.Location = new System.Drawing.Point(15, 78);
            this.chkWindowedMode.Name = "chkWindowedMode";
            this.chkWindowedMode.Size = new System.Drawing.Size(107, 17);
            this.chkWindowedMode.TabIndex = 2;
            this.chkWindowedMode.Text = "Windowed Mode";
            this.chkWindowedMode.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(64, 22);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(62, 20);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Text = "Width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(65, 50);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(62, 20);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Default Gladiator 2 Settings";
            // 
            // gbxWindowSettings
            // 
            this.gbxWindowSettings.Controls.Add(this.label2);
            this.gbxWindowSettings.Controls.Add(this.label1);
            this.gbxWindowSettings.Controls.Add(this.chkWindowedMode);
            this.gbxWindowSettings.Controls.Add(this.txtHeight);
            this.gbxWindowSettings.Controls.Add(this.txtWidth);
            this.gbxWindowSettings.Location = new System.Drawing.Point(137, 36);
            this.gbxWindowSettings.Name = "gbxWindowSettings";
            this.gbxWindowSettings.Size = new System.Drawing.Size(135, 103);
            this.gbxWindowSettings.TabIndex = 8;
            this.gbxWindowSettings.TabStop = false;
            this.gbxWindowSettings.Text = "Window Settings";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gbxWindowSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmSettings";
            this.Text = "Gladiator 2 Settings";
            this.TopMost = true;
            this.gbxWindowSettings.ResumeLayout(false);
            this.gbxWindowSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkWindowedMode;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxWindowSettings;
    }
}