namespace LvanaScope
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectMenuToolStrip = new System.Windows.Forms.MenuStrip();
            this.ComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaudRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SampleRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1KHz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10KHz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem100KHz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1MHz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10MHz = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.graphePanel1 = new LvanaScope.GraphePanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSend = new System.Windows.Forms.TextBox();
            this.RdoSendModeHex = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.RdoSendModeText = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextReceive = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.RdoReceiveModeText = new System.Windows.Forms.RadioButton();
            this.RdoReceiveModeHex = new System.Windows.Forms.RadioButton();
            this.ConnectMenuToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectMenuToolStrip
            // 
            this.ConnectMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComToolStripMenuItem,
            this.BaudRateToolStripMenuItem,
            this.ConnectToolStripMenuItem,
            this.SampleRateToolStripMenuItem,
            this.PlayStopToolStripMenuItem});
            this.ConnectMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ConnectMenuToolStrip.Name = "ConnectMenuToolStrip";
            this.ConnectMenuToolStrip.Size = new System.Drawing.Size(1102, 79);
            this.ConnectMenuToolStrip.TabIndex = 1;
            this.ConnectMenuToolStrip.Text = "menuStrip1";
            // 
            // ComToolStripMenuItem
            // 
            this.ComToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.comport_48x48;
            this.ComToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComToolStripMenuItem.Name = "ComToolStripMenuItem";
            this.ComToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.ComToolStripMenuItem.Size = new System.Drawing.Size(60, 75);
            this.ComToolStripMenuItem.Text = "COM1";
            this.ComToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ComToolStripMenuItem.MouseEnter += new System.EventHandler(this.ComToolStripMenuItem_MouseEnter);
            // 
            // BaudRateToolStripMenuItem
            // 
            this.BaudRateToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.baud_48x48;
            this.BaudRateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BaudRateToolStripMenuItem.Name = "BaudRateToolStripMenuItem";
            this.BaudRateToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.BaudRateToolStripMenuItem.Size = new System.Drawing.Size(60, 75);
            this.BaudRateToolStripMenuItem.Text = "9600";
            this.BaudRateToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ConnectToolStripMenuItem
            // 
            this.ConnectToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.connect_off_48x48;
            this.ConnectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem";
            this.ConnectToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.ConnectToolStripMenuItem.Size = new System.Drawing.Size(64, 75);
            this.ConnectToolStripMenuItem.Text = "Connect";
            this.ConnectToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConnectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // SampleRateToolStripMenuItem
            // 
            this.SampleRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1KHz,
            this.toolStripMenuItem10KHz,
            this.toolStripMenuItem100KHz,
            this.toolStripMenuItem1MHz,
            this.toolStripMenuItem10MHz});
            this.SampleRateToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.samplerate_48x48;
            this.SampleRateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SampleRateToolStripMenuItem.Name = "SampleRateToolStripMenuItem";
            this.SampleRateToolStripMenuItem.Size = new System.Drawing.Size(84, 75);
            this.SampleRateToolStripMenuItem.Text = "Sample Rate";
            this.SampleRateToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1KHz
            // 
            this.toolStripMenuItem1KHz.Name = "toolStripMenuItem1KHz";
            this.toolStripMenuItem1KHz.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem1KHz.Text = "1KHz";
            this.toolStripMenuItem1KHz.Click += new System.EventHandler(this.toolStripMenuItemSampleRate_Click);
            // 
            // toolStripMenuItem10KHz
            // 
            this.toolStripMenuItem10KHz.Name = "toolStripMenuItem10KHz";
            this.toolStripMenuItem10KHz.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem10KHz.Text = "10KHz";
            this.toolStripMenuItem10KHz.Click += new System.EventHandler(this.toolStripMenuItemSampleRate_Click);
            // 
            // toolStripMenuItem100KHz
            // 
            this.toolStripMenuItem100KHz.Name = "toolStripMenuItem100KHz";
            this.toolStripMenuItem100KHz.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem100KHz.Text = "100KHz";
            this.toolStripMenuItem100KHz.Click += new System.EventHandler(this.toolStripMenuItemSampleRate_Click);
            // 
            // toolStripMenuItem1MHz
            // 
            this.toolStripMenuItem1MHz.Name = "toolStripMenuItem1MHz";
            this.toolStripMenuItem1MHz.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem1MHz.Text = "1MHz";
            this.toolStripMenuItem1MHz.Click += new System.EventHandler(this.toolStripMenuItemSampleRate_Click);
            // 
            // toolStripMenuItem10MHz
            // 
            this.toolStripMenuItem10MHz.Name = "toolStripMenuItem10MHz";
            this.toolStripMenuItem10MHz.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem10MHz.Text = "10MHz";
            this.toolStripMenuItem10MHz.Click += new System.EventHandler(this.toolStripMenuItemSampleRate_Click);
            // 
            // PlayStopToolStripMenuItem
            // 
            this.PlayStopToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.play_48x48;
            this.PlayStopToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PlayStopToolStripMenuItem.Name = "PlayStopToolStripMenuItem";
            this.PlayStopToolStripMenuItem.Size = new System.Drawing.Size(60, 75);
            this.PlayStopToolStripMenuItem.Text = "Play";
            this.PlayStopToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PlayStopToolStripMenuItem.Click += new System.EventHandler(this.PlayStopToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.graphePanel1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Size = new System.Drawing.Size(1102, 596);
            this.splitContainer1.SplitterDistance = 752;
            this.splitContainer1.TabIndex = 2;
            // 
            // graphePanel1
            // 
            this.graphePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphePanel1.Location = new System.Drawing.Point(2, 2);
            this.graphePanel1.Name = "graphePanel1";
            this.graphePanel1.Padding = new System.Windows.Forms.Padding(2);
            this.graphePanel1.Size = new System.Drawing.Size(748, 592);
            this.graphePanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textSend);
            this.groupBox2.Controls.Add(this.RdoSendModeHex);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.RdoSendModeText);
            this.groupBox2.Location = new System.Drawing.Point(15, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 110);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Box";
            // 
            // textSend
            // 
            this.textSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSend.Location = new System.Drawing.Point(6, 31);
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(303, 26);
            this.textSend.TabIndex = 2;
            // 
            // RdoSendModeHex
            // 
            this.RdoSendModeHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RdoSendModeHex.AutoSize = true;
            this.RdoSendModeHex.Location = new System.Drawing.Point(71, 63);
            this.RdoSendModeHex.Name = "RdoSendModeHex";
            this.RdoSendModeHex.Size = new System.Drawing.Size(55, 24);
            this.RdoSendModeHex.TabIndex = 2;
            this.RdoSendModeHex.Text = "Hex";
            this.RdoSendModeHex.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(167, 63);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(142, 33);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // RdoSendModeText
            // 
            this.RdoSendModeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RdoSendModeText.AutoSize = true;
            this.RdoSendModeText.Checked = true;
            this.RdoSendModeText.Location = new System.Drawing.Point(8, 63);
            this.RdoSendModeText.Name = "RdoSendModeText";
            this.RdoSendModeText.Size = new System.Drawing.Size(57, 24);
            this.RdoSendModeText.TabIndex = 2;
            this.RdoSendModeText.TabStop = true;
            this.RdoSendModeText.Text = "Text";
            this.RdoSendModeText.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextReceive);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.RdoReceiveModeText);
            this.groupBox1.Controls.Add(this.RdoReceiveModeHex);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 451);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive Box";
            // 
            // richTextReceive
            // 
            this.richTextReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextReceive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextReceive.ForeColor = System.Drawing.Color.Aqua;
            this.richTextReceive.Location = new System.Drawing.Point(6, 25);
            this.richTextReceive.Name = "richTextReceive";
            this.richTextReceive.ReadOnly = true;
            this.richTextReceive.Size = new System.Drawing.Size(305, 375);
            this.richTextReceive.TabIndex = 1;
            this.richTextReceive.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(169, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RdoReceiveModeText
            // 
            this.RdoReceiveModeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RdoReceiveModeText.AutoSize = true;
            this.RdoReceiveModeText.Checked = true;
            this.RdoReceiveModeText.Location = new System.Drawing.Point(10, 412);
            this.RdoReceiveModeText.Name = "RdoReceiveModeText";
            this.RdoReceiveModeText.Size = new System.Drawing.Size(57, 24);
            this.RdoReceiveModeText.TabIndex = 2;
            this.RdoReceiveModeText.TabStop = true;
            this.RdoReceiveModeText.Text = "Text";
            this.RdoReceiveModeText.UseVisualStyleBackColor = true;
            // 
            // RdoReceiveModeHex
            // 
            this.RdoReceiveModeHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RdoReceiveModeHex.AutoSize = true;
            this.RdoReceiveModeHex.Location = new System.Drawing.Point(73, 412);
            this.RdoReceiveModeHex.Name = "RdoReceiveModeHex";
            this.RdoReceiveModeHex.Size = new System.Drawing.Size(55, 24);
            this.RdoReceiveModeHex.TabIndex = 2;
            this.RdoReceiveModeHex.Text = "Hex";
            this.RdoReceiveModeHex.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 675);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ConnectMenuToolStrip);
            this.MainMenuStrip = this.ConnectMenuToolStrip;
            this.Name = "MainForm";
            this.Text = "LvanaScope";
            this.ConnectMenuToolStrip.ResumeLayout(false);
            this.ConnectMenuToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ConnectMenuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaudRateToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private GraphePanel graphePanel1;
        private System.Windows.Forms.ToolStripMenuItem ConnectToolStripMenuItem;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton RdoSendModeHex;
        private System.Windows.Forms.RadioButton RdoSendModeText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton RdoReceiveModeHex;
        private System.Windows.Forms.RadioButton RdoReceiveModeText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextReceive;
        private System.Windows.Forms.ToolStripMenuItem SampleRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1KHz;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10KHz;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100KHz;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1MHz;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10MHz;
        private System.Windows.Forms.ToolStripMenuItem PlayStopToolStripMenuItem;
    }
}

