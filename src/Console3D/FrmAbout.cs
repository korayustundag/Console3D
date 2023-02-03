using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Console3D
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btnGoToGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/korayustundag/Console3D");
        }
    }
}
