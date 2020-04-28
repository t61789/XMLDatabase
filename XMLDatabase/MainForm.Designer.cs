namespace XMLDatabase
{
    partial class Main_form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListItemChange_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteRow_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Message_label = new System.Windows.Forms.Label();
            this.Main_DataGridView = new System.Windows.Forms.DataGridView();
            this.ListItemChange_ContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListItemChange_ContextMenuStrip
            // 
            this.ListItemChange_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListItemChange_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteRow_ToolStripMenuItem});
            this.ListItemChange_ContextMenuStrip.Name = "contextMenuStrip1";
            this.ListItemChange_ContextMenuStrip.Size = new System.Drawing.Size(139, 28);
            // 
            // DeleteRow_ToolStripMenuItem
            // 
            this.DeleteRow_ToolStripMenuItem.Name = "DeleteRow_ToolStripMenuItem";
            this.DeleteRow_ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.DeleteRow_ToolStripMenuItem.Text = "删除该行";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile_ToolStripMenuItem,
            this.SaveFile_ToolStripMenuItem,
            this.SaveAs_ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // OpenFile_ToolStripMenuItem
            // 
            this.OpenFile_ToolStripMenuItem.Name = "OpenFile_ToolStripMenuItem";
            this.OpenFile_ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.OpenFile_ToolStripMenuItem.Text = "打开";
            this.OpenFile_ToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_ToolStripMenuItem_Click);
            // 
            // SaveFile_ToolStripMenuItem
            // 
            this.SaveFile_ToolStripMenuItem.Name = "SaveFile_ToolStripMenuItem";
            this.SaveFile_ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.SaveFile_ToolStripMenuItem.Text = "保存";
            this.SaveFile_ToolStripMenuItem.Click += new System.EventHandler(this.SaveFile_ToolStripMenuItem_Click);
            // 
            // SaveAs_ToolStripMenuItem
            // 
            this.SaveAs_ToolStripMenuItem.Name = "SaveAs_ToolStripMenuItem";
            this.SaveAs_ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.SaveAs_ToolStripMenuItem.Text = "另存为";
            this.SaveAs_ToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Message_label
            // 
            this.Message_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Message_label.AutoSize = true;
            this.Message_label.Location = new System.Drawing.Point(12, 432);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(0, 15);
            this.Message_label.TabIndex = 2;
            // 
            // Main_DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Main_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Main_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Main_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_DataGridView.Location = new System.Drawing.Point(13, 34);
            this.Main_DataGridView.Name = "Main_DataGridView";
            this.Main_DataGridView.RowHeadersWidth = 51;
            this.Main_DataGridView.RowTemplate.Height = 27;
            this.Main_DataGridView.Size = new System.Drawing.Size(743, 391);
            this.Main_DataGridView.TabIndex = 3;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 458);
            this.Controls.Add(this.Main_DataGridView);
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_form";
            this.Text = "XML数据库编辑器";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_form_KeyDown);
            this.ListItemChange_ContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFile_ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip ListItemChange_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteRow_ToolStripMenuItem;
        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.ToolStripMenuItem SaveAs_ToolStripMenuItem;
        private System.Windows.Forms.DataGridView Main_DataGridView;
    }
}

