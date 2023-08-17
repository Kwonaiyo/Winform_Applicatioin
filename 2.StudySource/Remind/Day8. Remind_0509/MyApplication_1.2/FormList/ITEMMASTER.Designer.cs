namespace FormList
{
    partial class ITEMMASTER
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbClose = new System.Windows.Forms.RadioButton();
            this.rdbProd = new System.Windows.Forms.RadioButton();
            this.chkOnlyName = new System.Windows.Forms.CheckBox();
            this.cboItemType = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.btnPicDelete = new System.Windows.Forms.Button();
            this.btnPicSave = new System.Windows.Forms.Button();
            this.btnPicLoad = new System.Windows.Forms.Button();
            this.dgtGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkOnlyName);
            this.groupBox1.Controls.Add(this.cboItemType);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtItemCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조회부(헤더)";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(521, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 47);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbClose);
            this.groupBox2.Controls.Add(this.rdbProd);
            this.groupBox2.Location = new System.Drawing.Point(380, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "단종 여부";
            // 
            // rdbClose
            // 
            this.rdbClose.AutoSize = true;
            this.rdbClose.Checked = true;
            this.rdbClose.Location = new System.Drawing.Point(71, 22);
            this.rdbClose.Name = "rdbClose";
            this.rdbClose.Size = new System.Drawing.Size(58, 19);
            this.rdbClose.TabIndex = 0;
            this.rdbClose.TabStop = true;
            this.rdbClose.Text = "단종";
            this.rdbClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbClose.UseVisualStyleBackColor = true;
            // 
            // rdbProd
            // 
            this.rdbProd.AutoSize = true;
            this.rdbProd.Location = new System.Drawing.Point(7, 22);
            this.rdbProd.Name = "rdbProd";
            this.rdbProd.Size = new System.Drawing.Size(58, 19);
            this.rdbProd.TabIndex = 0;
            this.rdbProd.TabStop = true;
            this.rdbProd.Text = "생산";
            this.rdbProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbProd.UseVisualStyleBackColor = true;
            // 
            // chkOnlyName
            // 
            this.chkOnlyName.AutoSize = true;
            this.chkOnlyName.Location = new System.Drawing.Point(235, 57);
            this.chkOnlyName.Name = "chkOnlyName";
            this.chkOnlyName.Size = new System.Drawing.Size(139, 19);
            this.chkOnlyName.TabIndex = 5;
            this.chkOnlyName.Text = "이름만으로 검색";
            this.chkOnlyName.UseVisualStyleBackColor = true;
            // 
            // cboItemType
            // 
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.Items.AddRange(new object[] {
            "HALB 반제품",
            "FERT 완제품",
            "ROH 원자재"});
            this.cboItemType.Location = new System.Drawing.Point(86, 57);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(125, 23);
            this.cboItemType.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(660, 26);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(109, 25);
            this.dtpEnd.TabIndex = 4;
            this.dtpEnd.Value = new System.DateTime(2023, 5, 3, 10, 33, 12, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(521, 26);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(109, 25);
            this.dtpStart.TabIndex = 4;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(290, 24);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(125, 25);
            this.txtItemName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "출시일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "품목명";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(86, 24);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(125, 25);
            this.txtItemCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "품목타입";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목코드";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1087, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "품목 정보(바디)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 39);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picItem);
            this.groupBox4.Controls.Add(this.btnPicDelete);
            this.groupBox4.Controls.Add(this.btnPicSave);
            this.groupBox4.Controls.Add(this.btnPicLoad);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1087, 250);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "이미지 관리(푸터)";
            // 
            // picItem
            // 
            this.picItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem.Location = new System.Drawing.Point(6, 26);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(214, 212);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 1;
            this.picItem.TabStop = false;
            this.picItem.Click += new System.EventHandler(this.picItem_Click);
            // 
            // btnPicDelete
            // 
            this.btnPicDelete.Location = new System.Drawing.Point(226, 145);
            this.btnPicDelete.Name = "btnPicDelete";
            this.btnPicDelete.Size = new System.Drawing.Size(148, 53);
            this.btnPicDelete.TabIndex = 0;
            this.btnPicDelete.Text = "삭제";
            this.btnPicDelete.UseVisualStyleBackColor = true;
            this.btnPicDelete.Click += new System.EventHandler(this.btnPicDelete_Click);
            // 
            // btnPicSave
            // 
            this.btnPicSave.Location = new System.Drawing.Point(226, 86);
            this.btnPicSave.Name = "btnPicSave";
            this.btnPicSave.Size = new System.Drawing.Size(148, 53);
            this.btnPicSave.TabIndex = 0;
            this.btnPicSave.Text = "저장";
            this.btnPicSave.UseVisualStyleBackColor = true;
            this.btnPicSave.Click += new System.EventHandler(this.btnPicSave_Click);
            // 
            // btnPicLoad
            // 
            this.btnPicLoad.Location = new System.Drawing.Point(226, 27);
            this.btnPicLoad.Name = "btnPicLoad";
            this.btnPicLoad.Size = new System.Drawing.Size(148, 53);
            this.btnPicLoad.TabIndex = 0;
            this.btnPicLoad.Text = "이미지 불러오기";
            this.btnPicLoad.UseVisualStyleBackColor = true;
            this.btnPicLoad.Click += new System.EventHandler(this.btnPicLoad_Click);
            // 
            // dgtGrid
            // 
            this.dgtGrid.AllowUserToAddRows = false;
            this.dgtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgtGrid.Location = new System.Drawing.Point(0, 189);
            this.dgtGrid.Name = "dgtGrid";
            this.dgtGrid.RowHeadersWidth = 51;
            this.dgtGrid.RowTemplate.Height = 27;
            this.dgtGrid.Size = new System.Drawing.Size(1087, 143);
            this.dgtGrid.TabIndex = 0;
            this.dgtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtGrid_CellClick);
            // 
            // ITEMMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 582);
            this.Controls.Add(this.dgtGrid);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ITEMMASTER";
            this.Text = "품목마스터";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ITEMMASTER_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkOnlyName;
        private System.Windows.Forms.ComboBox cboItemType;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdbClose;
        private System.Windows.Forms.RadioButton rdbProd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Button btnPicDelete;
        private System.Windows.Forms.Button btnPicSave;
        private System.Windows.Forms.Button btnPicLoad;
        private System.Windows.Forms.DataGridView dgtGrid;
    }
}