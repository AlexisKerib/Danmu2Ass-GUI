namespace Danmu2Ass_GUI
{
    partial class Win_Easy
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_file_easy = new System.Windows.Forms.TextBox();
            this.btn_explo_easy = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_done_easy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要转换成ASS的XML文件：（将生成在源文件目录下）";
            // 
            // txtb_file_easy
            // 
            this.txtb_file_easy.AllowDrop = true;
            this.txtb_file_easy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtb_file_easy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtb_file_easy.Location = new System.Drawing.Point(8, 31);
            this.txtb_file_easy.Name = "txtb_file_easy";
            this.txtb_file_easy.Size = new System.Drawing.Size(436, 21);
            this.txtb_file_easy.TabIndex = 1;
            this.txtb_file_easy.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtb_file_easy_DragDrop);
            this.txtb_file_easy.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtb_file_easy_DragEnter);
            // 
            // btn_explo_easy
            // 
            this.btn_explo_easy.Location = new System.Drawing.Point(8, 58);
            this.btn_explo_easy.Name = "btn_explo_easy";
            this.btn_explo_easy.Size = new System.Drawing.Size(66, 22);
            this.btn_explo_easy.TabIndex = 2;
            this.btn_explo_easy.Text = "浏览...";
            this.btn_explo_easy.UseVisualStyleBackColor = true;
            this.btn_explo_easy.Click += new System.EventHandler(this.btn_explo_easy_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "XML 弹幕文件|*.xml|JSON 弹幕文件|*.json|所有文件|*.*";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "选择文件...";
            // 
            // btn_done_easy
            // 
            this.btn_done_easy.Location = new System.Drawing.Point(378, 58);
            this.btn_done_easy.Name = "btn_done_easy";
            this.btn_done_easy.Size = new System.Drawing.Size(66, 22);
            this.btn_done_easy.TabIndex = 2;
            this.btn_done_easy.Text = "生成";
            this.btn_done_easy.UseVisualStyleBackColor = true;
            this.btn_done_easy.Click += new System.EventHandler(this.btn_done_easy_Click);
            // 
            // Win_Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_done_easy);
            this.Controls.Add(this.btn_explo_easy);
            this.Controls.Add(this.txtb_file_easy);
            this.Controls.Add(this.label1);
            this.Name = "Win_Easy";
            this.Size = new System.Drawing.Size(451, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_file_easy;
        private System.Windows.Forms.Button btn_explo_easy;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_done_easy;
    }
}
