namespace MainForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnPasswordChg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMemberJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "아 이 디";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserId.Location = new System.Drawing.Point(136, 72);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(306, 43);
            this.txtUserId.TabIndex = 0;
            // 
            // btnPasswordChg
            // 
            this.btnPasswordChg.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPasswordChg.Location = new System.Drawing.Point(162, 170);
            this.btnPasswordChg.Name = "btnPasswordChg";
            this.btnPasswordChg.Size = new System.Drawing.Size(135, 95);
            this.btnPasswordChg.TabIndex = 3;
            this.btnPasswordChg.Text = "비밀번호\r\n변경";
            this.btnPasswordChg.UseVisualStyleBackColor = true;
            this.btnPasswordChg.Click += new System.EventHandler(this.btnPasswordChg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "비밀번호";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassWord.Location = new System.Drawing.Point(136, 121);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(306, 43);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassWord_KeyDown);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogIn.Location = new System.Drawing.Point(16, 170);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(135, 95);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "로그인";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnMemberJoin
            // 
            this.btnMemberJoin.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMemberJoin.Location = new System.Drawing.Point(307, 170);
            this.btnMemberJoin.Name = "btnMemberJoin";
            this.btnMemberJoin.Size = new System.Drawing.Size(135, 95);
            this.btnMemberJoin.TabIndex = 5;
            this.btnMemberJoin.Text = "회원가입";
            this.btnMemberJoin.UseVisualStyleBackColor = true;
            this.btnMemberJoin.Click += new System.EventHandler(this.btnMemberJoin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 606);
            this.Controls.Add(this.btnMemberJoin);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnPasswordChg);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnPasswordChg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMemberJoin;
    }
}