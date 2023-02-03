using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Console3D
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainFontDialog.ShowDialog() == DialogResult.OK)
            {
                TxtSource.Font = MainFontDialog.Font;
                Properties.Settings.Default.defaultFont = MainFontDialog.Font;
                Properties.Settings.Default.Save();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmOptions fo = new FrmOptions())
            {
                fo.ShowDialog();
            }
        }

        StringBuilder sb = new StringBuilder();

        private void NoMethod(RichTextBox source)
        {
            for (int i = 0; i < source.Lines.Count(); i++)
            {
                sb.AppendLine("Console.WriteLine(@\"" + source.Lines[i] + "\");");
            }
            source.Text = sb.ToString();
            sb.Clear();
        }

        private void CreateMethod(RichTextBox source)
        {
            sb.AppendLine("public void WelcomeMessage()");
            sb.AppendLine("{");
            for (int i = 0; i < source.Lines.Count(); i++)
            {
                sb.AppendLine("\tConsole.WriteLine(@\"" + source.Lines[i] + "\");");
            }
            sb.AppendLine("}");
            source.Text = sb.ToString();
            sb.Clear();
        }

        private void CreateStaticMethod(RichTextBox source)
        {
            sb.AppendLine("public static void WelcomeMessage()");
            sb.AppendLine("{");
            for (int i = 0; i < source.Lines.Count(); i++)
            {
                sb.AppendLine("\tConsole.WriteLine(@\"" + source.Lines[i] + "\");");
            }
            sb.AppendLine("}");
            source.Text = sb.ToString();
            sb.Clear();
        }

        private void CreateClass(RichTextBox source)
        {
            sb.AppendLine("using System;");
            sb.AppendLine();
            sb.AppendLine("namespace BeautifulConsole");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static class Console3D");
            sb.AppendLine("\t{");
            sb.AppendLine("\t\tpublic static void WelcomeMessage()");
            sb.AppendLine("\t\t{");
            for (int i = 0; i < source.Lines.Count(); i++)
            {
                sb.AppendLine("\t\t\tConsole.WriteLine(@\"" + source.Lines[i] + "\");");
            }
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            source.Text = sb.ToString();
            sb.Clear();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            int btype = Properties.Settings.Default.buildType;

            if (btype == 0)
            {
                NoMethod(TxtSource);
            }
            else if (btype == 1)
            {
                CreateMethod(TxtSource);
            }
            else if (btype == 2)
            {
                CreateStaticMethod(TxtSource);
            }
            else if (btype == 3)
            {
                CreateClass(TxtSource);
            }
            else
            {
                NoMethod(TxtSource);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtSource.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "C# Source File(*.cs)|*.cs";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        TxtSource.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("Saved!", "Console3D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Console3D", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmAbout about = new FrmAbout())
            {
                about.ShowDialog();
            }
        }
    }
}
