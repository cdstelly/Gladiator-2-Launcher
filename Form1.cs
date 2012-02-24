using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Gladiator_2_Launcher
{
    public partial class Form1 : Form
    {
        System.Diagnostics.Process          process;

        public Form1()
        {
            InitializeComponent();
            process               = new System.Diagnostics.Process();
            process.StartInfo.FileName = @"C:\\UDK\\Binaries\\Win32\\UDK.exe";
            process.StartInfo.UseShellExecute = false;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            process.StartInfo.Arguments = "C:\\UDK\\Binaries\\Win32\\UDK.exe " + txtJoinIP.Text;
            process.StartInfo.Arguments = (chkLog.Checked == true) ? process.StartInfo.Arguments + " -log": process.StartInfo.Arguments;
            process.Start();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            process.StartInfo.Arguments = "-log";
            process.Start();
        }

        private void btnJoinNetwork_Click(object sender, EventArgs e)
        {            
            pnlJoinGame.Visible = !pnlJoinGame.Visible;
        }

        private void btnHostNetwork_Click(object sender, EventArgs e)
        {
            process.StartInfo.Arguments = "-server";
            process.StartInfo.Arguments = (chkLog.Checked == true) ? process.StartInfo.Arguments + " -log" : process.StartInfo.Arguments;
            process.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
