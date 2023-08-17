namespace FormList
{
    partial class CustMaster0
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCusttype = new System.Windows.Forms.ComboBox();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCusttype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustcode);
            this.groupBox1.Controls.Add(this.label1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "업체코드";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCustcode
            // 
            this.txtCustcode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCustcode.Location = new System.Drawing.Point(134, 40);
            this.txtCustcode.Name = "txtCustcode";
            this.txtCustcode.Size = new System.Drawing.Size(171, 30);
            this.txtCustcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(311, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "업체명";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCustname
            // 
            this.txtCustname.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCustname.Location = new System.Drawing.Point(381, 40);
            this.txtCustname.Name = "txtCustname";
            this.txtCustname.Size = new System.Drawing.Size(210, 30);
            this.txtCustname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(608, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "거래처구분";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboCusttype
            // 
            this.cboCusttype.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboCusttype.FormattingEnabled = true;
            this.cboCusttype.Location = new System.Drawing.Point(727, 41);
            this.cboCusttype.Name = "cboCusttype";
            this.cboCusttype.Size = new System.Drawing.Size(188, 28);
            this.cboCusttype.TabIndex = 2;
            // 
            // grid1
            // 
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.Location = new System.Drawing.Point(3, 21);
            this.grid1.Name = "grid1";
            this.grid1.RowHeadersWidth = 51;
            this.grid1.RowTemplate.Height = 27;
            this.grid1.Size = new System.Drawing.Size(1062, 583);
            this.grid1.TabIndex = 0;
            // 
            // CustMaster0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1068, 607);
            this.Name = "CustMaster0";
            this.Load += new System.EventHandler(this.CustMaster0_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustcode;
        private System.Windows.Forms.ComboBox cboCusttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid1;
    }
}
