namespace FeiXian.Client
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label7 = new System.Windows.Forms.Label();
            this.cbConn = new System.Windows.Forms.ComboBox();
            this.lbAddr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkUseSql = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.numBatchSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.menuSend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miHexSend = new System.Windows.Forms.ToolStripMenuItem();
            this.mi清空2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbReceive = new System.Windows.Forms.GroupBox();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.menuReceive = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mi日志着色 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mi显示应用日志 = new System.Windows.Forms.ToolStripMenuItem();
            this.mi显示编码日志 = new System.Windows.Forms.ToolStripMenuItem();
            this.mi显示接收字符串 = new System.Windows.Forms.ToolStripMenuItem();
            this.mi显示发送数据 = new System.Windows.Forms.ToolStripMenuItem();
            this.mi显示接收数据 = new System.Windows.Forms.ToolStripMenuItem();
            this.mi显示统计信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDbWrite = new System.Windows.Forms.Button();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnAdv = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBatchSize)).BeginInit();
            this.menuSend.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.gbReceive.SuspendLayout();
            this.menuReceive.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "次数：";
            // 
            // cbConn
            // 
            this.cbConn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConn.FormattingEnabled = true;
            this.cbConn.Location = new System.Drawing.Point(65, 7);
            this.cbConn.Name = "cbConn";
            this.cbConn.Size = new System.Drawing.Size(428, 20);
            this.cbConn.TabIndex = 10;
            // 
            // lbAddr
            // 
            this.lbAddr.AutoSize = true;
            this.lbAddr.Location = new System.Drawing.Point(6, 10);
            this.lbAddr.Name = "lbAddr";
            this.lbAddr.Size = new System.Drawing.Size(53, 12);
            this.lbAddr.TabIndex = 7;
            this.lbAddr.Text = "数据库：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkUseSql);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numCount);
            this.panel1.Controls.Add(this.numThreads);
            this.panel1.Controls.Add(this.numBatchSize);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 35);
            this.panel1.TabIndex = 2;
            // 
            // chkUseSql
            // 
            this.chkUseSql.AutoSize = true;
            this.chkUseSql.Location = new System.Drawing.Point(406, 11);
            this.chkUseSql.Name = "chkUseSql";
            this.chkUseSql.Size = new System.Drawing.Size(66, 16);
            this.chkUseSql.TabIndex = 20;
            this.chkUseSql.Text = "使用SQL";
            this.chkUseSql.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "线程：";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(42, 9);
            this.numCount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(91, 21);
            this.numCount.TabIndex = 14;
            this.numCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCount.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // numThreads
            // 
            this.numThreads.Location = new System.Drawing.Point(206, 9);
            this.numThreads.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(52, 21);
            this.numThreads.TabIndex = 18;
            this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numThreads, "模拟多客户端发送，用于压力测试！");
            this.numThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBatchSize
            // 
            this.numBatchSize.Location = new System.Drawing.Point(334, 9);
            this.numBatchSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBatchSize.Name = "numBatchSize";
            this.numBatchSize.Size = new System.Drawing.Size(52, 21);
            this.numBatchSize.TabIndex = 16;
            this.numBatchSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBatchSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "批大小：";
            // 
            // menuSend
            // 
            this.menuSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHexSend,
            this.mi清空2});
            this.menuSend.Name = "menuSend";
            this.menuSend.Size = new System.Drawing.Size(123, 48);
            // 
            // miHexSend
            // 
            this.miHexSend.Name = "miHexSend";
            this.miHexSend.Size = new System.Drawing.Size(122, 22);
            this.miHexSend.Text = "Hex发送";
            this.miHexSend.Click += new System.EventHandler(this.Menu_Click);
            // 
            // mi清空2
            // 
            this.mi清空2.Name = "mi清空2";
            this.mi清空2.Size = new System.Drawing.Size(122, 22);
            this.mi清空2.Text = "清空";
            this.mi清空2.Click += new System.EventHandler(this.mi清空2_Click);
            // 
            // pnlSetting
            // 
            this.pnlSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSetting.Controls.Add(this.cbConn);
            this.pnlSetting.Controls.Add(this.lbAddr);
            this.pnlSetting.Location = new System.Drawing.Point(6, 12);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(548, 31);
            this.pnlSetting.TabIndex = 18;
            // 
            // gbReceive
            // 
            this.gbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReceive.Controls.Add(this.txtReceive);
            this.gbReceive.Location = new System.Drawing.Point(6, 90);
            this.gbReceive.Name = "gbReceive";
            this.gbReceive.Size = new System.Drawing.Size(1016, 572);
            this.gbReceive.TabIndex = 17;
            this.gbReceive.TabStop = false;
            // 
            // txtReceive
            // 
            this.txtReceive.ContextMenuStrip = this.menuReceive;
            this.txtReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceive.HideSelection = false;
            this.txtReceive.Location = new System.Drawing.Point(3, 17);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(1010, 552);
            this.txtReceive.TabIndex = 1;
            this.txtReceive.Text = "";
            // 
            // menuReceive
            // 
            this.menuReceive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mi日志着色,
            this.toolStripMenuItem3,
            this.mi显示应用日志,
            this.mi显示编码日志,
            this.mi显示接收字符串,
            this.mi显示发送数据,
            this.mi显示接收数据,
            this.mi显示统计信息});
            this.menuReceive.Name = "menuSend";
            this.menuReceive.Size = new System.Drawing.Size(161, 186);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "清空";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.mi清空_Click);
            // 
            // mi日志着色
            // 
            this.mi日志着色.Name = "mi日志着色";
            this.mi日志着色.Size = new System.Drawing.Size(160, 22);
            this.mi日志着色.Text = "日志着色";
            this.mi日志着色.Click += new System.EventHandler(this.Menu_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 6);
            // 
            // mi显示应用日志
            // 
            this.mi显示应用日志.Name = "mi显示应用日志";
            this.mi显示应用日志.Size = new System.Drawing.Size(160, 22);
            this.mi显示应用日志.Text = "显示应用日志";
            this.mi显示应用日志.Click += new System.EventHandler(this.Menu_Click);
            // 
            // mi显示编码日志
            // 
            this.mi显示编码日志.Name = "mi显示编码日志";
            this.mi显示编码日志.Size = new System.Drawing.Size(160, 22);
            this.mi显示编码日志.Text = "显示网络日志";
            this.mi显示编码日志.Click += new System.EventHandler(this.Menu_Click);
            // 
            // mi显示接收字符串
            // 
            this.mi显示接收字符串.Name = "mi显示接收字符串";
            this.mi显示接收字符串.Size = new System.Drawing.Size(160, 22);
            this.mi显示接收字符串.Text = "显示接收字符串";
            this.mi显示接收字符串.Click += new System.EventHandler(this.Menu_Click);
            // 
            // mi显示发送数据
            // 
            this.mi显示发送数据.Name = "mi显示发送数据";
            this.mi显示发送数据.Size = new System.Drawing.Size(160, 22);
            this.mi显示发送数据.Text = "显示发送数据";
            this.mi显示发送数据.Click += new System.EventHandler(this.Menu_Click);
            // 
            // mi显示接收数据
            // 
            this.mi显示接收数据.Name = "mi显示接收数据";
            this.mi显示接收数据.Size = new System.Drawing.Size(160, 22);
            this.mi显示接收数据.Text = "显示接收数据";
            this.mi显示接收数据.Click += new System.EventHandler(this.Menu_Click);
            // 
            // mi显示统计信息
            // 
            this.mi显示统计信息.Name = "mi显示统计信息";
            this.mi显示统计信息.Size = new System.Drawing.Size(160, 22);
            this.mi显示统计信息.Text = "显示统计信息";
            this.mi显示统计信息.Click += new System.EventHandler(this.Menu_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(579, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(67, 29);
            this.btnConnect.TabIndex = 16;
            this.btnConnect.Text = "打开";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "清理数据库";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDbWrite
            // 
            this.btnDbWrite.Location = new System.Drawing.Point(3, 2);
            this.btnDbWrite.Name = "btnDbWrite";
            this.btnDbWrite.Size = new System.Drawing.Size(85, 29);
            this.btnDbWrite.TabIndex = 3;
            this.btnDbWrite.Text = "Insert测试";
            this.btnDbWrite.UseVisualStyleBackColor = true;
            this.btnDbWrite.Click += new System.EventHandler(this.btnDbWrite_Click);
            // 
            // pnlAction
            // 
            this.pnlAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAction.Controls.Add(this.btnAdv);
            this.pnlAction.Controls.Add(this.btnTest);
            this.pnlAction.Controls.Add(this.btnDelete);
            this.pnlAction.Controls.Add(this.btnDbWrite);
            this.pnlAction.Enabled = false;
            this.pnlAction.Location = new System.Drawing.Point(664, 12);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(347, 31);
            this.pnlAction.TabIndex = 22;
            // 
            // btnAdv
            // 
            this.btnAdv.Location = new System.Drawing.Point(271, 1);
            this.btnAdv.Name = "btnAdv";
            this.btnAdv.Size = new System.Drawing.Size(62, 29);
            this.btnAdv.TabIndex = 7;
            this.btnAdv.Text = "高级";
            this.btnAdv.UseVisualStyleBackColor = true;
            this.btnAdv.Visible = false;
            this.btnAdv.Click += new System.EventHandler(this.btnAdv_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(203, 1);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(62, 29);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "友好名称：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(556, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 21);
            this.txtName.TabIndex = 22;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.gbReceive);
            this.Controls.Add(this.btnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码之巅，天外飞仙";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBatchSize)).EndInit();
            this.menuSend.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.gbReceive.ResumeLayout(false);
            this.menuReceive.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbConn;
        private System.Windows.Forms.Label lbAddr;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numBatchSize;
        private System.Windows.Forms.ContextMenuStrip menuSend;
        private System.Windows.Forms.ToolStripMenuItem miHexSend;
        private System.Windows.Forms.ToolStripMenuItem mi清空2;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbReceive;
        private System.Windows.Forms.RichTextBox txtReceive;
        private System.Windows.Forms.ContextMenuStrip menuReceive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mi显示应用日志;
        private System.Windows.Forms.ToolStripMenuItem mi显示编码日志;
        private System.Windows.Forms.ToolStripMenuItem mi显示接收字符串;
        private System.Windows.Forms.ToolStripMenuItem mi显示发送数据;
        private System.Windows.Forms.ToolStripMenuItem mi显示接收数据;
        private System.Windows.Forms.ToolStripMenuItem mi显示统计信息;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDbWrite;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ToolStripMenuItem mi日志着色;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUseSql;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
    }
}

