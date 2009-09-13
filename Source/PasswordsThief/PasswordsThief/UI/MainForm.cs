using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using Core.UIItems.WindowItems;
using Application = Core.Application;

namespace PasswordsThief.UI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            cbProcesses.DataSource = new List<Process>(Process.GetProcesses());
            cbProcesses.DisplayMember = "ProcessName";
            cbWindows.DisplayMember = "Title";
        }

        private void On_BtnRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnRefresh.Enabled = false;
            cbProcesses.DataSource = new List<Process>(Process.GetProcesses());
            btnRefresh.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void On_CbProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Application curApp = Application.Attach(((Process)cbProcesses.SelectedItem).Id);
            cbWindows.DataSource = new List<Window>(curApp.GetWindows());
        }

        private void On_BtnGetControls_Click(object sender, EventArgs e)
        {
            if (cbWindows.SelectedItem == null)
                return;
            (new ControlsView((Window)cbWindows.SelectedItem)).ShowDialog();
        }
    }
}