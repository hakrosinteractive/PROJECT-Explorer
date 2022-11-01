using HAKROS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPRS_App_Control
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Opacity = 0;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!ClassSecurity.InExecution())
            {
                InitApp();
            }
            else
            {
                Application.Exit();
            }
        }

        private void tcontrol_Tick(object sender, EventArgs e)
        {
            ScanApps();
        }

        private void i1_Click(object sender, EventArgs e)
        {
            CloseApp(i1);
        }

        private void i2_Click(object sender, EventArgs e)
        {
            CloseApp(i2);
        }

        private void i3_Click(object sender, EventArgs e)
        {
            CloseApp(i3);
        }

        private void i4_Click(object sender, EventArgs e)
        {
            CloseApp(i4);
        }

        private void i5_Click(object sender, EventArgs e)
        {
            CloseApp(i5);
        }

        private void i6_Click(object sender, EventArgs e)
        {
            CloseApp(i6);
        }

        private void i7_Click(object sender, EventArgs e)
        {
            CloseApp(i7);
        }

        private void i8_Click(object sender, EventArgs e)
        {
            CloseApp(i8);
        }

        private void i9_Click(object sender, EventArgs e)
        {
            CloseApp(i9);
        }

        private void i10_Click(object sender, EventArgs e)
        {
            CloseApp(i10);
        }

        private void InitApp()
        {
            Text = ClassGeneral.GetWindowTitle();
            Opacity = 1;
            TopMost = true;
            tcontrol.Interval = 500;
            tcontrol.Enabled = true;
        }

        private void ScanApps()
        {
            try
            {

                var prs = Process.GetProcesses();

                var pr1a = Process.GetProcessesByName("ads.mprs.wpf.launcher");
                var pr2a = Process.GetProcessesByName("ads.mprs.wpf.missionplanning");
                var pr3a = Process.GetProcessesByName("ads.mprs.wpf.comms");
                var pr4a = Process.GetProcessesByName("ads.mprs.wpf.datamanagement");
                var pr5a = Process.GetProcessesByName("ads.mprs.wpf.tacticalplanning");
                var pr6a = Process.GetProcessesByName("ads.mprs.wpf.lspcalculator");
                var pr7a = Process.GetProcessesByName("ads.mprs.wpf.scicompresstool");
                var pr8a = Process.GetProcessesByName("ads.mprs.wpf.weightbalance");
                var pr9a = Process.GetProcessesByName("ads.mprs.wpf.settingsapplication");
                var pr10a1 = Process.GetProcessesByName("ads.mprs.services.mprsservice");
                var pr10a2 = Process.GetProcessesByName("ads.mprs.services.externalservice");
                var pr10a3 = Process.GetProcessesByName("ads.mprs.services.security.server.winservice");

                var pr1b = Process.GetProcessesByName("ads.mprs.wpf.launcher.vshost");
                var pr2b = Process.GetProcessesByName("ads.mprs.wpf.missionplanning.vshost");
                var pr3b = Process.GetProcessesByName("ads.mprs.wpf.comms.vshost");
                var pr4b = Process.GetProcessesByName("ads.mprs.wpf.datamanagement.vshost");
                var pr5b = Process.GetProcessesByName("ads.mprs.wpf.tacticalplanning.vshost");
                var pr6b = Process.GetProcessesByName("ads.mprs.wpf.lspcalculator.vshost");
                var pr7b = Process.GetProcessesByName("ads.mprs.wpf.scicompresstool.vshost");
                var pr8b = Process.GetProcessesByName("ads.mprs.wpf.weightbalance.vshost");
                var pr9b = Process.GetProcessesByName("ads.mprs.wpf.settingsapplication.vshost");
                var pr10b1 = Process.GetProcessesByName("ads.mprs.services.mprsservice.vshost");
                var pr10b2 = Process.GetProcessesByName("ads.mprs.services.externalservice.vshost");
                var pr10b3 = Process.GetProcessesByName("ads.mprs.services.security.server.winservice.vshost");

                var pr1 = new List<Process>();
                var pr2 = new List<Process>();
                var pr3 = new List<Process>();
                var pr4 = new List<Process>();
                var pr5 = new List<Process>();
                var pr6 = new List<Process>();
                var pr7 = new List<Process>();
                var pr8 = new List<Process>();
                var pr9 = new List<Process>();
                var pr10 = new List<Process>();

                foreach (var pr in pr1a) { pr1.Add(pr); }
                foreach (var pr in pr1b) { pr1.Add(pr); }

                foreach (var pr in pr2a) { pr2.Add(pr); }
                foreach (var pr in pr2b) { pr2.Add(pr); }

                foreach (var pr in pr3a) { pr3.Add(pr); }
                foreach (var pr in pr3b) { pr3.Add(pr); }

                foreach (var pr in pr4a) { pr4.Add(pr); }
                foreach (var pr in pr4b) { pr4.Add(pr); }

                foreach (var pr in pr5a) { pr5.Add(pr); }
                foreach (var pr in pr5b) { pr5.Add(pr); }

                foreach (var pr in pr6a) { pr6.Add(pr); }
                foreach (var pr in pr6b) { pr6.Add(pr); }

                foreach (var pr in pr7a) { pr7.Add(pr); }
                foreach (var pr in pr7b) { pr7.Add(pr); }

                foreach (var pr in pr8a) { pr8.Add(pr); }
                foreach (var pr in pr8b) { pr8.Add(pr); }

                foreach (var pr in pr9a) { pr9.Add(pr); }
                foreach (var pr in pr9b) { pr9.Add(pr); }

                foreach (var pr in pr10a1) { pr10.Add(pr); }
                foreach (var pr in pr10a2) { pr10.Add(pr); }
                foreach (var pr in pr10a3) { pr10.Add(pr); }
                foreach (var pr in pr10b1) { pr10.Add(pr); }
                foreach (var pr in pr10b2) { pr10.Add(pr); }
                foreach (var pr in pr10b3) { pr10.Add(pr); }

                i1.Tag = pr1;
                i2.Tag = pr2;
                i3.Tag = pr3;
                i4.Tag = pr4;
                i5.Tag = pr5;
                i6.Tag = pr6;
                i7.Tag = pr7;
                i8.Tag = pr8;
                i9.Tag = pr9;
                i10.Tag = pr10;

                b1.BackColor = (pr1.Count() > 0) ? Color.Green : Color.Firebrick;
                b2.BackColor = (pr2.Count() > 0) ? Color.Green : Color.Firebrick;
                b3.BackColor = (pr3.Count() > 0) ? Color.Green : Color.Firebrick;
                b4.BackColor = (pr4.Count() > 0) ? Color.Green : Color.Firebrick;
                b5.BackColor = (pr5.Count() > 0) ? Color.Green : Color.Firebrick;
                b6.BackColor = (pr6.Count() > 0) ? Color.Green : Color.Firebrick;
                b7.BackColor = (pr7.Count() > 0) ? Color.Green : Color.Firebrick;
                b8.BackColor = (pr8.Count() > 0) ? Color.Green : Color.Firebrick;
                b9.BackColor = (pr9.Count() > 0) ? Color.Green : Color.Firebrick;
                b10.BackColor = (pr10.Count() > 0) ? Color.Green : Color.Firebrick;

                HelpTip.SetToolTip(i1, (pr1.Count() > 0) ? "Close Launcher" : "Launcher is not running");
                HelpTip.SetToolTip(i2, (pr2.Count() > 0) ? "Close MissionPlanning" : "MissionPlanning is not running");
                HelpTip.SetToolTip(i3, (pr3.Count() > 0) ? "Close Comms" : "Comms is not running");
                HelpTip.SetToolTip(i4, (pr4.Count() > 0) ? "Close DataManagement" : "DataManagement is not running");
                HelpTip.SetToolTip(i5, (pr5.Count() > 0) ? "Close TacticalPlanning" : "TacticalPlanning is not running");
                HelpTip.SetToolTip(i6, (pr6.Count() > 0) ? "Close LSPCalculator" : "LSPCalculator is not running");
                HelpTip.SetToolTip(i7, (pr7.Count() > 0) ? "Close SCICompressTool" : "SCICompressTool is not running");
                HelpTip.SetToolTip(i8, (pr8.Count() > 0) ? "Close WeightBalance" : "WeightBalance is not running");
                HelpTip.SetToolTip(i9, (pr9.Count() > 0) ? "Close ApplicationServer" : "ApplicationServer is not running");
                HelpTip.SetToolTip(i10, (pr10.Count() > 0) ? "Close ControlServices" : "ControlServices are not running");

            }
            catch
            {
                //Error !!
            }
        }

        private void CloseApp(PictureBox pic)
        {
            if (pic.Tag != null)
            {
                try
                {
                    List<Process> prs = (List<Process>)pic.Tag;
                    foreach (var pr in prs)
                    {
                        pr.Kill();
                    }
                }
                catch
                {
                    //Error
                }
            }
            ScanApps();
        }

    }
}
