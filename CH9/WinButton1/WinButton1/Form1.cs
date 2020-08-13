using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinButton1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int guess;

        void CheckAns(int ans)
        {
            if (guess == ans)
            {
                lblShow.Text = "太棒了...答對了！！";

                if (ans == 1) button1.BackColor = Color.Black;
                if (ans == 2) button2.BackColor = Color.Black;
                if (ans == 3) button3.BackColor = Color.Black;
            }
            else 
            {
                lblShow.Text = "不在這裡...猜錯了";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAgain_Click(sender, e);
            this.Text = "找雪人遊戲";
            lblShow.Text = "請問黑牌是哪張？";
            lblShow.Font = new Font(lblShow.Font.FontFamily, 14, FontStyle.Regular);
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(1, 4);
            lblShow.Text = "";
            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button1.BackColor = button2.BackColor = button3.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAns(1);
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAns(2);
            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckAns(3);
            button1.Enabled = false;
            button2.Enabled = false;
        }
    }
}
