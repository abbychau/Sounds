﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sounds
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            versionLabel.Text = string.Format("Sounds {0}", ProductVersion);
        }

        private void websiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://cmpct.info/~calvin/Sounds/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/abbychau/Sounds");
        }
    }
}
