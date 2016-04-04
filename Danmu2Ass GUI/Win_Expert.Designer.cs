namespace Danmu2Ass_GUI
{
    partial class Win_Expert
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstb_FileList = new System.Windows.Forms.ListBox();
            this.txtb_output = new System.Windows.Forms.TextBox();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_DelItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkdb_LaterShoot = new System.Windows.Forms.MaskedTextBox();
            this.mkdb_KeepSpace = new System.Windows.Forms.MaskedTextBox();
            this.ckb_LaterShoot = new System.Windows.Forms.CheckBox();
            this.mkdb_VideoSize = new System.Windows.Forms.MaskedTextBox();
            this.ckb_KeepSpace = new System.Windows.Forms.CheckBox();
            this.ckb_VideoSize = new System.Windows.Forms.CheckBox();
            this.btn_StartConvert = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstb_FileList
            // 
            this.lstb_FileList.FormattingEnabled = true;
            this.lstb_FileList.ItemHeight = 12;
            this.lstb_FileList.Location = new System.Drawing.Point(3, 3);
            this.lstb_FileList.Name = "lstb_FileList";
            this.lstb_FileList.Size = new System.Drawing.Size(323, 268);
            this.lstb_FileList.TabIndex = 0;
            // 
            // txtb_output
            // 
            this.txtb_output.Location = new System.Drawing.Point(332, 150);
            this.txtb_output.Multiline = true;
            this.txtb_output.Name = "txtb_output";
            this.txtb_output.ReadOnly = true;
            this.txtb_output.Size = new System.Drawing.Size(296, 155);
            this.txtb_output.TabIndex = 1;
            this.txtb_output.Text = "等待开始...";
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(3, 277);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(90, 28);
            this.btn_AddItem.TabIndex = 2;
            this.btn_AddItem.Text = "添加项";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            // 
            // btn_DelItem
            // 
            this.btn_DelItem.Location = new System.Drawing.Point(236, 277);
            this.btn_DelItem.Name = "btn_DelItem";
            this.btn_DelItem.Size = new System.Drawing.Size(90, 28);
            this.btn_DelItem.TabIndex = 2;
            this.btn_DelItem.Text = "删除项";
            this.btn_DelItem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mkdb_LaterShoot);
            this.groupBox1.Controls.Add(this.mkdb_KeepSpace);
            this.groupBox1.Controls.Add(this.ckb_LaterShoot);
            this.groupBox1.Controls.Add(this.mkdb_VideoSize);
            this.groupBox1.Controls.Add(this.ckb_KeepSpace);
            this.groupBox1.Controls.Add(this.ckb_VideoSize);
            this.groupBox1.Location = new System.Drawing.Point(332, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置选项";
            // 
            // mkdb_LaterShoot
            // 
            this.mkdb_LaterShoot.Location = new System.Drawing.Point(38, 84);
            this.mkdb_LaterShoot.Mask = "弹幕晚出现 099.999 秒";
            this.mkdb_LaterShoot.Name = "mkdb_LaterShoot";
            this.mkdb_LaterShoot.Size = new System.Drawing.Size(245, 21);
            this.mkdb_LaterShoot.TabIndex = 8;
            this.mkdb_LaterShoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkdb_KeepSpace
            // 
            this.mkdb_KeepSpace.Location = new System.Drawing.Point(38, 52);
            this.mkdb_KeepSpace.Mask = "视频底部保留 0 分之一的区域";
            this.mkdb_KeepSpace.Name = "mkdb_KeepSpace";
            this.mkdb_KeepSpace.Size = new System.Drawing.Size(245, 21);
            this.mkdb_KeepSpace.TabIndex = 9;
            this.mkdb_KeepSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckb_LaterShoot
            // 
            this.ckb_LaterShoot.AutoSize = true;
            this.ckb_LaterShoot.Location = new System.Drawing.Point(17, 87);
            this.ckb_LaterShoot.Name = "ckb_LaterShoot";
            this.ckb_LaterShoot.Size = new System.Drawing.Size(15, 14);
            this.ckb_LaterShoot.TabIndex = 5;
            this.ckb_LaterShoot.UseVisualStyleBackColor = true;
            // 
            // mkdb_VideoSize
            // 
            this.mkdb_VideoSize.Location = new System.Drawing.Point(95, 20);
            this.mkdb_VideoSize.Mask = "0099 长 × 0099 宽";
            this.mkdb_VideoSize.Name = "mkdb_VideoSize";
            this.mkdb_VideoSize.Size = new System.Drawing.Size(188, 21);
            this.mkdb_VideoSize.TabIndex = 10;
            this.mkdb_VideoSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckb_KeepSpace
            // 
            this.ckb_KeepSpace.AutoSize = true;
            this.ckb_KeepSpace.Location = new System.Drawing.Point(17, 55);
            this.ckb_KeepSpace.Name = "ckb_KeepSpace";
            this.ckb_KeepSpace.Size = new System.Drawing.Size(15, 14);
            this.ckb_KeepSpace.TabIndex = 6;
            this.ckb_KeepSpace.UseVisualStyleBackColor = true;
            // 
            // ckb_VideoSize
            // 
            this.ckb_VideoSize.AutoSize = true;
            this.ckb_VideoSize.Location = new System.Drawing.Point(17, 22);
            this.ckb_VideoSize.Name = "ckb_VideoSize";
            this.ckb_VideoSize.Size = new System.Drawing.Size(72, 16);
            this.ckb_VideoSize.TabIndex = 7;
            this.ckb_VideoSize.Text = "视频大小";
            this.ckb_VideoSize.UseVisualStyleBackColor = true;
            // 
            // btn_StartConvert
            // 
            this.btn_StartConvert.Location = new System.Drawing.Point(119, 277);
            this.btn_StartConvert.Name = "btn_StartConvert";
            this.btn_StartConvert.Size = new System.Drawing.Size(90, 28);
            this.btn_StartConvert.TabIndex = 2;
            this.btn_StartConvert.Text = "开始转换";
            this.btn_StartConvert.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(332, 118);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(295, 26);
            this.progressBar1.TabIndex = 6;
            // 
            // Win_Expert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_StartConvert);
            this.Controls.Add(this.btn_DelItem);
            this.Controls.Add(this.txtb_output);
            this.Controls.Add(this.lstb_FileList);
            this.Controls.Add(this.btn_AddItem);
            this.Name = "Win_Expert";
            this.Size = new System.Drawing.Size(631, 313);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_FileList;
        private System.Windows.Forms.TextBox txtb_output;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_DelItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mkdb_LaterShoot;
        private System.Windows.Forms.MaskedTextBox mkdb_KeepSpace;
        private System.Windows.Forms.CheckBox ckb_LaterShoot;
        private System.Windows.Forms.MaskedTextBox mkdb_VideoSize;
        private System.Windows.Forms.CheckBox ckb_KeepSpace;
        private System.Windows.Forms.CheckBox ckb_VideoSize;
        private System.Windows.Forms.Button btn_StartConvert;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
