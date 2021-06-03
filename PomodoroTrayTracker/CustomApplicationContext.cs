using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace PoomodoroTrayTracker
{
    public class CustomApplicationContext : ApplicationContext
    {
        public CustomApplicationContext()
        {
            InitializeContext();
        }

        private void InitializeContext()
        {
            IContainer components = new Container();
            NotifyIcon notifyIcon = new NotifyIcon(components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = new Icon("donut_chart.ico"),
                Text = "Pomodoro tray tracker application",
                Visible = true
            };

        }
    }
}
