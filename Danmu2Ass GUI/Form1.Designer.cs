namespace Danmu2Ass_GUI
{
    partial class Win_Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbWindows = new System.Windows.Forms.GroupBox();
            this.comb_choosemode = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // gpbWindows
            // 
            this.gpbWindows.Location = new System.Drawing.Point(3, 1);
            this.gpbWindows.Name = "gpbWindows";
            this.gpbWindows.Size = new System.Drawing.Size(451, 87);
            this.gpbWindows.TabIndex = 0;
            this.gpbWindows.TabStop = false;
            // 
            // comb_choosemode
            // 
            this.comb_choosemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_choosemode.FormattingEnabled = true;
            this.comb_choosemode.Items.AddRange(new object[] {
            "简单模式 - Easy Mode",
            "专家模式 - Expert Mode"});
            this.comb_choosemode.Location = new System.Drawing.Point(3, 94);
            this.comb_choosemode.Name = "comb_choosemode";
            this.comb_choosemode.Size = new System.Drawing.Size(171, 20);
            this.comb_choosemode.TabIndex = 1;
            this.comb_choosemode.SelectedIndexChanged += new System.EventHandler(this.comb_choosemode_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(329, 97);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open-Source Project";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Win_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 124);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comb_choosemode);
            this.Controls.Add(this.gpbWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Win_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danmu2Ass GUI";
            this.Load += new System.EventHandler(this.Win_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbWindows;
        private System.Windows.Forms.ComboBox comb_choosemode;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

