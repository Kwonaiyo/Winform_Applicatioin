namespace FormList
{
    partial class UserMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.cboDept = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRowSave = new MetroFramework.Controls.MetroButton();
            this.btnRowDelete = new MetroFramework.Controls.MetroButton();
            this.btnRowAdd = new MetroFramework.Controls.MetroButton();
            this.dgtGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnPicDelete = new MetroFramework.Controls.MetroButton();
            this.btnPicSave = new MetroFramework.Controls.MetroButton();
            this.btnPicLoad = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cboDept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1825, 110);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조회부 (헤더)";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearch.Location = new System.Drawing.Point(1334, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboDept
            // 
            this.cboDept.FormattingEnabled = true;
            this.cboDept.ItemHeight = 24;
            this.cboDept.Location = new System.Drawing.Point(967, 51);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(300, 30);
            this.cboDept.TabIndex = 9;
            this.cboDept.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(894, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "부서";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserName.Location = new System.Drawing.Point(561, 51);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 30);
            this.txtUserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(454, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "사용자 이름";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserId.Location = new System.Drawing.Point(112, 51);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(300, 30);
            this.txtUserId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "사용자 ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRowSave);
            this.groupBox2.Controls.Add(this.btnRowDelete);
            this.groupBox2.Controls.Add(this.btnRowAdd);
            this.groupBox2.Controls.Add(this.dgtGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1825, 957);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사용자 정보 (바디)";
            // 
            // btnRowSave
            // 
            this.btnRowSave.BackColor = System.Drawing.Color.White;
            this.btnRowSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRowSave.Location = new System.Drawing.Point(363, 35);
            this.btnRowSave.Name = "btnRowSave";
            this.btnRowSave.Size = new System.Drawing.Size(150, 65);
            this.btnRowSave.TabIndex = 9;
            this.btnRowSave.Text = "저장";
            this.btnRowSave.UseSelectable = true;
            this.btnRowSave.Click += new System.EventHandler(this.btnRowSave_Click);
            // 
            // btnRowDelete
            // 
            this.btnRowDelete.BackColor = System.Drawing.Color.White;
            this.btnRowDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRowDelete.Location = new System.Drawing.Point(197, 35);
            this.btnRowDelete.Name = "btnRowDelete";
            this.btnRowDelete.Size = new System.Drawing.Size(150, 65);
            this.btnRowDelete.TabIndex = 8;
            this.btnRowDelete.Text = "삭제";
            this.btnRowDelete.UseSelectable = true;
            this.btnRowDelete.Click += new System.EventHandler(this.btnRowDelete_Click);
            // 
            // btnRowAdd
            // 
            this.btnRowAdd.BackColor = System.Drawing.Color.White;
            this.btnRowAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRowAdd.Location = new System.Drawing.Point(26, 35);
            this.btnRowAdd.Name = "btnRowAdd";
            this.btnRowAdd.Size = new System.Drawing.Size(150, 65);
            this.btnRowAdd.TabIndex = 7;
            this.btnRowAdd.Text = "추가";
            this.btnRowAdd.UseSelectable = true;
            this.btnRowAdd.Click += new System.EventHandler(this.btnRowAdd_Click);
            // 
            // dgtGrid
            // 
            this.dgtGrid.AllowUserToAddRows = false;
            this.dgtGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgtGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgtGrid.Location = new System.Drawing.Point(3, 106);
            this.dgtGrid.Name = "dgtGrid";
            this.dgtGrid.RowHeadersVisible = false;
            this.dgtGrid.RowHeadersWidth = 51;
            this.dgtGrid.RowTemplate.Height = 27;
            this.dgtGrid.Size = new System.Drawing.Size(1819, 848);
            this.dgtGrid.TabIndex = 10;
            this.dgtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtGrid_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picUser);
            this.groupBox3.Controls.Add(this.btnPicDelete);
            this.groupBox3.Controls.Add(this.btnPicSave);
            this.groupBox3.Controls.Add(this.btnPicLoad);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(1383, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 957);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "이미지 관리 (푸터)";
            // 
            // picUser
            // 
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picUser.Location = new System.Drawing.Point(19, 35);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(400, 600);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 11;
            this.picUser.TabStop = false;
            // 
            // btnPicDelete
            // 
            this.btnPicDelete.BackColor = System.Drawing.Color.White;
            this.btnPicDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPicDelete.Location = new System.Drawing.Point(299, 651);
            this.btnPicDelete.Name = "btnPicDelete";
            this.btnPicDelete.Size = new System.Drawing.Size(120, 90);
            this.btnPicDelete.TabIndex = 13;
            this.btnPicDelete.Text = "삭제";
            this.btnPicDelete.UseSelectable = true;
            this.btnPicDelete.Click += new System.EventHandler(this.btnPicDelete_Click);
            // 
            // btnPicSave
            // 
            this.btnPicSave.BackColor = System.Drawing.Color.White;
            this.btnPicSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPicSave.Location = new System.Drawing.Point(160, 651);
            this.btnPicSave.Name = "btnPicSave";
            this.btnPicSave.Size = new System.Drawing.Size(120, 90);
            this.btnPicSave.TabIndex = 12;
            this.btnPicSave.Text = "저장";
            this.btnPicSave.UseSelectable = true;
            this.btnPicSave.Click += new System.EventHandler(this.btnPicSave_Click);
            // 
            // btnPicLoad
            // 
            this.btnPicLoad.BackColor = System.Drawing.Color.White;
            this.btnPicLoad.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPicLoad.Location = new System.Drawing.Point(19, 651);
            this.btnPicLoad.Name = "btnPicLoad";
            this.btnPicLoad.Size = new System.Drawing.Size(120, 90);
            this.btnPicLoad.TabIndex = 10;
            this.btnPicLoad.Text = "불러오기";
            this.btnPicLoad.UseSelectable = true;
            this.btnPicLoad.Click += new System.EventHandler(this.btnPicLoad_Click);
            // 
            // UserMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1825, 1067);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMaster";
            this.Text = "사용자 마스터";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroComboBox cboDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgtGrid;
        private MetroFramework.Controls.MetroButton btnRowSave;
        private MetroFramework.Controls.MetroButton btnRowDelete;
        private MetroFramework.Controls.MetroButton btnRowAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picUser;
        private MetroFramework.Controls.MetroButton btnPicDelete;
        private MetroFramework.Controls.MetroButton btnPicSave;
        private MetroFramework.Controls.MetroButton btnPicLoad;
    }
}