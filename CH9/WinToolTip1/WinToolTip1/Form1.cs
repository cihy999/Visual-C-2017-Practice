using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinToolTip1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "碁峯資訊";
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "碁峯給您快樂學習";
            toolTip1.BackColor = Color.Orange;
            toolTip1.SetToolTip(linkLabel1, "碁峯提供好書");
            linkLabel2.Text = "請聯絡我們";
            linkLabel2.LinkArea = new LinkArea(1, 2);
            toolTip2.SetToolTip(linkLabel2, "歡迎讀者來信");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:cijy999@gmail.com");
        }
    }
}
