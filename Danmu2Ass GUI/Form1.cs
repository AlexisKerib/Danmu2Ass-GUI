using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Danmu2Ass_GUI
{
    public partial class Win_Main : Form
    {
        public Win_Main()
        {
            InitializeComponent();
        }

        public Win_Easy win_ea;
        public Win_Expert win_ex;
        public Win_Main win_ma;

        private void Win_Main_Load(object sender, EventArgs e)
        {
            /// 实例化两个窗口（用户组件）
            win_ea = new Win_Easy();
            win_ex = new Win_Expert();;
            comb_choosemode.SelectedIndex = 0;
        }

        private void comb_choosemode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_choosemode.SelectedIndex == 0)
            {
                /// 切换到Easy窗口
                win_ea.Show();
                gpbWindows.Controls.Clear();
                gpbWindows.Controls.Add(win_ea);
                gpbWindows.Size = win_ea.Size;
                this.Size = win_ea.Size + new Size(20, 70);
                comb_choosemode.Location = new Point(12, 90);
                linkLabel1.Location = new Point(325, 90);
            }
            else
            {
                /// 切换到Expert窗口
                win_ex.Show();
                gpbWindows.Controls.Clear();
                gpbWindows.Controls.Add(win_ex);
                gpbWindows.Size = win_ex.Size;
                this.Size = win_ex.Size + new Size(19, 70);
                comb_choosemode.Location = new Point(6, 432);
                linkLabel1.Location = new Point(670, 436);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://danmu2assgui.codeplex.com/");
        }
    }
}
