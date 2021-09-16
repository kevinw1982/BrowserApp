using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BrowserApp
{
    public partial class Browser : Form
    {
        Splash splashscreen = new Splash();
        AboutBox myAboutBox = new AboutBox();

        public Browser()
        {
            InitializeComponent();
            splashscreen.Show();
            Application.DoEvents();
        }

        private void Browser_Activated(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            splashscreen.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myAboutBox.ShowDialog();
        }
    }
}
