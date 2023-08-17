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
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNowPw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChangePw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPwChange = new System.Windows.Forms.Button();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(92, 37);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(223, 25);
            this.txtUserId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtNowPw
            // 
            this.txtNowPw.Location = new System.Drawing.Point(92, 85);
            this.txtNowPw.Name = "txtNowPw";
            this.txtNowPw.Size = new System.Drawing.Size(223, 25);
            this.txtNowPw.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "현재PW";
            // 
            // txtChangePw
            // 
            this.txtChangePw.Location = new System.Drawing.Point(92, 131);
            this.txtChangePw.Name = "txtChangePw";
            this.txtChangePw.Size = new System.Drawing.Size(223, 25);
            this.txtChangePw.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "변경PW";
            // 
            // btnPwChange
            // 
            this.btnPwChange.Location = new System.Drawing.Point(120, 189);
            this.btnPwChange.Name = "btnPwChange";
            this.btnPwChange.Size = new System.Drawing.Size(109, 75);
            this.btnPwChange.TabIndex = 2;
            this.btnPwChange.TabStop = false;
            this.btnPwChange.Text = "비밀번호변경";
            this.btnPwChange.UseVisualStyleBackColor = true;
            this.btnPwChange.Click += new System.EventHandler(this.btnPwChange_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.Location = new System.Drawing.Point(250, 189);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(109, 75);
            this.btnClose1.TabIndex = 2;
            this.btnClose1.TabStop = false;
            this.btnClose1.Text = "닫기";
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 292);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.btnPwChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChangePw);
            this.Controls.Add(this.txtNowPw);
            this.Controls.Add(this.txtUserId);
            this.Name = "PasswordChange";
            this.Text = "비밀번호변경";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNowPw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChangePw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPwChange;
        private System.Windows.Forms.Button btnClose1;
    }
}