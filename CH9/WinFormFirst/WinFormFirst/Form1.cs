using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "表單載入時...";
            label1.Font = new Font("標楷體", 14, FontStyle.Bold^FontStyle.Italic);
            this.BackColor = Color.Red;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "按一下表單...";
            this.BackColor = Color.Yellow;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "按兩下表單...";
            this.BackColor = Color.Aqua;
        }
    }
}
