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
            #if (DEBUG)
            IConfigSource source = new IniConfigSource("C:\\UDK\\Gladiator2_2012022322222222\\UDKGame\\Config\\UDKEngine.ini");
            #else
            IConfigSource source = new IniConfigSource(Application.StartupPath + "UDKGame\\Config\\UDKEngine.ini");
            #endif

            source.Configs["SystemSettings"].Set("ResX", cmbResolution.Text.Split('x').ElementAt(0));
            source.Configs["SystemSettings"].Set("ResY", cmbResolution.Text.Split('x').ElementAt(1));
            source.Configs["SystemSettings"].Set("Fullscreen", (chkEnableWindowedMode.Checked == true) ? "False" : "True");
            source.Configs["SystemSettings"].Set("AmbientOcclusion", (chkEnableAmbientOcclusion.Checked == true) ? "True" : "False");
            source.Save();

            Properties.Settings.Default.Resolution = cmbResolution.Text.Trim();
            Properties.Settings.Default.AmbientOcc = chkEnableAmbientOcclusion.Checked;
            Properties.Settings.Default.EnableWindowedMode = !chkEnableWindowedMode.Checked;
            Properties.Settings.Default.ServerLog = chkLog.Checked;
            this.Close();
        }

        public bool showLog()
        {
            return (chkLog.Checked);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
