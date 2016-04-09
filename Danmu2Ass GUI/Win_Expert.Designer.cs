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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lstv_FileList = new System.Windows.Forms.ListView();
            this.Files = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilesFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_output
            // 
            this.txtb_output.Location = new System.Drawing.Point(497, 153);
            this.txtb_output.Multiline = true;
            this.txtb_output.Name = "txtb_output";
            this.txtb_output.ReadOnly = true;
            this.txtb_output.Size = new System.Drawing.Size(296, 275);
            this.txtb_output.TabIndex = 1;
            this.txtb_output.Text = "等待开始...";
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(3, 397);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(114, 28);
            this.btn_AddItem.TabIndex = 2;
            this.btn_AddItem.Text = "添加项";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_DelItem
            // 
            this.btn_DelItem.Location = new System.Drawing.Point(377, 397);
            this.btn_DelItem.Name = "btn_DelItem";
            this.btn_DelItem.Size = new System.Drawing.Size(114, 28);
            this.btn_DelItem.TabIndex = 2;
            this.btn_DelItem.Text = "删除项";
            this.btn_DelItem.UseVisualStyleBackColor = true;
            this.btn_DelItem.Click += new System.EventHandler(this.btn_DelItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mkdb_LaterShoot);
            this.groupBox1.Controls.Add(this.mkdb_KeepSpace);
            this.groupBox1.Controls.Add(this.ckb_LaterShoot);
            this.groupBox1.Controls.Add(this.mkdb_VideoSize);
            this.groupBox1.Controls.Add(this.ckb_KeepSpace);
            this.groupBox1.Controls.Add(this.ckb_VideoSize);
            this.groupBox1.Location = new System.Drawing.Point(498, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置选项";
            // 
            // mkdb_LaterShoot
            // 
            this.mkdb_LaterShoot.BeepOnError = true;
            this.mkdb_LaterShoot.Location = new System.Drawing.Point(38, 84);
            this.mkdb_LaterShoot.Mask = "弹幕晚出现 099.999 秒";
            this.mkdb_LaterShoot.Name = "mkdb_LaterShoot";
            this.mkdb_LaterShoot.Size = new System.Drawing.Size(245, 21);
            this.mkdb_LaterShoot.TabIndex = 8;
            this.mkdb_LaterShoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdb_LaterShoot.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mkdb_KeepSpace
            // 
            this.mkdb_KeepSpace.BeepOnError = true;
            this.mkdb_KeepSpace.Location = new System.Drawing.Point(38, 52);
            this.mkdb_KeepSpace.Mask = "视频底部保留 09 分之一的区域";
            this.mkdb_KeepSpace.Name = "mkdb_KeepSpace";
            this.mkdb_KeepSpace.Size = new System.Drawing.Size(245, 21);
            this.mkdb_KeepSpace.TabIndex = 9;
            this.mkdb_KeepSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdb_KeepSpace.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.mkdb_VideoSize.BeepOnError = true;
            this.mkdb_VideoSize.Location = new System.Drawing.Point(95, 20);
            this.mkdb_VideoSize.Mask = "0099 长 × 0099 宽";
            this.mkdb_VideoSize.Name = "mkdb_VideoSize";
            this.mkdb_VideoSize.Size = new System.Drawing.Size(188, 21);
            this.mkdb_VideoSize.TabIndex = 10;
            this.mkdb_VideoSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdb_VideoSize.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.btn_StartConvert.Location = new System.Drawing.Point(190, 397);
            this.btn_StartConvert.Name = "btn_StartConvert";
            this.btn_StartConvert.Size = new System.Drawing.Size(114, 28);
            this.btn_StartConvert.TabIndex = 2;
            this.btn_StartConvert.Text = "开始转换";
            this.btn_StartConvert.UseVisualStyleBackColor = true;
            this.btn_StartConvert.Click += new System.EventHandler(this.btn_StartConvert_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(498, 118);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(295, 26);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            // 
            // lstv_FileList
            // 
            this.lstv_FileList.AllowDrop = true;
            this.lstv_FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Files,
            this.FilesFullName});
            this.lstv_FileList.FullRowSelect = true;
            this.lstv_FileList.GridLines = true;
            this.lstv_FileList.Location = new System.Drawing.Point(3, 3);
            this.lstv_FileList.Name = "lstv_FileList";
            this.lstv_FileList.Size = new System.Drawing.Size(489, 388);
            this.lstv_FileList.TabIndex = 7;
            this.lstv_FileList.UseCompatibleStateImageBehavior = false;
            this.lstv_FileList.View = System.Windows.Forms.View.Details;
            this.lstv_FileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstv_FileList_DragDrop);
            this.lstv_FileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstv_FileList_DragEnter);
            // 
            // Files
            // 
            this.Files.Text = "文件名";
            this.Files.Width = 130;
            // 
            // FilesFullName
            // 
            this.FilesFullName.Text = "完整路径";
            this.FilesFullName.Width = 350;
            // 
            // Win_Expert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstv_FileList);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_StartConvert);
            this.Controls.Add(this.btn_DelItem);
            this.Controls.Add(this.txtb_output);
            this.Controls.Add(this.btn_AddItem);
            this.Name = "Win_Expert";
            this.Size = new System.Drawing.Size(797, 428);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView lstv_FileList;
        private System.Windows.Forms.ColumnHeader Files;
        private System.Windows.Forms.ColumnHeader FilesFullName;
    }
}
