namespace MainForms
{
    partial class PasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChange));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtNowPw = new System.Windows.Forms.TextBox();
            this.txtChangePw = new System.Windows.Forms.TextBox();
            this.btnPwChange = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(186, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "현재 비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(8, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "변경할 비밀번호";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserId.Location = new System.Drawing.Point(237, 78);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(305, 43);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserId_KeyDown);
            // 
            // txtNowPw
            // 
            this.txtNowPw.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNowPw.Location = new System.Drawing.Point(237, 130);
            this.txtNowPw.Name = "txtNowPw";
            this.txtNowPw.PasswordChar = 'Ж';
            this.txtNowPw.Size = new System.Drawing.Size(305, 43);
            this.txtNowPw.TabIndex = 1;
            this.txtNowPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNowPw_KeyDown);
            // 
            // txtChangePw
            // 
            this.txtChangePw.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtChangePw.Location = new System.Drawing.Point(237, 187);
            this.txtChangePw.Name = "txtChangePw";
            this.txtChangePw.PasswordChar = '*';
            this.txtChangePw.Size = new System.Drawing.Size(305, 43);
            this.txtChangePw.TabIndex = 2;
            this.txtChangePw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChangePw_KeyDown);
            // 
            // btnPwChange
            // 
            this.btnPwChange.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPwChange.Location = new System.Drawing.Point(15, 249);
            this.btnPwChange.Name = "btnPwChange";
            this.btnPwChange.Size = new System.Drawing.Size(527, 53);
            this.btnPwChange.TabIndex = 3;
            this.btnPwChange.Text = "비밀번호 변경";
            this.btnPwChange.UseVisualStyleBackColor = true;
            this.btnPwChange.Click += new System.EventHandler(this.btnPwChange_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(491, 455);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 796);
            this.Controls.Add(this.btnPwChange);
            this.Controls.Add(this.txtChangePw);
            this.Controls.Add(this.txtNowPw);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.KeyPreview = true;
            this.Name = "PasswordChange";
            this.Text = "비밀번호 변경";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordChange_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtNowPw;
        private System.Windows.Forms.TextBox txtChangePw;
        private System.Windows.Forms.Button btnPwChange;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}