using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace BrowserApp
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.lblApplicationTitle.Text = AssemblyTitle;
            this.lblCopyright.Text = AssemblyCopyright;
            this.lblVersion.Text = "version: " + AssemblyVersion;
        }
        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                //get all Title attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                //if there is at least one title attribute
                if (attributes.Length > 0)
                {
                    //select the First one
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    //if it is not an empty string, return it
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                //if there was no Title attribute, or the string was empty, return the .exe name
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get 
            {
                //get all Description attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                //If there aren't any Description attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                //if there is a description attribute, return its value
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                //get all Product attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                //If there aren't any Product attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                //if there is a Product attribute, return its value
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get 
            {
                //get all Copyright attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                //If there aren't any Copyright attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                //if there is a Copyright attribute, return its value
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                //get all Company attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                //If there aren't any Company attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                //if there is a Company attribute, return its value
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}