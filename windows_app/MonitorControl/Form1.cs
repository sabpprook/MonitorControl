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
using NHotkey.WindowsForms;

namespace MonitorControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HotkeyManager.Current.AddOrReplace("PowerSwitch", Keys.Alt | Keys.Escape, HotkeyEvent.Hotkey_EventTrigger);
            HotkeyManager.Current.AddOrReplace("DisplayPort_1", Keys.Shift | Keys.ShiftKey | Keys.F1, HotkeyEvent.Hotkey_EventTrigger);
            HotkeyManager.Current.AddOrReplace("DisplayPort_2", Keys.Shift | Keys.ShiftKey | Keys.F2, HotkeyEvent.Hotkey_EventTrigger);
            HotkeyManager.Current.AddOrReplace("HDMI_1", Keys.Shift | Keys.ShiftKey | Keys.F3, HotkeyEvent.Hotkey_EventTrigger);
            HotkeyManager.Current.AddOrReplace("HDMI_2", Keys.Shift | Keys.ShiftKey | Keys.F4, HotkeyEvent.Hotkey_EventTrigger);

            RemoteServer server = new RemoteServer(7999);
            server.Start();

            notifyIcon1.Icon = Icon;
            Hide();
        }

        private void Menu_Switch_Click(object sender, EventArgs e)
        {
            HotkeyEvent.Hotkey_EventTrigger(sender, new CustomEventArgs((sender as ToolStripMenuItem).Text));
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
