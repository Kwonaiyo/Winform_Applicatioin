namespace MainForms
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.tssFormName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRowCNT = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNowTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.WinTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSearch,
            this.tsbtnAdd,
            this.tsbtnDelete,
            this.tsbtnSave,
            this.toolStripSeparator1,
            this.tsbtnClose,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1188, 100);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssFormName,
            this.toolStripStatusLabel2,
            this.tssUserName,
            this.tssRowCNT,
            this.tssNowTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 100);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Image = global::MainForms.Properties.Resources.BtnSearch;
            this.tsbtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(54, 97);
            this.tsbtnSearch.Text = "조회";
            this.tsbtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSearch.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = global::MainForms.Properties.Resources.BtnAdd;
            this.tsbtnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(54, 97);
            this.tsbtnAdd.Text = "추가";
            this.tsbtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = global::MainForms.Properties.Resources.BtnDelete;
            this.tsbtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(54, 97);
            this.tsbtnDelete.Text = "삭제";
            this.tsbtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = global::MainForms.Properties.Resources.BtnSaveB;
            this.tsbtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(54, 97);
            this.tsbtnSave.Text = "저장";
            this.tsbtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Image = global::MainForms.Properties.Resources.BtnClose;
            this.tsbtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(54, 97);
            this.tsbtnClose.Text = "닫기";
            this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = global::MainForms.Properties.Resources.BtcExit;
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(54, 97);
            this.tsbtnExit.Text = "종료";
            this.tsbtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // tssFormName
            // 
            this.tssFormName.AutoSize = false;
            this.tssFormName.Name = "tssFormName";
            this.tssFormName.Size = new System.Drawing.Size(200, 16);
            this.tssFormName.Text = "FormName";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(471, 16);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // tssUserName
            // 
            this.tssUserName.AutoSize = false;
            this.tssUserName.Name = "tssUserName";
            this.tssUserName.Size = new System.Drawing.Size(152, 16);
            this.tssUserName.Text = "UserName";
            // 
            // tssRowCNT
            // 
            this.tssRowCNT.AutoSize = false;
            this.tssRowCNT.Name = "tssRowCNT";
            this.tssRowCNT.Size = new System.Drawing.Size(150, 16);
            this.tssRowCNT.Text = "RowCNT";
            // 
            // tssNowTime
            // 
            this.tssNowTime.AutoSize = false;
            this.tssNowTime.Name = "tssNowTime";
            this.tssNowTime.Size = new System.Drawing.Size(200, 16);
            this.tssNowTime.Text = "NowTime";
            // 
            // WinTimer
            // 
            this.WinTimer.Interval = 1000;
            this.WinTimer.Tick += new System.EventHandler(this.WinTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EZ DEV 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripStatusLabel tssFormName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssUserName;
        private System.Windows.Forms.ToolStripStatusLabel tssRowCNT;
        private System.Windows.Forms.ToolStripStatusLabel tssNowTime;
        private System.Windows.Forms.Timer WinTimer;
    }
}