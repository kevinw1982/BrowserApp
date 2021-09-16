
namespace BrowserApp
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.myBrowser = new System.Windows.Forms.WebBrowser();
            this.msBrowser = new System.Windows.Forms.MenuStrip();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.sscBrowser = new System.Windows.Forms.StatusStrip();
            this.lblApplicationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tsNavigation = new System.Windows.Forms.ToolStrip();
            this.tslblAddress = new System.Windows.Forms.ToolStripLabel();
            this.tstxtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnGo = new System.Windows.Forms.ToolStripButton();
            this.tsIcons = new System.Windows.Forms.ToolStrip();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbForward = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.msBrowser.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.sscBrowser.SuspendLayout();
            this.tsNavigation.SuspendLayout();
            this.tsIcons.SuspendLayout();
            this.SuspendLayout();
            // 
            // myBrowser
            // 
            this.myBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myBrowser.Location = new System.Drawing.Point(0, 0);
            this.myBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myBrowser.Name = "myBrowser";
            this.myBrowser.Size = new System.Drawing.Size(624, 345);
            this.myBrowser.TabIndex = 0;
            this.myBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.myBrowser_DocumentCompleted);
            this.myBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.myBrowser_Navigating);
            this.myBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.myBrowser_ProgressChanged);
            // 
            // msBrowser
            // 
            this.msBrowser.Dock = System.Windows.Forms.DockStyle.None;
            this.msBrowser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msBrowser.Location = new System.Drawing.Point(0, 25);
            this.msBrowser.Name = "msBrowser";
            this.msBrowser.Size = new System.Drawing.Size(624, 24);
            this.msBrowser.TabIndex = 1;
            this.msBrowser.Text = "menuStrip1";
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.navigateToolStripMenuItem.Text = "&Navigate";
            this.navigateToolStripMenuItem.Click += new System.EventHandler(this.navigateToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.sscBrowser);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.myBrowser);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(624, 345);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(624, 441);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsIcons);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsNavigation);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.msBrowser);
            // 
            // sscBrowser
            // 
            this.sscBrowser.Dock = System.Windows.Forms.DockStyle.None;
            this.sscBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblApplicationStatus,
            this.pbStatus});
            this.sscBrowser.Location = new System.Drawing.Point(0, 0);
            this.sscBrowser.Name = "sscBrowser";
            this.sscBrowser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sscBrowser.Size = new System.Drawing.Size(624, 22);
            this.sscBrowser.TabIndex = 0;
            // 
            // lblApplicationStatus
            // 
            this.lblApplicationStatus.Name = "lblApplicationStatus";
            this.lblApplicationStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // pbStatus
            // 
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // tsNavigation
            // 
            this.tsNavigation.Dock = System.Windows.Forms.DockStyle.None;
            this.tsNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblAddress,
            this.tstxtUrl,
            this.tsbtnGo});
            this.tsNavigation.Location = new System.Drawing.Point(3, 0);
            this.tsNavigation.Name = "tsNavigation";
            this.tsNavigation.Size = new System.Drawing.Size(437, 25);
            this.tsNavigation.TabIndex = 2;
            this.tsNavigation.Text = "toolStrip2";
            // 
            // tslblAddress
            // 
            this.tslblAddress.Name = "tslblAddress";
            this.tslblAddress.Size = new System.Drawing.Size(0, 22);
            // 
            // tstxtUrl
            // 
            this.tstxtUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtUrl.Name = "tstxtUrl";
            this.tstxtUrl.Size = new System.Drawing.Size(350, 25);
            this.tstxtUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tstxtUrl_KeyUp);
            // 
            // tsbtnGo
            // 
            this.tsbtnGo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGo.Image")));
            this.tsbtnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGo.Name = "tsbtnGo";
            this.tsbtnGo.Size = new System.Drawing.Size(42, 22);
            this.tsbtnGo.Text = "Go";
            this.tsbtnGo.Click += new System.EventHandler(this.tsbtnGo_Click);
            // 
            // tsIcons
            // 
            this.tsIcons.Dock = System.Windows.Forms.DockStyle.None;
            this.tsIcons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBack,
            this.tsbForward,
            this.tsbStop,
            this.tsbRefresh,
            this.tsbHome,
            this.tsbSearch});
            this.tsIcons.Location = new System.Drawing.Point(3, 49);
            this.tsIcons.Name = "tsIcons";
            this.tsIcons.Size = new System.Drawing.Size(189, 25);
            this.tsIcons.TabIndex = 1;
            this.tsIcons.Text = "toolStrip1";
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbBack.Image")));
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(23, 22);
            this.tsbBack.Text = "toolStripButton1";
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            // 
            // tsbForward
            // 
            this.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbForward.Image = ((System.Drawing.Image)(resources.GetObject("tsbForward.Image")));
            this.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForward.Name = "tsbForward";
            this.tsbForward.Size = new System.Drawing.Size(23, 22);
            this.tsbForward.Text = "toolStripButton3";
            this.tsbForward.Click += new System.EventHandler(this.tsbForward_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "toolStripButton4";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "toolStripButton5";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbHome
            // 
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.Image = ((System.Drawing.Image)(resources.GetObject("tsbHome.Image")));
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(23, 22);
            this.tsbHome.Text = "toolStripButton6";
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(62, 22);
            this.tsbSearch.Text = "Search";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.msBrowser;
            this.Name = "Browser";
            this.Text = "My Own Browser";
            this.Activated += new System.EventHandler(this.Browser_Activated);
            this.Load += new System.EventHandler(this.Browser_Load);
            this.msBrowser.ResumeLayout(false);
            this.msBrowser.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.sscBrowser.ResumeLayout(false);
            this.sscBrowser.PerformLayout();
            this.tsNavigation.ResumeLayout(false);
            this.tsNavigation.PerformLayout();
            this.tsIcons.ResumeLayout(false);
            this.tsIcons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser myBrowser;
        private System.Windows.Forms.MenuStrip msBrowser;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip sscBrowser;
        private System.Windows.Forms.ToolStripStatusLabel lblApplicationStatus;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.ToolStrip tsNavigation;
        private System.Windows.Forms.ToolStrip tsIcons;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbForward;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripLabel tslblAddress;
        private System.Windows.Forms.ToolStripTextBox tstxtUrl;
        private System.Windows.Forms.ToolStripButton tsbtnGo;
    }
}

