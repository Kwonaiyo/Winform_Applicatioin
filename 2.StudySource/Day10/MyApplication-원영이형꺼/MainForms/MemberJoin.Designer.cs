namespace MainForms
{
    partial class MemberJoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberJoin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtPassWord2 = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.txtUserAddress = new System.Windows.Forms.TextBox();
            this.btnIdCheck = new System.Windows.Forms.Button();
            this.btnMemberJoin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "*비밀번호 확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(102, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "*아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(74, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "*비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(130, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "*이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(114, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "이메일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(142, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "주소";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserId.Location = new System.Drawing.Point(221, 80);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(330, 43);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            this.txtUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserId_KeyDown);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassWord.Location = new System.Drawing.Point(221, 129);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(330, 43);
            this.txtPassWord.TabIndex = 2;
            // 
            // txtPassWord2
            // 
            this.txtPassWord2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassWord2.Location = new System.Drawing.Point(221, 178);
            this.txtPassWord2.Name = "txtPassWord2";
            this.txtPassWord2.PasswordChar = '*';
            this.txtPassWord2.Size = new System.Drawing.Size(330, 43);
            this.txtPassWord2.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserName.Location = new System.Drawing.Point(221, 227);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(330, 43);
            this.txtUserName.TabIndex = 4;
            // 
            // txtUserMail
            // 
            this.txtUserMail.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserMail.Location = new System.Drawing.Point(221, 276);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(330, 43);
            this.txtUserMail.TabIndex = 5;
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserAddress.Location = new System.Drawing.Point(221, 325);
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.Size = new System.Drawing.Size(330, 43);
            this.txtUserAddress.TabIndex = 6;
            // 
            // btnIdCheck
            // 
            this.btnIdCheck.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnIdCheck.Location = new System.Drawing.Point(557, 80);
            this.btnIdCheck.Name = "btnIdCheck";
            this.btnIdCheck.Size = new System.Drawing.Size(115, 43);
            this.btnIdCheck.TabIndex = 1;
            this.btnIdCheck.Text = "중복확인";
            this.btnIdCheck.UseVisualStyleBackColor = true;
            this.btnIdCheck.Click += new System.EventHandler(this.btnIdCheck_Click);
            // 
            // btnMemberJoin
            // 
            this.btnMemberJoin.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMemberJoin.Location = new System.Drawing.Point(221, 374);
            this.btnMemberJoin.Name = "btnMemberJoin";
            this.btnMemberJoin.Size = new System.Drawing.Size(330, 61);
            this.btnMemberJoin.TabIndex = 7;
            this.btnMemberJoin.Text = "회원가입";
            this.btnMemberJoin.UseVisualStyleBackColor = true;
            this.btnMemberJoin.Click += new System.EventHandler(this.btnMemberJoin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-33, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 804);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(41, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "* 항목은 필수입력";
            // 
            // MemberJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 1048);
            this.Controls.Add(this.btnMemberJoin);
            this.Controls.Add(this.btnIdCheck);
            this.Controls.Add(this.txtUserAddress);
            this.Controls.Add(this.txtUserMail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassWord2);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Name = "MemberJoin";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.Join_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtPassWord2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.TextBox txtUserAddress;
        private System.Windows.Forms.Button btnIdCheck;
        private System.Windows.Forms.Button btnMemberJoin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}