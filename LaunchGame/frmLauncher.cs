using LaunchGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchGame
{
    //Todo: implement version checking
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private void frmLauncher_Load(object sender, EventArgs e)
        {

            txtPassword.Text = GetPasswordFromFile();
            if (txtPassword.Text != "")
            {
                chkSavePassword.Checked = true;
            }

            //TODO: Take out of code and persist in a file
            txtUrlToResolve.Text = "deadmengaming.co.uk";
            ResolveIp();
        }

        private void ResolveIp()
        {
            try
            {
            IPAddress[] addresses = Dns.GetHostAddresses(txtUrlToResolve.Text);
            lblResolvedIp.Text = addresses[0].ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message== "No such host is known")
                {
                    lblMessage.Text = "That's probably a bad URL.";
                }
                else throw;
            }

        }

        private void btnLaunchConan_Click(object sender, EventArgs e)
        {
            var launchString = "steam://rungameid/440900// +connect " + lblResolvedIp.Text + ":7777 +password " + txtPassword.Text;
            Process.Start(launchString);
        }
        private string GetPasswordFromFile()
        {
            ConfigManager configManager = new ConfigManager();
            string password=configManager.ReadKey("password");
            return password;
        }
        private void StorePassword(string password)
        {
            ConfigManager configManager = new ConfigManager();
            configManager.UpdateKey("password", password);
            //Dictionary<string,string> configs = new Dictionary<string,string>(configManager.ListKeys());

            //System.IO.File.WriteAllText("config.txt", string.Empty);
            //StreamWriter passwordWriter = new StreamWriter("config.txt");
            //passwordWriter.WriteLine(password);
            //passwordWriter.Close();
        }

        private void chkSavePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSavePassword.Checked && txtPassword.Text != "")
            {
                if (GetPasswordFromFile() == "")
                {
                    StorePassword(txtPassword.Text);
                }
                else if (GetPasswordFromFile() != txtPassword.Text)
                {
                    var result = MessageBox.Show("Overrite the password?", "Change Stored Password", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        StorePassword(txtPassword.Text);
                    }
                }


            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            chkSavePassword.Checked = false;
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            ResolveIp();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblResolvedIp.Text + ":7777");
        }
    }
}
