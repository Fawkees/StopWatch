using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CDTrackerV02
{

    public partial class CDTrackerMain : Form
    {
        public int[] Cooldowns = new int[] { 180, 240, 210, 210, 300, 180, 240, 180, 90, 360};
   
        Ingameoverlay Ingameoverlay = new Ingameoverlay();
        static public Summoner Summoner1 = new Summoner();
        static public Summoner Summoner2 = new Summoner();
        static public Summoner Summoner3 = new Summoner();
        static public Summoner Summoner4 = new Summoner();
        static public Summoner Summoner5 = new Summoner();

        public CDTrackerMain()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxS11.SelectedIndex = 4;
            comboBoxS12.SelectedIndex = 9;
            comboBoxS21.SelectedIndex = 4;
            comboBoxS22.SelectedIndex = 8;
            comboBoxS31.SelectedIndex = 4;
            comboBoxS32.SelectedIndex = 7;
            comboBoxS41.SelectedIndex = 4;
            comboBoxS42.SelectedIndex = 6;
            comboBoxS51.SelectedIndex = 4;
            comboBoxS52.SelectedIndex = 7;

            checkBoxAlarm.Checked = Properties.Settings.Default.AlarmEN;
            numericUpDownAlarm.Value = Properties.Settings.Default.Alarm;

            Coord_X_Box.Value = Properties.Settings.Default.Coord_X;
            Coord_Y_Box.Value = Properties.Settings.Default.Coord_Y;

            numericUpDownDelay.Value = Properties.Settings.Default.Delay;

        }

        private void ComboBoxS11_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS11.SelectedIndex;

           Summoner1.Spell1 = Cooldowns[selectedIndex];

            switch (comboBoxS11.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }
        private void comboBoxS12_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS12.SelectedIndex;
            Summoner1.Spell2 = Cooldowns[selectedIndex];

            switch (comboBoxS12.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS12.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }
        private void comboBoxS21_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS21.SelectedIndex;

            Summoner2.Spell1 = Cooldowns[selectedIndex];

            switch (comboBoxS21.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }

        private void comboBoxS22_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS22.SelectedIndex;

            Summoner2.Spell2 = Cooldowns[selectedIndex];

            switch (comboBoxS22.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }

        private void comboBoxS31_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS31.SelectedIndex;

            Summoner3.Spell1 = Cooldowns[selectedIndex];

            switch (comboBoxS31.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }

        private void comboBoxS32_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS32.SelectedIndex;

            Summoner3.Spell2 = Cooldowns[selectedIndex];

            switch (comboBoxS32.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }

        private void comboBoxS41_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS41.SelectedIndex;

            Summoner4.Spell1 = Cooldowns[selectedIndex];

            switch (comboBoxS41.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }

        private void comboBoxS42_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS42.SelectedIndex;

            Summoner4.Spell2 = Cooldowns[selectedIndex];

            switch (comboBoxS42.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }

        private void comboBoxS51_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS51.SelectedIndex;

            Summoner5.Spell1 = Cooldowns[selectedIndex];

            switch (comboBoxS51.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }

        private void comboBoxS52_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxS52.SelectedIndex;

            Summoner5.Spell2 = Cooldowns[selectedIndex];

            switch (comboBoxS52.SelectedItem)
            {
                case "Flash":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Flash;
                    break;
                case "Teleport":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Teleport;
                    break;
                case "Ignite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ignite;
                    break;
                case "Barrier":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Barrier;
                    break;
                case "Exhaust":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Exhaust;
                    break;
                case "Heal":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Heal;
                    break;
                case "Ghost":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Ghost;
                    break;
                case "Smite":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Smite;
                    break;
                case "Cleanse":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Cleanse;
                    break;
                case "Clarity":
                    Ingameoverlay.buttonS11.BackgroundImage = Properties.Resources.Clarity;
                    break;
            }
        }
        private void numericUpDownDelay_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Delay = (int)numericUpDownDelay.Value;
        }

        private void CheckBox_ShowOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowOverlay.Checked == true)
            {
                Ingameoverlay.DEBUG = true;
                Ingameoverlay.INGAME = true;
                Ingameoverlay.Show();

            }
            else
            {
                Ingameoverlay.DEBUG = false;
                Ingameoverlay.INGAME = false;
                Ingameoverlay.Hide();
            }
        }
        private void Coord_X_Box_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Coord_X = Coord_X_Box.Value;
            Ingameoverlay.Left = (int)Properties.Settings.Default.Coord_X;
        }

        private void Coord_Y_Box_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Coord_Y = Coord_Y_Box.Value;
            Ingameoverlay.Top = (int)Properties.Settings.Default.Coord_Y;
        }


        private void Save_Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Ingameoverlay.Left = (int)Properties.Settings.Default.Coord_X;
            Ingameoverlay.Top = (int)Properties.Settings.Default.Coord_Y;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Summoner1.counters1 = 0;
            Summoner1.counters2 = 0;
            Summoner2.counters1 = 0;
            Summoner2.counters2 = 0;
            Summoner3.counters1 = 0;
            Summoner3.counters2 = 0;
            Summoner4.counters1 = 0;
            Summoner4.counters2 = 0;
            Summoner5.counters1 = 0;
            Summoner5.counters2 = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The overlay will show up automatically when the game starts. Make sure you run League in borderless mode for this to work.\r\r" +
                "Settings:\r\r" +
                "Tick 'Show Overlay' and adjust its position by adjusting the coordiates. Untick to hide it after you'r done\r\r" +
                "Alarm will play a Windows error sound before a spell comes back up. Time in seconds.\r\r" +
                "The delay value makes up for the time between a spell being used and you starting the timer.\r\r" +
                "Make sure to press Save so you dont have to redo all the settings everytime you restart Stopwatch.exe");
        }
        private void NumericUpDownAlarm_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Alarm = (int)numericUpDownAlarm.Value;
        }
        private void CheckBoxAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAlarm.Checked == true)
            {
                 Properties.Settings.Default.AlarmEN = true;
            }
            else
            {
                Properties.Settings.Default.AlarmEN = false;
            }
        }
    }

    public class Summoner
    {
        public int Spell1;
        public int Spell2;
        public int counters1;
        public int counters2;
    }


}
