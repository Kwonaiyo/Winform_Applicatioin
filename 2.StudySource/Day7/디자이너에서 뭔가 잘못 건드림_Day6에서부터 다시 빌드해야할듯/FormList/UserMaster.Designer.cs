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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.dgtView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbDept);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.lblDep);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblUserId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(713, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 68);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(494, 44);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(158, 23);
            this.cmbDept.TabIndex = 2;
            this.cmbDept.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(318, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(97, 25);
            this.txtUserName.TabIndex = 1;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(93, 43);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(97, 25);
            this.txtUserId.TabIndex = 1;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(451, 48);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(37, 15);
            this.lblDep.TabIndex = 0;
            this.lblDep.Text = "부서";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(230, 48);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 15);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "사용자이름";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(22, 48);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(65, 15);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "사용자ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave1);
            this.groupBox2.Controls.Add(this.btnDelete1);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1181, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(403, 19);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(126, 68);
            this.btnSave1.TabIndex = 1;
            this.btnSave1.TabStop = false;
            this.btnSave1.Text = "저장";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(233, 19);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(126, 68);
            this.btnDelete1.TabIndex = 1;
            this.btnDelete1.TabStop = false;
            this.btnDelete1.Text = "삭제";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 68);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete2);
            this.groupBox3.Controls.Add(this.btnSave2);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.picBox1);
            this.groupBox3.Controls.Add(this.dgtView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1181, 436);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(1043, 189);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(126, 68);
            this.btnDelete2.TabIndex = 2;
            this.btnDelete2.Text = "추가";
            this.btnDelete2.UseVisualStyleBackColor = true;
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(911, 189);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(126, 68);
            this.btnSave2.TabIndex = 2;
            this.btnSave2.Text = "추가";
            this.btnSave2.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(755, 189);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 68);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(752, 6);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(429, 177);
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // dgtView
            // 
            this.dgtView.AllowUserToAddRows = false;
            this.dgtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtView.Location = new System.Drawing.Point(6, 6);
            this.dgtView.Name = "dgtView";
            this.dgtView.RowHeadersWidth = 51;
            this.dgtView.RowTemplate.Height = 27;
            this.dgtView.Size = new System.Drawing.Size(743, 418);
            this.dgtView.TabIndex = 0;
            this.dgtView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtView_CellClick);
            // 
            // UserMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 625);
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
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.DataGridView dgtView;
    }
}