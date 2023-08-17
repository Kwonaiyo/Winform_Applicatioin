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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssSearch = new System.Windows.Forms.ToolStripButton();
            this.tssAdd = new System.Windows.Forms.ToolStripButton();
            this.tssDelete = new System.Windows.Forms.ToolStripButton();
            this.tssSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tssClose = new System.Windows.Forms.ToolStripButton();
            this.tssExit = new System.Windows.Forms.ToolStripButton();
            this.tslFormName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslNowDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowTime = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSearch,
            this.tssAdd,
            this.tssDelete,
            this.tssSave,
            this.toolStripSeparator1,
            this.tssClose,
            this.tssExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1166, 100);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFormName,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.tslNowDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1166, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssSearch
            // 
            this.tssSearch.Image = global::MainForms.Properties.Resources.BtnSearch;
            this.tssSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssSearch.Name = "tssSearch";
            this.tssSearch.Size = new System.Drawing.Size(54, 97);
            this.tssSearch.Text = "조회";
            this.tssSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tssSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tssAdd
            // 
            this.tssAdd.Image = global::MainForms.Properties.Resources.BtnAdd;
            this.tssAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssAdd.Name = "tssAdd";
            this.tssAdd.Size = new System.Drawing.Size(54, 97);
            this.tssAdd.Text = "추가";
            this.tssAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tssAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tssDelete
            // 
            this.tssDelete.Image = global::MainForms.Properties.Resources.BtnDelete;
            this.tssDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssDelete.Name = "tssDelete";
            this.tssDelete.Size = new System.Drawing.Size(54, 97);
            this.tssDelete.Text = "삭제";
            this.tssDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tssDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tssSave
            // 
            this.tssSave.Image = global::MainForms.Properties.Resources.BtnSaveB;
            this.tssSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssSave.Name = "tssSave";
            this.tssSave.Size = new System.Drawing.Size(54, 97);
            this.tssSave.Text = "저장";
            this.tssSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tssSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 100);
            // 
            // tssClose
            // 
            this.tssClose.Image = global::MainForms.Properties.Resources.BtnClose;
            this.tssClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssClose.Name = "tssClose";
            this.tssClose.Size = new System.Drawing.Size(54, 97);
            this.tssClose.Text = "닫기";
            this.tssClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tssClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tssExit
            // 
            this.tssExit.Image = global::MainForms.Properties.Resources.BtcExit;
            this.tssExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssExit.Name = "tssExit";
            this.tssExit.Size = new System.Drawing.Size(54, 97);
            this.tssExit.Text = "종료";
            this.tssExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tssExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tslFormName
            // 
            this.tslFormName.Name = "tslFormName";
            this.tslFormName.Size = new System.Drawing.Size(83, 20);
            this.tslFormName.Text = "FormName";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(564, 20);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // tslNowDate
            // 
            this.tslNowDate.AutoSize = false;
            this.tslNowDate.Name = "tslNowDate";
            this.tslNowDate.Size = new System.Drawing.Size(200, 20);
            this.tslNowDate.Text = "DateTime";
            // 
            // NowTime
            // 
            this.NowTime.Enabled = true;
            this.NowTime.Interval = 1000;
            this.NowTime.Tick += new System.EventHandler(this.NowTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 407);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EZ DEV 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tssSearch;
        private System.Windows.Forms.ToolStripButton tssAdd;
        private System.Windows.Forms.ToolStripButton tssDelete;
        private System.Windows.Forms.ToolStripButton tssSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tssClose;
        private System.Windows.Forms.ToolStripButton tssExit;
        private System.Windows.Forms.ToolStripStatusLabel tslFormName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tslNowDate;
        private System.Windows.Forms.Timer NowTime;
    }
}