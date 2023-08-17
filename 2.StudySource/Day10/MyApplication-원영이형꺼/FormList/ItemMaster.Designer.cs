namespace FormList
{
    partial class ItemMaster
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
            this.dtpEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtpStart = new MetroFramework.Controls.MetroDateTime();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDiscontinued = new MetroFramework.Controls.MetroRadioButton();
            this.rdbProd = new MetroFramework.Controls.MetroRadioButton();
            this.chkOnlyName = new MetroFramework.Controls.MetroCheckBox();
            this.cboItemType = new MetroFramework.Controls.MetroComboBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgtGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.btnPicDelete = new MetroFramework.Controls.MetroButton();
            this.btnPicSave = new MetroFramework.Controls.MetroButton();
            this.btnPicLoad = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkOnlyName);
            this.groupBox1.Controls.Add(this.cboItemType);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.txtItemCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1765, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조회부 (헤더)";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(1098, 39);
            this.dtpEnd.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(150, 30);
            this.dtpEnd.TabIndex = 10;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(914, 39);
            this.dtpStart.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(150, 30);
            this.dtpStart.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearch.Location = new System.Drawing.Point(741, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 67);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbDiscontinued);
            this.groupBox2.Controls.Add(this.rdbProd);
            this.groupBox2.Location = new System.Drawing.Point(560, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "단종여부";
            // 
            // rdbDiscontinued
            // 
            this.rdbDiscontinued.AutoSize = true;
            this.rdbDiscontinued.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbDiscontinued.Location = new System.Drawing.Point(92, 29);
            this.rdbDiscontinued.Name = "rdbDiscontinued";
            this.rdbDiscontinued.Size = new System.Drawing.Size(55, 20);
            this.rdbDiscontinued.TabIndex = 7;
            this.rdbDiscontinued.Text = "단종";
            this.rdbDiscontinued.UseSelectable = true;
            // 
            // rdbProd
            // 
            this.rdbProd.AutoSize = true;
            this.rdbProd.Checked = true;
            this.rdbProd.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbProd.Location = new System.Drawing.Point(22, 29);
            this.rdbProd.Name = "rdbProd";
            this.rdbProd.Size = new System.Drawing.Size(55, 20);
            this.rdbProd.TabIndex = 6;
            this.rdbProd.TabStop = true;
            this.rdbProd.Text = "생산";
            this.rdbProd.UseSelectable = true;
            // 
            // chkOnlyName
            // 
            this.chkOnlyName.AutoSize = true;
            this.chkOnlyName.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkOnlyName.Location = new System.Drawing.Point(425, 88);
            this.chkOnlyName.Name = "chkOnlyName";
            this.chkOnlyName.Size = new System.Drawing.Size(134, 20);
            this.chkOnlyName.TabIndex = 5;
            this.chkOnlyName.Text = "이름만으로 검색";
            this.chkOnlyName.UseSelectable = true;
            // 
            // cboItemType
            // 
            this.cboItemType.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.ItemHeight = 29;
            this.cboItemType.Location = new System.Drawing.Point(109, 85);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(300, 35);
            this.cboItemType.TabIndex = 4;
            this.cboItemType.UseSelectable = true;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Location = new System.Drawing.Point(511, 39);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(300, 30);
            this.txtItemName.TabIndex = 1;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.White;
            this.txtItemCode.Location = new System.Drawing.Point(109, 39);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(300, 30);
            this.txtItemCode.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1070, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "출시일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "품목명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "품목 타입";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목 코드";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgtGrid);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(15, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1765, 409);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "품목 정보 (바디)";
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgtGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgtGrid.Location = new System.Drawing.Point(3, 106);
            this.dgtGrid.Name = "dgtGrid";
            this.dgtGrid.RowHeadersVisible = false;
            this.dgtGrid.RowHeadersWidth = 51;
            this.dgtGrid.RowTemplate.Height = 27;
            this.dgtGrid.Size = new System.Drawing.Size(1759, 300);
            this.dgtGrid.TabIndex = 12;
            this.dgtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtGrid_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(344, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 67);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "저장";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.Location = new System.Drawing.Point(180, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 67);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.Location = new System.Drawing.Point(16, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 67);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picItem);
            this.groupBox4.Controls.Add(this.btnPicDelete);
            this.groupBox4.Controls.Add(this.btnPicSave);
            this.groupBox4.Controls.Add(this.btnPicLoad);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(15, 589);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1765, 475);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "이미지 관리 (푸터)";
            // 
            // picItem
            // 
            this.picItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picItem.Location = new System.Drawing.Point(6, 29);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(444, 333);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 0;
            this.picItem.TabStop = false;
            // 
            // btnPicDelete
            // 
            this.btnPicDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPicDelete.Location = new System.Drawing.Point(470, 262);
            this.btnPicDelete.Name = "btnPicDelete";
            this.btnPicDelete.Size = new System.Drawing.Size(200, 100);
            this.btnPicDelete.TabIndex = 15;
            this.btnPicDelete.Text = "삭제";
            this.btnPicDelete.UseSelectable = true;
            this.btnPicDelete.Click += new System.EventHandler(this.btnPicDelete_Click);
            // 
            // btnPicSave
            // 
            this.btnPicSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPicSave.Location = new System.Drawing.Point(470, 144);
            this.btnPicSave.Name = "btnPicSave";
            this.btnPicSave.Size = new System.Drawing.Size(200, 100);
            this.btnPicSave.TabIndex = 14;
            this.btnPicSave.Text = "저장";
            this.btnPicSave.UseSelectable = true;
            this.btnPicSave.Click += new System.EventHandler(this.btnPicSave_Click);
            // 
            // btnPicLoad
            // 
            this.btnPicLoad.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPicLoad.Location = new System.Drawing.Point(470, 29);
            this.btnPicLoad.Name = "btnPicLoad";
            this.btnPicLoad.Size = new System.Drawing.Size(200, 100);
            this.btnPicLoad.TabIndex = 13;
            this.btnPicLoad.Text = "이미지 불러오기";
            this.btnPicLoad.UseSelectable = true;
            this.btnPicLoad.Click += new System.EventHandler(this.btnPicLoad_Click);
            // 
            // ItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1795, 1079);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemMaster";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "품목 마스터";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroRadioButton rdbDiscontinued;
        private MetroFramework.Controls.MetroRadioButton rdbProd;
        private MetroFramework.Controls.MetroCheckBox chkOnlyName;
        private MetroFramework.Controls.MetroComboBox cboItemType;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picItem;
        private MetroFramework.Controls.MetroButton btnPicDelete;
        private MetroFramework.Controls.MetroButton btnPicSave;
        private MetroFramework.Controls.MetroButton btnPicLoad;
        private System.Windows.Forms.DataGridView dgtGrid;
        private MetroFramework.Controls.MetroDateTime dtpEnd;
        private MetroFramework.Controls.MetroDateTime dtpStart;
    }
}