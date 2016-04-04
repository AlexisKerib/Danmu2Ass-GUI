using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Danmu2Ass_GUI
{
    public partial class Win_Easy : UserControl
    {
        protected Process cmdp = new Process();
        public Win_Easy()
        {
            InitializeComponent();
        }

        private void btn_explo_easy_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) { txtb_file_easy.Text = openFileDialog.FileName; }
        }

        private void txtb_file_easy_DragDrop(object sender, DragEventArgs e)
        {
            txtb_file_easy.Text = (e.Data.GetData(DataFormats.FileDrop) as System.Array).GetValue(0).ToString();
        }

        private void txtb_file_easy_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) { e.Effect = DragDropEffects.Link; }
            else { e.Effect = DragDropEffects.None; }
        }

        private void btn_done_easy_Click(object sender, EventArgs e)
        {
            /// 若文件不存在则返回
            if (!File.Exists(txtb_file_easy.Text)) { MessageBox.Show("该文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            /// 若文件格式不为XML则提示
            string FileExtension = Path.GetExtension(txtb_file_easy.Text);
            if (FileExtension.ToLower() != ".xml")
            {
                var choose = MessageBox.Show("文件非XML格式文件，确定要转换吗？", "格式", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choose == DialogResult.No) { return; }
            }
            /// 设置运行参数后运行
            cmdp.StartInfo.UseShellExecute = true;
            cmdp.StartInfo.FileName = "Kaedei.Danmu2Ass.exe";
            cmdp.StartInfo.Arguments = "-s \"" + txtb_file_easy.Text + "\"";
            cmdp.Start();
            cmdp.WaitForExit(10000);
            /// 检测生成结果
            if (File.Exists(Path.GetFileNameWithoutExtension(txtb_file_easy.Text) + ".ass"))
            {
                MessageBox.Show("输出失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("输出成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
