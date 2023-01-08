using System.Reflection;

namespace windows_app
{
    public partial class USBGUARD : Form
    {

        private const int DEVICECHANGE = 0x0219;
        private const int DBTDEVARRIVAL = 0x8000;
        private const int DBTDEVREMOVED = 0x8004;
        private const int DBTDEVTYPEVOLUME = 0x000000002;
        private const int WMDEVICECHANGE = 0x0219;

        int TimerCount = 10;
        int tmronHours, tmronMinutes, tmronSeconds;
        int port;

        eescwin? LockScreen;
        ServerClass ? server;
        string[] args;
        public DriveInfo[] ? DriveList;
        public int totDrives, dcount;
        public int removableVolumes;
        public bool isRunning;

        public string? uday;
        public string? uhour;
        public string? umin;
        public string? usec;
        public string password;
        public string? serMsgs;

        USBDev usbinfo;
        PasswordCTX ? pwd;


        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }
        public USBGUARD(string[] arg)
        {
            // LockScreen = null;
            port = 7002;
            server = new ServerClass(port);
            server.DataAvailalble += Server_DataAvailalble;

            InitializeComponent();
            button1.Hide();
            args = arg;
            password = "1234@";
            isRunning = true;
            totDrives = 0;
            dcount = 0;
            removableVolumes = 0; totDrives = 0;
            dcount = 0;
            removableVolumes = 0;
            handleCommands();


            iniForm2();
            usbinfo = new USBDev(this.Handle);
            RegisterDevices();
            dcount = totDrives;
            BGWorker.RunWorkerAsync();

        }

        private void Server_DataAvailalble(object sender, DataAvailableEventArgs e)
        {
            serMsgs = e.Data.ToString();

            serMsgs = serMsgs.ToLower();
            switch(serMsgs)
            {
                case "close":
                    e.Send("quit");
                    this.Invoke(new Action(() => this.Close()));
                    break;
                case "hostname":
                    e.Send(server.GetLocalIPAddress().ToString());
                    break;
            }
            
          
            
        }

        public bool RegisterDevices()
        {
            foreach (DriveInfo driveInfo in usbinfo.allDrives)
                if (driveInfo.DriveType == DriveType.Fixed)
                {
                    totDrives++;
                    DriveList = new DriveInfo[totDrives + 1];
                    DriveList[totDrives] = driveInfo;
                }
            if (usbinfo.getRemovableDrives() > 0)
                showLockscreen();

            if (totDrives > 0)
                return true;
            return false;
        }
        public void handleCommands()
        {
            string whatcmd = "";
           // int ardAvailable = 2;

            foreach (string arg in args)
            {
                switch (arg)
                {
                    case "-tmron":

                        if (!int.TryParse(args[arg.IndexOf(arg) + 1], out tmronHours))
                            tmronHours = 24;
                        if (!int.TryParse(args[arg.IndexOf(arg) + 2], out tmronMinutes))
                            tmronMinutes = 60;
                        if (!int.TryParse(args[arg.IndexOf(arg) + 3], out tmronSeconds))
                            tmronSeconds = 60;
                        break;
                    case "-pwd":
                        whatcmd = "-pwd";
                        password = arg;
                        break;
                    default:
                        if (whatcmd == "-pwd")
                        {
                            password = arg;
                        }
                        break;
                }

            }
            //  StopTmrVal.Text = tmrHours.ToString();// + " : " + tmrMinutes.ToString() + " : " + tmrSeconds.ToString();
        }
        public void iniForm2()
        {
            LockScreen = new eescwin(password);

            LockScreen.FormClosing += LockScreen_FormClosing;
            LockScreen.FormClosed += LockScreen_FormClosed;
        }

        private void LockScreen_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LockScreen_FormClosing(object? sender, FormClosingEventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case DEVICECHANGE:
                    if (isRunning)      ///if usbguard is running
                    {

                        usbinfo.updateDeviceList();


                        switch ((int)m.WParam)
                        {
                            case DBTDEVARRIVAL:

                                if (usbinfo.getRemovableDrives() > 0)
                                {
                                    showLockscreen();
                                }
                                break;
                            case DBTDEVREMOVED:

                                if (LockScreen == null)
                                {
                                    this.Close();
                                }
                                else if (usbinfo.getRemovableDrives() == 0)
                                {
                                    LockScreen.Hide();
                                }
                                break;
                        }
                    }
                    break;
            }

        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                pwd = new PasswordCTX(password);
                pwd.Show();
                pwd.FormClosing += Pwd_FormClosingPB1;
            }
            else
            {
                pictureButton.Image = Properties.Resources.btnoff1;
                isRunning = true;
                BGWorker.RunWorkerAsync();
            }

        }
        private void Pwd_FormClosingPB1(object? sender, FormClosingEventArgs e)
        {

            if (pwd != null)
                if (pwd.passCorrect)
                {
                    pictureButton.Image = Properties.Resources.btnon;
                    isRunning = false;
                }
            
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            string th = "", tm = "", ts = "";
            if(tmronHours < 10) { th = "0"; }
            if (tmronMinutes < 10) { tm = "0"; }
            if (tmronSeconds < 10) { ts = "0"; }
            th = th + tmronHours.ToString();
            tm = tm + tmronMinutes.ToString();
            ts = ts + tmronSeconds.ToString();
            StopTmrVal.Text = th + " : " + tm + " : " + ts;


            if (TimerCount >= 0)
            {
                TimerCount--;
            }else if(TimerCount == -1)
            {
                Hide();
                TimerCount = -2;
            }          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usbnotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1.Show();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning)
                Hide();
            else
                Close();
        }

        private void USBGUARD_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                StartTimer.Start();
            TimerCount = 15;
        }

        private void BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int SecondPassed = 0;

            while (isRunning)
            {
                if (SecondPassed != DateTime.Now.Second)
                {
                    SecondPassed = DateTime.Now.Second;
                    BGWorker.ReportProgress(60);
                }
                Thread.Sleep(1000);
            }
        }

        private void BGWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            if (isRunning)
            {
                Activelbl.ForeColor = Color.DarkCyan;
                Activelbl.Text = "Activated,";
            }
            else
            {
                Activelbl.ForeColor = Color.Red;
                Activelbl.Text = "Deactivated,";
            }

            tmronSeconds--;

            ///minutes 
            if (tmronSeconds < 0)
            {
                tmronSeconds = 59;
                tmronMinutes--;
            }
            ///hours
            if (tmronMinutes < 0)
            {
                tmronMinutes = 59;
                tmronHours--;
            }

            if (tmronHours < 0)
            {
                BGWorker.CancelAsync();
                Close();
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PasswordCTX pwd = new PasswordCTX(password);
            pwd.Show();
            pwd.FormClosing += Pwd_FormClosing;

        }

        private void Pwd_FormClosing(object? sender, FormClosingEventArgs e)
        {

            if (pwd != null)
            if(pwd.passCorrect)
            {
                    USBGsettings usbset;
                    usbset = new USBGsettings();
                    usbset.Show();
                }
        }

        private void USBGUARD_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void USBGUARD_Load(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            AppVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                              //var version = fieVersionInfo.FileVersion;
                              //LockScreen = new Form2();
            aboutlbl.Text = "This program was created for Tshwane University of Technology.\nCreated by MasangoFI, icons - Vecteezy.com, flaticon.com";

        }

        void showLockscreen()
        {
            if(LockScreen != null)
            {
                LockScreen.Show();
                LockScreen.TopMost = true;
                LockScreen.TopLevel = true;
                LockScreen.BringToFront();
            }

        }
    }
}
/*test comit test*/