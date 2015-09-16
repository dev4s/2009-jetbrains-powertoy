using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InstallProgramForJetBrainsPowerToy
{
    public partial class MainForm : Form
    {
        private const string Msiexecinstall = "msiexec /i";
        private const string Msiexecuninstall = "msiexec /x";
        private const string Quiet = "/qn";
        private const string Passive = "/passive";
        private const string Vs2009 = "(VS%209.0)";
        private const string Vs2010 = "(VS%2010.0)";
        private const string CmdL = "cmd";
        private const string CmdLProps = "/c start /wait";
        private const string Resharper = "Resharper";

        private void InstallOrUninstall(string msiexec, string vs)
        {
            var directoryInfo = new DirectoryInfo(PathTextBox.Text);
            var files = directoryInfo.GetFiles();

            var files2 =
                files.Where(f => f.Extension == ".msi" && f.Name.EndsWith(String.Format("{0}{1}", vs, f.Extension))).ToList();
            var temp = files2[files2.Count - 1];
            files2[files2.Count - 1] = files2[files2.Count - 2];
            files2[files2.Count - 2] = temp;

            progressBar.Value = 0;
            progressBar.Maximum = files2.Count;

            foreach (var process in
                files2.Select(f => GetProcessInfo(f.Name.StartsWith(Resharper) ? Passive : Quiet, msiexec, f)).Select(startInfo => Process.Start(startInfo)).Where(process => process != null))
            {
                process.WaitForExit();
                progressBar.Increment(1);
            }
        }

        private static ProcessStartInfo GetProcessInfo(string option, string msiexec, FileSystemInfo f)
        {
            return new ProcessStartInfo(CmdL, string.Format("{0} {1} {2} {3}", CmdLProps, msiexec, f.FullName, option)) { WindowStyle = ProcessWindowStyle.Hidden };
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
            PathTextBox.Text = folderBrowserDialog.SelectedPath;

            InstallAllVs2008.Enabled = true;
            InstallAllVs2010.Enabled = true;
            UninstallAllVs2008.Enabled = true;
            UninstallAllVs2010.Enabled = true;
        }

        private void InstallAllVs2008_Click(object sender, EventArgs e)
        {
            InstallOrUninstall(Msiexecinstall, Vs2009);
            MessageBox.Show("Installation Completed!", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InstallAllVs2010_Click(object sender, EventArgs e)
        {
            InstallOrUninstall(Msiexecinstall, Vs2010);
            MessageBox.Show("Installation Completed!", "Installation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UninstallAllVs2008_Click(object sender, EventArgs e)
        {
            InstallOrUninstall(Msiexecuninstall, Vs2009);
            MessageBox.Show("Uninstallation Completed!", "Uninstallation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UninstallAllVs2010_Click(object sender, EventArgs e)
        {
            InstallOrUninstall(Msiexecuninstall, Vs2010);
            MessageBox.Show("Uninstallation Completed!", "Uninstallation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
