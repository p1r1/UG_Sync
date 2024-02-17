using System;
using System.Windows.Forms;

namespace UGDiscordBot {
    public partial class FormBot : Form {
        public FormBot() {
            InitializeComponent();
        }

        private void FormBot_Load(object sender, EventArgs e) {
            setUpUseNotify();
            notifyIcon1.Visible = false;
            ///stop at closing

            ///init bot
            //initDiscordBot();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void FormBot_FormClosing(object sender, FormClosingEventArgs e) {
            notifyIcon1.Visible = false;
            try {
                Application.ExitThread();
                Application.Exit();
                Environment.Exit(1);
            }
            catch { }
        }
        private void setUpUseNotify() {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            //notifyIcon1.BalloonTipText = "This is A Sample Application";
            //notifyIcon1.BalloonTipTitle = "Your Application Name";
            //notifyIcon1.ShowBalloonTip(1);
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Application.MessageLoop) {
                // WinForms app
                Application.Exit();
                try {
                    Environment.Exit(1);
                }
                catch (Exception) {
                }
            }
            else {
                // Console app
                Environment.Exit(1);
            }
        }

        private void FormBot_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
        //async static void initDiscordBot() {
        //    string[] args = null;
        //    Program p = new Program();
        //    //await p.initBot(args);
        //    //UGDiscordBot.Program discordMain = new UGDiscordBot.Program();
        //    //await discordMain.Ma(args);
        //    //Task.Run(() => await new DiscordMain().InitBot(args));
        //}
    }
}
