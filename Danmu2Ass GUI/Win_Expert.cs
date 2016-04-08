using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace Danmu2Ass_GUI
{
    public partial class Win_Expert : UserControl
    {
        public Process cmdp = new Process();
        public Win_Expert()
        {
            InitializeComponent();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    ///若该项已存在，则不添加
                    if (lstv_FileList.FindItemWithText(filename) == null)
                    {
                        lstv_FileList.Items.Add(new ListViewItem(new string[2] { Path.GetFileName(filename), filename }));
                    }
                }
            }
        }

        private void btn_DelItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem indexes in lstv_FileList.SelectedItems) { lstv_FileList.Items.Remove(indexes);}
        }

        private void btn_StartConvert_Click(object sender, EventArgs e)
        {
            string commnd = "";
            txtb_output.Clear();
            txtb_output.Text += "转换开始..." + Environment.NewLine;

            try
            {
                List<string> optionList = new List<string>();
                string[] shiftSec = { };
                optionList.Add("-s"); //加静默参数
                if (ckb_VideoSize.Checked)
                {
                    var videoSize = new string[2];
                    txtb_output.Text += "视频大小已设置。" + Environment.NewLine;
                    videoSize = new Regex("\\s+").Replace(mkdb_VideoSize.Text, "|").Split('|');
                    // txtb_output.Text += videoSize.Length; //
                    if (videoSize.Length < 2)
                    {
                        videoSize = new string[2];
                        videoSize[0] = mkdb_VideoSize.Text.Substring(0, 4);
                        videoSize[1] = mkdb_VideoSize.Text.Substring(4, mkdb_VideoSize.Text.Length - 4);
                    }

                    optionList.Add("-width " + videoSize[0]);
                    optionList.Add("-height " + videoSize[1]);
                }
                if (ckb_KeepSpace.Checked)
                {
                    txtb_output.Text += "底部留空已设置。" + Environment.NewLine;
                    string keepSpace = mkdb_KeepSpace.Text.Replace(' ', '\0');
                    if (keepSpace == "") { keepSpace = "6"; }
                    optionList.Add("-bottom " + keepSpace);
                }
                if (ckb_LaterShoot.Checked)
                {
                    txtb_output.Text += "延迟时间已设置。" + Environment.NewLine;
                    shiftSec = new Regex("[\\s]+").Replace(mkdb_LaterShoot.Text, " ").Split(' ');
                    if (shiftSec[2] == null) { shiftSec[1] = "0"; }
                    optionList.Add("-shift " + shiftSec[0] + "." + shiftSec[1]);
                }
                commnd = string.Join(" ", optionList); 
            }
            catch (Exception ex)
            {
                txtb_output.Text += "处理参数错误！" + ex.Message;
                return;
            }
            txtb_output.Text += "输出参数：" + commnd + Environment.NewLine;

            /// 设置运行参数后运行
            cmdp.StartInfo.UseShellExecute = true;
            cmdp.StartInfo.FileName = "Kaedei.Danmu2Ass.exe";
            progressBar.Value = 0;
            progressBar.Maximum = lstv_FileList.Items.Count;

            for (int i = 0; i < lstv_FileList.Items.Count; i++)
            {
                txtb_output.Text += "处理：" + lstv_FileList.Items[i].Text + Environment.NewLine;
                cmdp.StartInfo.Arguments = commnd + " \"" + lstv_FileList.Items[i].SubItems[1].Text + "\"";
                cmdp.Start();
                cmdp.WaitForExit(10000);
                progressBar.PerformStep();
            }
            // ;
            // cmdp.Start();

            txtb_output.Text += Environment.NewLine + "输出结束。";
        }
    }
}
