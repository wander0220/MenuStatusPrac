using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStatusPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 새로 만들기 할꺼임?");
        }

        private void 배고파ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "하...점심시간 언제옴?";
            toolStripProgressBar1.Value = 10;
        }

        private void 복통ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "꼬르륵..꼴르륵... 아... 민망쓰";
            toolStripProgressBar1.Value = 30;
        }

        private void ㄸㅂToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "으아으아아악 으아아악";
            toolStripProgressBar1.Value = 60;
        }

        private void 배불름ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "후식 ㄱ?";
            toolStripProgressBar1.Value = 90;
        }
    }
}
