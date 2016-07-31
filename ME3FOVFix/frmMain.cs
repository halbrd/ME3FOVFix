using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ME3FOVFix
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtInstallDirectory.Text = fbd.SelectedPath;
            }
        }

        private void throwError(string error)
        {
            lblResult.Text = error;
            lblResult.BackColor = Color.Red;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            btnBrowse.Enabled = false;
            txtInstallDirectory.Enabled = false;

            txtInstallDirectory.Text = txtInstallDirectory.Text.TrimEnd('\\');
            
            if (txtInstallDirectory.Text == "" || !txtInstallDirectory.Text.EndsWith("Mass Effect 3"))
                throwError("Invalid installation directory.");
            else if (!Directory.Exists(txtInstallDirectory.Text))
                throwError("Installation directory doesn't exist.");
            else if (Process.GetProcessesByName("MassEffect3.exe").Length > 0)
                throwError("Mass Effect 3 is currently running.");
            else
            {
                string dir = txtInstallDirectory.Text + "\\BIOGame\\CookedPCConsole\\";

                lblResult.Text = Directory.GetCurrentDirectory();
                try
                {
                    File.Move(dir + "Coalesced.bin", dir + "Coalesced.bin.youroriginal");
                    File.Copy("Coalesced.bin", dir + "Coalesced.bin");
                    File.Copy("Coalesced.bin.original", dir + "Coalesced.bin.original");
                    File.Copy("Coalesced.bin.fovmod", dir + "Coalesced.bin.fovmod");

                    lblResult.Text = "Files successfully copied.";
                    lblResult.BackColor = Color.Green;
                }
                catch
                {
                    throwError("Error copying files.");
                }
            }
        }
    }
}