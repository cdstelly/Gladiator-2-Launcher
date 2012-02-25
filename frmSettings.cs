using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nini.Ini;
using Nini.Config;

namespace Gladiator_2_Launcher
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }


        private void frmSettings_Load(object sender, EventArgs e)
        {
            chkEnableWindowedMode.Checked = Properties.Settings.Default.EnableWindowedMode;
            cmbResolution.Text = Properties.Settings.Default.Resolution;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IConfigSource source = new IniConfigSource("C:\\UDK\\UDKGame\\Config\\UDKEngine.ini");
            
            source.Configs["SystemSettings"].Set("ResX", cmbResolution.Text.Split('x').ElementAt(0));
            source.Configs["SystemSettings"].Set("ResY", cmbResolution.Text.Split('x').ElementAt(1));
            source.Configs["SystemSettings"].Set("Fullscreen", (chkEnableWindowedMode.Checked == true) ? "False" : "True");
            source.Configs["SystemSettings"].Set("AmbientOcclusion", (chkEnableAmbientOcclusion.Checked == true) ? "True" : "False");
            source.Save();
            
            Properties.Settings.Default.Resolution = cmbResolution.Text.Trim();
        }
    }
}
