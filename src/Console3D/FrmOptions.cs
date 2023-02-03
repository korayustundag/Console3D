using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console3D
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
        }

        public void LoadSettings()
        {
            RadioClass.Checked = false;
            RadioMethod.Checked = false;
            RadioStandard.Checked = false;
            RadioStaticMethod.Checked = false;
            int btype = Properties.Settings.Default.buildType;

            txtNamespace.Text = Properties.Settings.Default.defaultNamespace;
            txtMethodName.Text = Properties.Settings.Default.defaultMethodName;
            if (btype == 0)
            {
                RadioStandard.Checked = true;
            }
            else if (btype == 1)
            {
                RadioMethod.Checked = true;
            }
            else if (btype == 2)
            {
                RadioStaticMethod.Checked = true;
            }
            else if (btype == 3)
            {
                RadioClass.Checked = true;
            }
            else
            {
                RadioStandard.Checked = true;
            }
        }

        private void FrmOptions_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNamespace.Text))
            {
                Properties.Settings.Default.defaultNamespace = txtNamespace.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtMethodName.Text))
            {
                Properties.Settings.Default.defaultMethodName = txtMethodName.Text;
            }

            if (RadioStandard.Checked)
            {
                Properties.Settings.Default.buildType = 0;
            }
            else if (RadioMethod.Checked)
            {
                Properties.Settings.Default.buildType = 1;
            }
            else if (RadioStaticMethod.Checked)
            {
                Properties.Settings.Default.buildType = 2;
            }
            else if (RadioClass.Checked)
            {
                Properties.Settings.Default.buildType = 3;
            }
            else
            {
                Properties.Settings.Default.buildType = 0;
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved!", "Console3D", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("After the settings are reset, the app will restart itself. Do you want all settings reset?", "Console3D", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
