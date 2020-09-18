using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace ComputerManagment
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.shutdownBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            this.altavozBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            this.cascosBtn.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void handleClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            switch (btn.Name)
            {
                case "shutdownBtn":
                    this.executeCommand("shutdown", "-a");
                    this.executeCommand("shutdown", "/s /t 3600");
                    break;
                case "altavozBtn":
                    this.executeCommand("nircmd", "setdefaultsounddevice  \"Altavoces\" 1");
                    this.executeCommand("nircmd", "setdefaultsounddevice  \"Altavoces\" 2");
                    break;
                case "cascosBtn":
                    this.executeCommand("nircmd", "setdefaultsounddevice  \"cascos\" 1");
                    this.executeCommand("nircmd", "setdefaultsounddevice  \"cascos\" 2");
                    break;

            }
        }

        private void executeCommand(string command, string arguments)
        {
            var psi = new ProcessStartInfo(command, arguments);
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void handleHover(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.Cursor = Cursors.Hand;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon.Visible = true;
            }
        }
    }
}
