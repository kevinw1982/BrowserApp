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
        Navigate navWindow = new Navigate();

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

        private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (navWindow.ShowDialog() == DialogResult.OK)
            {
                NavigateToUrl(navWindow.txtUrl.Text);
            }
            navWindow.txtUrl.Text = "";
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            tsbBack.Enabled = false;
            tsbForward.Enabled = false;
            this.lblApplicationStatus.Text = "Ready";
        }

        private void myBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //modifying the label in the status strip with the URL entered by the User
            lblApplicationStatus.Text = "Navigating to: " + e.Url.Host.ToString();
        }

        private void myBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            /*The CurrentProgress variable from the rasied event
             * gives you the current number of bytes already downloaded
             * while the MaximumProgress is the total number of Bytes
             * to be Downloaded */
            if (e.CurrentProgress < e.MaximumProgress)
            {
                //check if the current progress in the Progress bar
                //is >= to the maximum if yes reset it with the min
                if (pbStatus.Value >= pbStatus.Maximum)
                    pbStatus.Value = pbStatus.Minimum;
                else
                    //just increase the progress bar
                    pbStatus.PerformStep();
            }
            else
                //when the document is fully downloaded
                //reset the progress bar to the min (0)
                pbStatus.Value = pbStatus.Minimum;
        }

        private void myBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //the about box is retrieving this information in a nice clean method so let's reuse it
            //If you don't have an about box you can just create this method using code from
            //the about box. we don't need to validate if the title is empty the method is doing it.
            //if it's empty it will use the .exe file
            this.Text = myAboutBox.AssemblyTitle + " - " + e.Url.Host.ToString();

            ModifyNavigateButtons();
            lblApplicationStatus.Text = "Ready";
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            myBrowser.GoBack();
        }

        private void tsbForward_Click(object sender, EventArgs e)
        {
            myBrowser.GoForward();
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            myBrowser.Stop();
            lblApplicationStatus.Text = "Ready";
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            myBrowser.Refresh();
            lblApplicationStatus.Text = "Ready";
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            myBrowser.GoHome();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            myBrowser.GoSearch();
        }

        public void ModifyNavigateButtons()
        {
            //add the code to enable or disable whenever there are URLs
            //in the browsing session's history
            if (myBrowser.CanGoBack)
                tsbBack.Enabled = true;
            else
                tsbBack.Enabled = false;

            if (myBrowser.CanGoForward)
                tsbForward.Enabled = true;
            else
                tsbForward.Enabled = false;
        }

        private void tstxtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            //e is of type KeyeventArgs and contains all the
            //information that triggered the event. The Keycode
            //is one those information
            if (e.KeyCode = Keys.Enter)
                this.NavigateToUrl(tstxtUrl.Text);
        }
        private void NavigateToUrl(string url)
        {
            myBrowser.Navigate(url);
        }

        private void tsbtnGo_Click(object sender, EventArgs e)
        {
            NavigateToUrl(tstxtUrl.Text);
        }
    }
}
