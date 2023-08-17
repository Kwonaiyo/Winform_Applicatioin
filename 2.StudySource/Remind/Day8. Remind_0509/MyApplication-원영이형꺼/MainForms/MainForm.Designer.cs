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
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSaveB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.M_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI_Test1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI_Test2 = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.실적현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssFormName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRowCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNowTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.WinTimer = new System.Windows.Forms.Timer(this.components);
            this.UserMaseter_T = new System.Windows.Forms.ToolStripMenuItem();
            this.MyTab = new Services.MyTabControl();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSearch,
            this.tsbtnAdd,
            this.tsbtnDelete,
            this.tsbtnSaveB,
            this.toolStripSeparator1,
            this.tsbtnClose,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(20, 91);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1764, 110);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnSearch.Image = global::MainForms.Properties.Resources.BtnSearch;
            this.tsbtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(69, 107);
            this.tsbtnSearch.Text = "조회";
            this.tsbtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnAdd.Image = global::MainForms.Properties.Resources.BtnAdd;
            this.tsbtnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(69, 107);
            this.tsbtnAdd.Text = "추가";
            this.tsbtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnDelete.Image = global::MainForms.Properties.Resources.BtnDelete;
            this.tsbtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(69, 107);
            this.tsbtnDelete.Text = "삭제";
            this.tsbtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnSaveB
            // 
            this.tsbtnSaveB.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnSaveB.Image = global::MainForms.Properties.Resources.BtnSaveB;
            this.tsbtnSaveB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSaveB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSaveB.Name = "tsbtnSaveB";
            this.tsbtnSaveB.Size = new System.Drawing.Size(69, 107);
            this.tsbtnSaveB.Text = "저장";
            this.tsbtnSaveB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnSaveB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSaveB.Click += new System.EventHandler(this.tsbtnSaveB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 110);
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnClose.Image = global::MainForms.Properties.Resources.BtnClose;
            this.tsbtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(69, 107);
            this.tsbtnClose.Text = "닫기";
            this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnExit.Image = global::MainForms.Properties.Resources.BtcExit;
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(69, 107);
            this.tsbtnExit.Text = "종료";
            this.tsbtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_Test,
            this.M_Info,
            this.실적현황ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1764, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // M_Test
            // 
            this.M_Test.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MDI_Test1,
            this.MDI_Test2});
            this.M_Test.Name = "M_Test";
            this.M_Test.Size = new System.Drawing.Size(75, 27);
            this.M_Test.Text = "테스트";
            this.M_Test.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.M_Test_DropDownItemClicked);
            // 
            // MDI_Test1
            // 
            this.MDI_Test1.Name = "MDI_Test1";
            this.MDI_Test1.Size = new System.Drawing.Size(136, 28);
            this.MDI_Test1.Text = "MDI1";
            // 
            // MDI_Test2
            // 
            this.MDI_Test2.Name = "MDI_Test2";
            this.MDI_Test2.Size = new System.Drawing.Size(136, 28);
            this.MDI_Test2.Text = "MDI2";
            // 
            // M_Info
            // 
            this.M_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserMaster,
            this.ItemMaster,
            this.UserMaseter_T});
            this.M_Info.Name = "M_Info";
            this.M_Info.Size = new System.Drawing.Size(92, 27);
            this.M_Info.Text = "기준정보";
            this.M_Info.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.M_Test_DropDownItemClicked);
            // 
            // UserMaster
            // 
            this.UserMaster.Name = "UserMaster";
            this.UserMaster.Size = new System.Drawing.Size(224, 28);
            this.UserMaster.Text = "사용자 마스터";
            // 
            // ItemMaster
            // 
            this.ItemMaster.Name = "ItemMaster";
            this.ItemMaster.Size = new System.Drawing.Size(224, 28);
            this.ItemMaster.Text = "품목 마스터";
            // 
            // 실적현황ToolStripMenuItem
            // 
            this.실적현황ToolStripMenuItem.Name = "실적현황ToolStripMenuItem";
            this.실적현황ToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.실적현황ToolStripMenuItem.Text = "실적현황";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssFormName,
            this.toolStripStatusLabel2,
            this.tssUserName,
            this.tssRowCnt,
            this.tssNowTime});
            this.statusStrip1.Location = new System.Drawing.Point(20, 946);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1764, 40);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssFormName
            // 
            this.tssFormName.AutoSize = false;
            this.tssFormName.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tssFormName.Name = "tssFormName";
            this.tssFormName.Size = new System.Drawing.Size(200, 34);
            this.tssFormName.Text = "FormName";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(949, 34);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // tssUserName
            // 
            this.tssUserName.AutoSize = false;
            this.tssUserName.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tssUserName.Name = "tssUserName";
            this.tssUserName.Size = new System.Drawing.Size(200, 34);
            this.tssUserName.Text = "UserName";
            // 
            // tssRowCnt
            // 
            this.tssRowCnt.AutoSize = false;
            this.tssRowCnt.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tssRowCnt.Name = "tssRowCnt";
            this.tssRowCnt.Size = new System.Drawing.Size(200, 34);
            this.tssRowCnt.Text = "RowCnt";
            // 
            // tssNowTime
            // 
            this.tssNowTime.AutoSize = false;
            this.tssNowTime.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tssNowTime.Name = "tssNowTime";
            this.tssNowTime.Size = new System.Drawing.Size(200, 34);
            this.tssNowTime.Text = "NowTime";
            // 
            // WinTimer
            // 
            this.WinTimer.Interval = 1000;
            this.WinTimer.Tick += new System.EventHandler(this.WinTimer_Tick);
            // 
            // UserMaseter_T
            // 
            this.UserMaseter_T.Name = "UserMaseter_T";
            this.UserMaseter_T.Size = new System.Drawing.Size(224, 28);
            this.UserMaseter_T.Text = "사용자마스터_T";
            // 
            // MyTab
            // 
            this.MyTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTab.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.MyTab.Location = new System.Drawing.Point(20, 201);
            this.MyTab.Name = "MyTab";
            this.MyTab.Size = new System.Drawing.Size(1764, 745);
            this.MyTab.TabIndex = 4;
            this.MyTab.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 1006);
            this.Controls.Add(this.MyTab);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EZ DEV 1.0";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnSaveB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripStatusLabel tssFormName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssUserName;
        private System.Windows.Forms.ToolStripStatusLabel tssRowCnt;
        private System.Windows.Forms.ToolStripStatusLabel tssNowTime;
        private System.Windows.Forms.Timer WinTimer;
        private System.Windows.Forms.ToolStripMenuItem M_Test;
        private System.Windows.Forms.ToolStripMenuItem MDI_Test1;
        private System.Windows.Forms.ToolStripMenuItem MDI_Test2;
        private Services.MyTabControl MyTab;
        private System.Windows.Forms.ToolStripMenuItem M_Info;
        private System.Windows.Forms.ToolStripMenuItem UserMaster;
        private System.Windows.Forms.ToolStripMenuItem ItemMaster;
        private System.Windows.Forms.ToolStripMenuItem 실적현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserMaseter_T;
    }
}