using System;
using System.Media;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CDTrackerV02
{
    public partial class Ingameoverlay : Form
    {
        // Stuff for click through and Application detection----------------------------
        public const string WINDOW_NAME = "League of Legends (TM) Client";
        IntPtr handle = FindWindow(null, WINDOW_NAME);
        public static Boolean INGAME;
        public static Boolean DEBUG;
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        //---------------------------------------------------------------------------
 

        public Ingameoverlay()
        {
            InitializeComponent();     
        }


        public void Button1_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner1.counters1 = CDTrackerMain.Summoner1.Spell1 - Properties.Settings.Default.Delay;
        }
        public void Button2_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner1.counters2 = CDTrackerMain.Summoner1.Spell2 - Properties.Settings.Default.Delay;
        }
        private void ButtonS21_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner2.counters1 = CDTrackerMain.Summoner2.Spell1 - Properties.Settings.Default.Delay;
        }

        private void ButtonS22_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner2.counters2 = CDTrackerMain.Summoner2.Spell2 - Properties.Settings.Default.Delay;
        }

        private void ButtonS31_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner3.counters1 = CDTrackerMain.Summoner3.Spell1 - Properties.Settings.Default.Delay;
        }

        private void ButtonS32_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner3.counters2 = CDTrackerMain.Summoner3.Spell2 - Properties.Settings.Default.Delay;
        }

        private void ButtonS41_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner4.counters1 = CDTrackerMain.Summoner4.Spell1 - Properties.Settings.Default.Delay;
        }

        private void ButtonS42_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner4.counters2 = CDTrackerMain.Summoner4.Spell2 - Properties.Settings.Default.Delay;
        }

        private void ButtonS51_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner5.counters1 = CDTrackerMain.Summoner5.Spell1 - Properties.Settings.Default.Delay;
        }

        private void ButtonS52_Click(object sender, EventArgs e)
        {
            CDTrackerMain.Summoner5.counters2 = CDTrackerMain.Summoner5.Spell2 - Properties.Settings.Default.Delay;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            IntPtr handle = FindWindow(null, WINDOW_NAME);
            if (handle != IntPtr.Zero || DEBUG == true)
            {
                if(INGAME == false)
                {
                    INGAME = true;
                    this.Show();
                    this.TopMost = true;
                    this.BringToFront();
                }

            }
            else
            {
                INGAME = false;
                this.Hide();
                CDTrackerMain.Summoner1.counters1 = 0;
                CDTrackerMain.Summoner1.counters2 = 0;
                CDTrackerMain.Summoner2.counters1 = 0;
                CDTrackerMain.Summoner2.counters2 = 0;
                CDTrackerMain.Summoner3.counters1 = 0;
                CDTrackerMain.Summoner3.counters2 = 0;
                CDTrackerMain.Summoner4.counters1 = 0;
                CDTrackerMain.Summoner4.counters2 = 0;
                CDTrackerMain.Summoner5.counters1 = 0;
                CDTrackerMain.Summoner5.counters2 = 0;
            }


            int cooldown;
            cooldown = CDTrackerMain.Summoner1.counters1;
            labelS11.Text = Convert.ToString(cooldown);
           
            cooldown = CDTrackerMain.Summoner1.counters2;
            labelS12.Text = Convert.ToString(cooldown);

            cooldown = CDTrackerMain.Summoner2.counters1;
            labelS21.Text = Convert.ToString(cooldown);
            cooldown = CDTrackerMain.Summoner2.counters2;
            labelS22.Text = Convert.ToString(cooldown);

            cooldown = CDTrackerMain.Summoner3.counters1;
            labelS31.Text = Convert.ToString(cooldown);
            cooldown = CDTrackerMain.Summoner3.counters2;
            labelS32.Text = Convert.ToString(cooldown);

            cooldown = CDTrackerMain.Summoner4.counters1;
            labelS41.Text = Convert.ToString(cooldown);
            cooldown = CDTrackerMain.Summoner4.counters2;
            labelS42.Text = Convert.ToString(cooldown);

            cooldown = CDTrackerMain.Summoner5.counters1;
            labelS51.Text = Convert.ToString(cooldown);
            cooldown = CDTrackerMain.Summoner5.counters2;
            labelS52.Text = Convert.ToString(cooldown);


            /////////////////////Summoner 1 Spell1
            if (CDTrackerMain.Summoner1.counters1 > 0)
            {
                CDTrackerMain.Summoner1.counters1--;
            }
            if (CDTrackerMain.Summoner1.counters1 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 1 Spell2
            if (CDTrackerMain.Summoner1.counters2 > 0)
            {
                CDTrackerMain.Summoner1.counters2--;
            }
            if (CDTrackerMain.Summoner1.counters2 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 2 Spell1
            if (CDTrackerMain.Summoner2.counters1 > 0)
            {
                CDTrackerMain.Summoner2.counters1--;
            }
            if (CDTrackerMain.Summoner2.counters1 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 2 Spell2
            if (CDTrackerMain.Summoner2.counters2 > 0)
            {
                CDTrackerMain.Summoner2.counters2--;
            }
            if (CDTrackerMain.Summoner2.counters2 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 3 Spell1
            if (CDTrackerMain.Summoner3.counters1 > 0)
            {
                CDTrackerMain.Summoner3.counters1--;
            }
            if (CDTrackerMain.Summoner3.counters1 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 3 Spell2
            if (CDTrackerMain.Summoner3.counters2 > 0)
            {
                CDTrackerMain.Summoner3.counters2--;
            }
            if (CDTrackerMain.Summoner3.counters2 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 4 Spell1
            if (CDTrackerMain.Summoner4.counters1 > 0)
            {
                CDTrackerMain.Summoner4.counters1--;
            }
            if (CDTrackerMain.Summoner4.counters1 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 4 Spell2
            if (CDTrackerMain.Summoner4.counters2 > 0)
            {
                CDTrackerMain.Summoner4.counters2--;
            }
            if (CDTrackerMain.Summoner4.counters2 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 5 Spell1
            if (CDTrackerMain.Summoner5.counters1 > 0)
            {
                CDTrackerMain.Summoner5.counters1--;
            }
            if (CDTrackerMain.Summoner5.counters1 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
            /////////////////////Summoner 5 Spell2
            if (CDTrackerMain.Summoner5.counters2 > 0)
            {
                CDTrackerMain.Summoner5.counters2--;
            }
            if (CDTrackerMain.Summoner5.counters2 == Properties.Settings.Default.Alarm && Properties.Settings.Default.AlarmEN == true)
            {
                SystemSounds.Asterisk.Play();
            }
        }

        private void Ingameoverlay_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //int initialStyle = GetWindowLong(this.Handle, -20);
            //SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            this.Left = (int)Properties.Settings.Default.Coord_X;
            this.Top = (int)Properties.Settings.Default.Coord_Y;
            buttonS11.BackgroundImage = Properties.Resources.Flash;
            buttonS12.BackgroundImage = Properties.Resources.Teleport;
            buttonS21.BackgroundImage = Properties.Resources.Flash;
            buttonS22.BackgroundImage = Properties.Resources.Smite;
            buttonS31.BackgroundImage = Properties.Resources.Flash;
            buttonS32.BackgroundImage = Properties.Resources.Ignite;
            buttonS41.BackgroundImage = Properties.Resources.Flash;
            buttonS42.BackgroundImage = Properties.Resources.Heal;
            buttonS51.BackgroundImage = Properties.Resources.Flash;
            buttonS52.BackgroundImage = Properties.Resources.Ignite;
        }
    }
}
