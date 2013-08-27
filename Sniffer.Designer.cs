namespace Sniffer
{
    partial class Sniffer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sniffer));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.funMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.chooseComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.startButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView = new System.Windows.Forms.ListView();
            this.timeColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.typeColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.srcColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.desColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.lengthColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funMenuItem,
            this.helpToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(594, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // funMenuItem
            // 
            this.funMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStrip,
            this.stopToolStrip,
            this.clearToolStrip,
            this.saveToolStrip,
            this.exitToolStrip});
            this.funMenuItem.Name = "funMenuItem";
            this.funMenuItem.Size = new System.Drawing.Size(44, 21);
            this.funMenuItem.Text = "功能";
            // 
            // startToolStrip
            // 
            this.startToolStrip.Name = "startToolStrip";
            this.startToolStrip.Size = new System.Drawing.Size(152, 22);
            this.startToolStrip.Text = "开始监听";
            this.startToolStrip.Click += new System.EventHandler(this.startToolStrip_Click);
            // 
            // stopToolStrip
            // 
            this.stopToolStrip.Name = "stopToolStrip";
            this.stopToolStrip.Size = new System.Drawing.Size(152, 22);
            this.stopToolStrip.Text = "结束监听";
            this.stopToolStrip.Click += new System.EventHandler(this.stopToolStrip_Click);
            // 
            // clearToolStrip
            // 
            this.clearToolStrip.Name = "clearToolStrip";
            this.clearToolStrip.Size = new System.Drawing.Size(152, 22);
            this.clearToolStrip.Text = "清除数据";
            this.clearToolStrip.Click += new System.EventHandler(this.clearToolStrip_Click);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(152, 22);
            this.exitToolStrip.Text = "退出";
            // 
            // helpToolStrip
            // 
            this.helpToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStrip});
            this.helpToolStrip.Name = "helpToolStrip";
            this.helpToolStrip.Size = new System.Drawing.Size(44, 21);
            this.helpToolStrip.Text = "帮助";
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(100, 22);
            this.aboutToolStrip.Text = "关于";
            this.aboutToolStrip.Click += new System.EventHandler(this.aboutToolStrip_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.chooseComboBox,
            this.startButton,
            this.stopButton,
            this.clearButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(594, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "选择网卡";
            // 
            // chooseComboBox
            // 
            this.chooseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseComboBox.DropDownWidth = 500;
            this.chooseComboBox.Name = "chooseComboBox";
            this.chooseComboBox.Size = new System.Drawing.Size(250, 25);
            this.chooseComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseComboBox_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(76, 22);
            this.startButton.Text = "开始监听";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(76, 22);
            this.stopButton.Text = "停止监听";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(76, 22);
            this.clearButton.Text = "清除数据";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 400);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(594, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeColumnHeader,
            this.typeColumnHeader,
            this.srcColumnHeader,
            this.desColumnHeader,
            this.lengthColumnHeader});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 50);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(594, 350);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // timeColumnHeader
            // 
            this.timeColumnHeader.Text = "时间";
            this.timeColumnHeader.Width = 150;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "协议类型";
            // 
            // srcColumnHeader
            // 
            this.srcColumnHeader.Text = "源地址";
            this.srcColumnHeader.Width = 150;
            // 
            // desColumnHeader
            // 
            this.desColumnHeader.Text = "目的地址";
            this.desColumnHeader.Width = 150;
            // 
            // lengthColumnHeader
            // 
            this.lengthColumnHeader.Text = "数据长度";
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.Size = new System.Drawing.Size(152, 22);
            this.saveToolStrip.Text = "保存到文件";
            this.saveToolStrip.Click += new System.EventHandler(this.saveToolStrip_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            // 
            // Sniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Sniffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniffer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sniffer_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem funMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStrip;
        private System.Windows.Forms.ToolStripMenuItem stopToolStrip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox chooseComboBox;
        private System.Windows.Forms.ToolStripButton startButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader timeColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader srcColumnHeader;
        private System.Windows.Forms.ColumnHeader desColumnHeader;
        private System.Windows.Forms.ColumnHeader lengthColumnHeader;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem saveToolStrip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

